using System;
using System.Data.SqlTypes;
using System.IO;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace Gcode_Injector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OPFL_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "GCode files (*.gcode)|*.gcode|All Files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = ofd.FileName;
                Display.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (dialSave.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dialSave.FileName) == ".gcode")
                {
                    Display.SaveFile(dialSave.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            int ssl = 0, sel = 0, lwi = 0, lsl = 0, lel = 0, tsl = 0, tel = 0, tv = 0;
            string type = "Layer";
            double ntr = 0, sm = 0, ml = 0, lm = 0;

            int curlayer;

            if (Insert.Checked)
            {
                if (Layertoinsert.Text.Length != 0)
                    lwi = Int32.Parse(Layertoinsert.Text);
                else
                    lwi = 0;

                StreamReader sr = new StreamReader(FileName.Text);
                String line;

                int index = 0;
                curlayer = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("G1") && line.Contains("Z"))
                    {
                        curlayer++;
                    }

                    if (curlayer == lwi)
                    {
                        Display.Text = Display.Text.Insert(index, Whattoinsert.Text + "\n");
                        sr.ReadToEnd();
                    }
                    index = index + line.Length + 1;
                }
            }


            if (ResumePrint.Checked) // values for resuming a print
            {
                if (layersaumm.SelectedItem != null)
                    type = layersaumm.SelectedItem.ToString();
                if (numbertoresume.Text.Length != 0)
                    ntr = Convert.ToDouble(numbertoresume.Text);

                StreamReader sr = new StreamReader(FileName.Text);
                String line, aux = "";

                int index = 0, previndex = 0, newindex = 0;
                curlayer = 0;
                double actual = 0, prev = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("G1") && line.Contains("Z"))
                    {
                        curlayer++;
                        aux = line.Substring(line.IndexOf("Z") + 1);
                        aux = aux.Remove(aux.IndexOf(" "));
                        if (aux[0] == '.')
                            aux = "0" + aux;

                        prev = actual;
                        previndex = newindex;
                        newindex = index;
                        actual = Convert.ToDouble(aux);
                    }

                    if (type == "Layer" && curlayer == Math.Floor(ntr))
                    {
                        Display.Text = "G0 Z" + (actual + 10).ToString() + " F750\n" + Display.Text.Substring(index);
                        break;
                    }
                    else
                        if (type == "mm")
                        if (Math.Abs(ntr - prev) < Math.Abs(ntr - actual) && prev <= ntr && actual >= ntr)
                        {
                            Display.Text = Display.Text.Substring(previndex);
                            Display.Text = Display.Text.Insert(0, ("G0 Z" + (ntr + 10).ToString() + " F750\n"));
                            break;
                        }
                        else
                        if (Math.Abs(ntr - prev) >= Math.Abs(ntr - actual) && prev <= ntr && actual >= ntr)
                        {
                            Display.Text = Display.Text.Substring(newindex);
                            Display.Text = Display.Text.Insert(0, ("G0 Z" + (ntr + 10).ToString() + " F750\n"));
                            break;
                        }

                    index = index + line.Length + 1;

                }
            }

            if (Speedbox.Checked) // values for speed between certain layers
            {
                if (startlayer.Text.Length != 0)
                    ssl = Int32.Parse(startlayer.Text);
                if (endlayer.Text.Length != 0)
                    sel = Int32.Parse(endlayer.Text);
                if (speedmultiply.Text.Length != 0)
                    sm = Convert.ToDouble(speedmultiply.Text);

                StreamReader sr = new StreamReader(FileName.Text);
                String line, aux = "";

                int index = 0, inserted = 0, speed = 0;
                curlayer = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("G1") && line.Contains("Z"))
                    {
                        curlayer++;
                    }

                    if (line.Contains("F") && line.Contains("G1") && curlayer >= ssl && curlayer <= sel)
                    {
                        aux = line.Substring(line.IndexOf("F") + 1);
                        if (aux.IndexOf(" ") != -1)
                            aux = aux.Remove(aux.IndexOf(" "));
                        speed = Convert.ToInt32(aux);

                        if (speed <= 5000)
                        {
                            speed = Convert.ToInt32(speed * sm);
                            Display.Text = Display.Text.Remove(index, line.Length);
                            line = line.Remove(line.IndexOf("F") + 1, aux.Length);
                            line = line.Insert(line.IndexOf("F") + 1, speed.ToString());
                            Display.Text = Display.Text.Insert(index, line);
                        }
                    }
                    if (curlayer > sel)
                        sr.ReadToEnd();
                    index = index + line.Length + 1;
                }
            }

            if (LineSpeedCheck.Checked) // values for speed of straight lines between certain layers
            {
                if (MinLenght.Text.Length != 0)
                    ml = Convert.ToDouble(MinLenght.Text);
                if (linestartlayer.Text.Length != 0)
                    lsl = Int32.Parse(linestartlayer.Text);
                if (lineendlayer.Text.Length != 0)
                    lel = Int32.Parse(lineendlayer.Text);
                if (linemultiply.Text.Length != 0)
                    lm = Convert.ToDouble(linemultiply.Text);

                StreamReader sr = new StreamReader(FileName.Text);
                String line, aux = "";

                int index = 0, inserted = 0;
                curlayer = 0;
                double x = 0, prevx = 0, y = 0, prevy = 0, speed = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("G1") && line.Contains("Z"))
                    {
                        curlayer++;
                    }

                    if (line.Contains("F") && line.Contains("G1"))
                    {
                        aux = line.Substring(line.IndexOf("F") + 1);
                        if (aux.IndexOf(" ") != -1)
                            aux = aux.Remove(aux.IndexOf(" "));
                        speed = Convert.ToInt32(aux);
                        inserted = 0;
                    }

                    if (line.Contains("G1") && line.Contains("X") && line.Contains("Y") && curlayer >= lsl && curlayer <= lel)
                    {
                        aux = line.Substring(line.IndexOf("X") + 1);
                        if (aux.IndexOf(" ") != -1)
                            aux = aux.Remove(aux.IndexOf(" "));
                        prevx = x;
                        x = Convert.ToDouble(aux);
                        aux = line.Substring(line.IndexOf("Y") + 1);
                        if (aux.IndexOf(" ") != -1)
                            aux = aux.Remove(aux.IndexOf(" "));
                        prevy = y;
                        y = Convert.ToDouble(aux);
                        if (Math.Sqrt(Math.Pow(x - prevx, 2) + Math.Pow(y - prevy, 2)) >= ml)
                        {
                            if (inserted == 0)
                            {
                                Display.Text = Display.Text.Insert(index, "G1 F" + speed * lm + "\n");
                                inserted = 1;
                                index = index + ("G1 F" + speed * lm + "\n").Length;
                            }
                        }
                        else
                        {
                            Display.Text = Display.Text.Insert(index, "G1 F" + speed + "\n");
                            inserted = 0;
                            index = index + ("G1 F" + speed + "\n").Length;
                        }
                    }
                    index = index + line.Length + 1;
                    if (curlayer > lel)
                        break;
                }
            }

            if (temperatureCheckBox.Checked) // temperature values
            {
                if (tempstartlayer.Text.Length != 0)
                    tsl = Int32.Parse(tempstartlayer.Text);
                if (tempendlayer.Text.Length != 0)
                    tel = Int32.Parse(tempendlayer.Text);
                if (Tempvalue.Text.Length != 0)
                    tv = Int32.Parse(Tempvalue.Text);

                StreamReader sr = new StreamReader(FileName.Text);
                String line;

                int index = 0, inserted = 0, saved = 0;
                string save = "";
                curlayer = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (saved == 0 && line.Contains("M104 S"))
                    {
                        save = line;
                        saved = 1;
                    }

                    if (line.Contains("G1") && line.Contains("Z"))
                    {
                        curlayer++;
                    }

                    if (inserted == 0 && curlayer == tsl)
                    {
                        Display.Text = Display.Text.Insert(index, "M104 S" + tv.ToString() + " ;" + "\n");
                        inserted = 1;
                        index = index + ("M104 S" + tv.ToString() + " ;" + "\n").Length;
                    }

                    if (inserted == 1 && curlayer == tel)
                    {
                        Display.Text = Display.Text.Insert(index, save + "\n");
                        index = index + (save + "\n").Length;
                        inserted = 2;
                    }

                    index = index + line.Length + 1;
                }
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Graphics g = this.Generated.CreateGraphics();
            g.Clear(Form1.ActiveForm.BackColor);
            Pen redPen = new Pen(Color.Red, 2);

            //g.DrawLine(bluePen, ptn1, ptn2);
            int ltv = 0, curlayer = 0;
            if (layertoview.Text.Length != 0)
                ltv = Int32.Parse(layertoview.Text);

            StreamReader sr = new StreamReader(FileName.Text);
            String line, aux = "";

            int index = 0;
            double x = 0, prevx = 0, y = 0, prevy = 0;

            while ((line = sr.ReadLine()) != null)
            {
                if (line.Contains("G1") && line.Contains("Z"))
                {
                    curlayer++;
                }
                
                if (line.Contains("G1") && line.Contains("X") && line.Contains("Y") && curlayer == ltv)
                {
                    aux = line.Substring(line.IndexOf("X") + 1);
                    if (aux.IndexOf(" ") != -1)
                        aux = aux.Remove(aux.IndexOf(" "));
                    prevx = x; 
                    x = Convert.ToDouble(aux);
                    aux = line.Substring(line.IndexOf("Y") + 1);
                    if (aux.IndexOf(" ") != -1)
                        aux = aux.Remove(aux.IndexOf(" "));
                    prevy = y;
                    y = Convert.ToDouble(aux);
                    PointF pt1 = new PointF(Convert.ToSingle(prevx), Convert.ToSingle(prevy));
                    PointF pt2 = new PointF(Convert.ToSingle(x), Convert.ToSingle(y));

                    g.DrawLine(redPen, pt1, pt2);
                    index = index + line.Length + 1;
                }
            }

            redPen.Dispose();
            g.Dispose();
        }

        private void tempendlayer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}