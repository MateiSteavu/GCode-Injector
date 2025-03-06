namespace Gcode_Injector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OPFL = new Button();
            Layertoinsert = new TextBox();
            Display = new RichTextBox();
            FileName = new TextBox();
            dialSave = new SaveFileDialog();
            Savebutton = new Button();
            Whattoinsert = new RichTextBox();
            layersaumm = new ComboBox();
            ResumePrint = new CheckBox();
            numbertoresume = new TextBox();
            Speedbox = new CheckBox();
            startlayer = new TextBox();
            Continue = new Label();
            endlayer = new TextBox();
            continue1 = new Label();
            speedmultiply = new TextBox();
            LineSpeedCheck = new CheckBox();
            MinLenght = new TextBox();
            Continue2 = new Label();
            linestartlayer = new TextBox();
            continue3 = new Label();
            lineendlayer = new TextBox();
            continue4 = new Label();
            linemultiply = new TextBox();
            ModifyButton = new Button();
            Continue5 = new Label();
            layertoview = new TextBox();
            Generated = new PictureBox();
            Generate = new Button();
            temperatureCheckBox = new CheckBox();
            tempstartlayer = new TextBox();
            continue6 = new Label();
            tempendlayer = new TextBox();
            Insert = new CheckBox();
            continue7 = new Label();
            Tempvalue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Generated).BeginInit();
            SuspendLayout();
            // 
            // OPFL
            // 
            OPFL.BackColor = Color.DarkTurquoise;
            OPFL.FlatStyle = FlatStyle.Flat;
            OPFL.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OPFL.Location = new Point(22, 912);
            OPFL.Name = "OPFL";
            OPFL.Size = new Size(94, 29);
            OPFL.TabIndex = 0;
            OPFL.Text = "Open File";
            OPFL.UseVisualStyleBackColor = false;
            OPFL.Click += OPFL_Click;
            // 
            // Layertoinsert
            // 
            Layertoinsert.BackColor = Color.FromArgb(57, 48, 77);
            Layertoinsert.BorderStyle = BorderStyle.None;
            Layertoinsert.ForeColor = SystemColors.HighlightText;
            Layertoinsert.Location = new Point(1255, 118);
            Layertoinsert.Name = "Layertoinsert";
            Layertoinsert.Size = new Size(125, 20);
            Layertoinsert.TabIndex = 1;
            // 
            // Display
            // 
            Display.BackColor = Color.FromArgb(57, 48, 77);
            Display.BorderStyle = BorderStyle.None;
            Display.ForeColor = Color.White;
            Display.Location = new Point(22, 21);
            Display.Name = "Display";
            Display.Size = new Size(636, 828);
            Display.TabIndex = 3;
            Display.Text = "";
            // 
            // FileName
            // 
            FileName.BackColor = Color.FromArgb(57, 48, 77);
            FileName.BorderStyle = BorderStyle.None;
            FileName.ForeColor = Color.White;
            FileName.Location = new Point(22, 868);
            FileName.Name = "FileName";
            FileName.Size = new Size(636, 20);
            FileName.TabIndex = 4;
            // 
            // dialSave
            // 
            dialSave.Filter = "GCode files (*.gcode)|*.gcode";
            // 
            // Savebutton
            // 
            Savebutton.BackColor = Color.DarkTurquoise;
            Savebutton.FlatStyle = FlatStyle.Flat;
            Savebutton.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Savebutton.Location = new Point(564, 912);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(94, 29);
            Savebutton.TabIndex = 5;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Whattoinsert
            // 
            Whattoinsert.BackColor = Color.FromArgb(57, 48, 77);
            Whattoinsert.BorderStyle = BorderStyle.None;
            Whattoinsert.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Whattoinsert.ForeColor = SystemColors.HighlightText;
            Whattoinsert.Location = new Point(704, 21);
            Whattoinsert.Name = "Whattoinsert";
            Whattoinsert.Size = new Size(482, 154);
            Whattoinsert.TabIndex = 6;
            Whattoinsert.Text = "Please put the Gcode you want to insert here:";
            // 
            // layersaumm
            // 
            layersaumm.AutoCompleteCustomSource.AddRange(new string[] { "Layer", "mm" });
            layersaumm.BackColor = Color.FromArgb(57, 48, 77);
            layersaumm.DisplayMember = "1";
            layersaumm.FlatStyle = FlatStyle.Flat;
            layersaumm.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            layersaumm.ForeColor = SystemColors.HighlightText;
            layersaumm.FormattingEnabled = true;
            layersaumm.Items.AddRange(new object[] { "Layer", "mm" });
            layersaumm.Location = new Point(1032, 183);
            layersaumm.Name = "layersaumm";
            layersaumm.Size = new Size(151, 28);
            layersaumm.TabIndex = 2;
            layersaumm.Text = "Layer";
            // 
            // ResumePrint
            // 
            ResumePrint.AutoSize = true;
            ResumePrint.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ResumePrint.ForeColor = Color.White;
            ResumePrint.Location = new Point(704, 181);
            ResumePrint.Name = "ResumePrint";
            ResumePrint.Size = new Size(191, 24);
            ResumePrint.TabIndex = 8;
            ResumePrint.Text = "Resume print at:";
            ResumePrint.UseVisualStyleBackColor = true;
            // 
            // numbertoresume
            // 
            numbertoresume.BackColor = Color.FromArgb(57, 48, 77);
            numbertoresume.BorderStyle = BorderStyle.None;
            numbertoresume.ForeColor = SystemColors.HighlightText;
            numbertoresume.Location = new Point(901, 185);
            numbertoresume.Name = "numbertoresume";
            numbertoresume.Size = new Size(125, 20);
            numbertoresume.TabIndex = 9;
            // 
            // Speedbox
            // 
            Speedbox.AutoSize = true;
            Speedbox.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Speedbox.ForeColor = Color.White;
            Speedbox.Location = new Point(704, 211);
            Speedbox.Name = "Speedbox";
            Speedbox.Size = new Size(501, 24);
            Speedbox.TabIndex = 10;
            Speedbox.Text = "Multiply the speed of layers ranging from layer";
            Speedbox.UseVisualStyleBackColor = true;
            // 
            // startlayer
            // 
            startlayer.BackColor = Color.FromArgb(57, 48, 77);
            startlayer.BorderStyle = BorderStyle.None;
            startlayer.ForeColor = SystemColors.HighlightText;
            startlayer.Location = new Point(1211, 211);
            startlayer.Name = "startlayer";
            startlayer.Size = new Size(125, 20);
            startlayer.TabIndex = 11;
            // 
            // Continue
            // 
            Continue.AutoSize = true;
            Continue.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Continue.ForeColor = Color.White;
            Continue.Location = new Point(1342, 211);
            Continue.Name = "Continue";
            Continue.Size = new Size(109, 20);
            Continue.TabIndex = 12;
            Continue.Text = "till layer";
            // 
            // endlayer
            // 
            endlayer.BackColor = Color.FromArgb(57, 48, 77);
            endlayer.BorderStyle = BorderStyle.None;
            endlayer.ForeColor = SystemColors.HighlightText;
            endlayer.Location = new Point(726, 239);
            endlayer.Name = "endlayer";
            endlayer.Size = new Size(125, 20);
            endlayer.TabIndex = 13;
            // 
            // continue1
            // 
            continue1.AutoSize = true;
            continue1.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            continue1.ForeColor = Color.White;
            continue1.Location = new Point(857, 239);
            continue1.Name = "continue1";
            continue1.Size = new Size(29, 20);
            continue1.TabIndex = 14;
            continue1.Text = "by";
            // 
            // speedmultiply
            // 
            speedmultiply.BackColor = Color.FromArgb(57, 48, 77);
            speedmultiply.BorderStyle = BorderStyle.None;
            speedmultiply.ForeColor = SystemColors.HighlightText;
            speedmultiply.Location = new Point(892, 239);
            speedmultiply.Name = "speedmultiply";
            speedmultiply.Size = new Size(125, 20);
            speedmultiply.TabIndex = 15;
            // 
            // LineSpeedCheck
            // 
            LineSpeedCheck.AutoSize = true;
            LineSpeedCheck.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LineSpeedCheck.ForeColor = Color.White;
            LineSpeedCheck.Location = new Point(704, 268);
            LineSpeedCheck.Name = "LineSpeedCheck";
            LineSpeedCheck.Size = new Size(521, 24);
            LineSpeedCheck.TabIndex = 16;
            LineSpeedCheck.Text = "Multiply the speed of straight lines longer than ";
            LineSpeedCheck.UseVisualStyleBackColor = true;
            // 
            // MinLenght
            // 
            MinLenght.BackColor = Color.FromArgb(57, 48, 77);
            MinLenght.BorderStyle = BorderStyle.None;
            MinLenght.ForeColor = SystemColors.HighlightText;
            MinLenght.Location = new Point(1211, 265);
            MinLenght.Name = "MinLenght";
            MinLenght.Size = new Size(125, 20);
            MinLenght.TabIndex = 17;
            // 
            // Continue2
            // 
            Continue2.AutoSize = true;
            Continue2.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Continue2.ForeColor = Color.White;
            Continue2.Location = new Point(726, 299);
            Continue2.Name = "Continue2";
            Continue2.Size = new Size(179, 20);
            Continue2.TabIndex = 18;
            Continue2.Text = "mm from the layer";
            // 
            // linestartlayer
            // 
            linestartlayer.BackColor = Color.FromArgb(57, 48, 77);
            linestartlayer.BorderStyle = BorderStyle.None;
            linestartlayer.ForeColor = SystemColors.HighlightText;
            linestartlayer.Location = new Point(911, 299);
            linestartlayer.Name = "linestartlayer";
            linestartlayer.Size = new Size(105, 20);
            linestartlayer.TabIndex = 19;
            // 
            // continue3
            // 
            continue3.AutoSize = true;
            continue3.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            continue3.ForeColor = Color.White;
            continue3.Location = new Point(1022, 299);
            continue3.Name = "continue3";
            continue3.Size = new Size(109, 20);
            continue3.TabIndex = 20;
            continue3.Text = "till layer";
            // 
            // lineendlayer
            // 
            lineendlayer.BackColor = Color.FromArgb(57, 48, 77);
            lineendlayer.BorderStyle = BorderStyle.None;
            lineendlayer.ForeColor = SystemColors.HighlightText;
            lineendlayer.Location = new Point(1137, 298);
            lineendlayer.Name = "lineendlayer";
            lineendlayer.Size = new Size(125, 20);
            lineendlayer.TabIndex = 21;
            // 
            // continue4
            // 
            continue4.AutoSize = true;
            continue4.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            continue4.ForeColor = Color.White;
            continue4.Location = new Point(1268, 299);
            continue4.Name = "continue4";
            continue4.Size = new Size(29, 20);
            continue4.TabIndex = 22;
            continue4.Text = "by";
            // 
            // linemultiply
            // 
            linemultiply.BackColor = Color.FromArgb(57, 48, 77);
            linemultiply.BorderStyle = BorderStyle.None;
            linemultiply.ForeColor = SystemColors.HighlightText;
            linemultiply.Location = new Point(1303, 298);
            linemultiply.Name = "linemultiply";
            linemultiply.Size = new Size(125, 20);
            linemultiply.TabIndex = 23;
            // 
            // ModifyButton
            // 
            ModifyButton.BackColor = Color.DarkTurquoise;
            ModifyButton.FlatStyle = FlatStyle.Flat;
            ModifyButton.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyButton.Location = new Point(704, 399);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(94, 29);
            ModifyButton.TabIndex = 24;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = false;
            ModifyButton.Click += ModifyButton_Click;
            // 
            // Continue5
            // 
            Continue5.AutoSize = true;
            Continue5.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Continue5.ForeColor = Color.White;
            Continue5.Location = new Point(704, 435);
            Continue5.Name = "Continue5";
            Continue5.Size = new Size(109, 20);
            Continue5.TabIndex = 25;
            Continue5.Text = "View Layer";
            // 
            // layertoview
            // 
            layertoview.BackColor = Color.FromArgb(57, 48, 77);
            layertoview.BorderStyle = BorderStyle.None;
            layertoview.ForeColor = SystemColors.HighlightText;
            layertoview.Location = new Point(819, 435);
            layertoview.Name = "layertoview";
            layertoview.Size = new Size(125, 20);
            layertoview.TabIndex = 26;
            // 
            // Generated
            // 
            Generated.Location = new Point(704, 475);
            Generated.Name = "Generated";
            Generated.Size = new Size(711, 450);
            Generated.TabIndex = 27;
            Generated.TabStop = false;
            // 
            // Generate
            // 
            Generate.BackColor = Color.DarkTurquoise;
            Generate.FlatStyle = FlatStyle.Flat;
            Generate.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Generate.Location = new Point(962, 431);
            Generate.Name = "Generate";
            Generate.Size = new Size(181, 29);
            Generate.TabIndex = 28;
            Generate.Text = "Generate Image";
            Generate.UseVisualStyleBackColor = false;
            Generate.Click += Generate_Click;
            // 
            // temperatureCheckBox
            // 
            temperatureCheckBox.AutoSize = true;
            temperatureCheckBox.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            temperatureCheckBox.ForeColor = Color.White;
            temperatureCheckBox.Location = new Point(704, 332);
            temperatureCheckBox.Name = "temperatureCheckBox";
            temperatureCheckBox.Size = new Size(351, 24);
            temperatureCheckBox.TabIndex = 29;
            temperatureCheckBox.Text = "Change temperature between layer";
            temperatureCheckBox.UseVisualStyleBackColor = true;
            // 
            // tempstartlayer
            // 
            tempstartlayer.BackColor = Color.FromArgb(57, 48, 77);
            tempstartlayer.BorderStyle = BorderStyle.None;
            tempstartlayer.ForeColor = SystemColors.HighlightText;
            tempstartlayer.Location = new Point(1061, 333);
            tempstartlayer.Name = "tempstartlayer";
            tempstartlayer.Size = new Size(125, 20);
            tempstartlayer.TabIndex = 30;
            // 
            // continue6
            // 
            continue6.AutoSize = true;
            continue6.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            continue6.ForeColor = Color.White;
            continue6.Location = new Point(1192, 333);
            continue6.Name = "continue6";
            continue6.Size = new Size(109, 20);
            continue6.TabIndex = 31;
            continue6.Text = "till layer";
            // 
            // tempendlayer
            // 
            tempendlayer.BackColor = Color.FromArgb(57, 48, 77);
            tempendlayer.BorderStyle = BorderStyle.None;
            tempendlayer.ForeColor = SystemColors.HighlightText;
            tempendlayer.Location = new Point(1307, 333);
            tempendlayer.Name = "tempendlayer";
            tempendlayer.Size = new Size(125, 20);
            tempendlayer.TabIndex = 32;
            tempendlayer.TextChanged += tempendlayer_TextChanged;
            // 
            // Insert
            // 
            Insert.AutoSize = true;
            Insert.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Insert.ForeColor = Color.White;
            Insert.Location = new Point(1211, 88);
            Insert.Name = "Insert";
            Insert.Size = new Size(231, 24);
            Insert.TabIndex = 33;
            Insert.Text = "Insert before Layer:";
            Insert.UseVisualStyleBackColor = true;
            // 
            // continue7
            // 
            continue7.AutoSize = true;
            continue7.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            continue7.ForeColor = Color.White;
            continue7.Location = new Point(726, 366);
            continue7.Name = "continue7";
            continue7.Size = new Size(29, 20);
            continue7.TabIndex = 34;
            continue7.Text = "to";
            // 
            // Tempvalue
            // 
            Tempvalue.BackColor = Color.FromArgb(57, 48, 77);
            Tempvalue.BorderStyle = BorderStyle.None;
            Tempvalue.ForeColor = SystemColors.HighlightText;
            Tempvalue.Location = new Point(761, 366);
            Tempvalue.Name = "Tempvalue";
            Tempvalue.Size = new Size(112, 20);
            Tempvalue.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 26, 48);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1482, 953);
            Controls.Add(Tempvalue);
            Controls.Add(continue7);
            Controls.Add(Insert);
            Controls.Add(tempendlayer);
            Controls.Add(continue6);
            Controls.Add(tempstartlayer);
            Controls.Add(temperatureCheckBox);
            Controls.Add(Generate);
            Controls.Add(Generated);
            Controls.Add(layertoview);
            Controls.Add(Continue5);
            Controls.Add(ModifyButton);
            Controls.Add(linemultiply);
            Controls.Add(continue4);
            Controls.Add(lineendlayer);
            Controls.Add(continue3);
            Controls.Add(linestartlayer);
            Controls.Add(Continue2);
            Controls.Add(MinLenght);
            Controls.Add(LineSpeedCheck);
            Controls.Add(speedmultiply);
            Controls.Add(continue1);
            Controls.Add(endlayer);
            Controls.Add(Continue);
            Controls.Add(startlayer);
            Controls.Add(Speedbox);
            Controls.Add(numbertoresume);
            Controls.Add(ResumePrint);
            Controls.Add(Whattoinsert);
            Controls.Add(Savebutton);
            Controls.Add(FileName);
            Controls.Add(Display);
            Controls.Add(layersaumm);
            Controls.Add(Layertoinsert);
            Controls.Add(OPFL);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GCode Injector";
            ((System.ComponentModel.ISupportInitialize)Generated).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OPFL;
        private TextBox Layertoinsert;
        private RichTextBox Display;
        private TextBox FileName;
        private SaveFileDialog dialSave;
        private Button Savebutton;
        private RichTextBox Whattoinsert;
        private ComboBox layersaumm;
        private CheckBox ResumePrint;
        private TextBox numbertoresume;
        private CheckBox Speedbox;
        private TextBox startlayer;
        private Label Continue;
        private TextBox endlayer;
        private Label continue1;
        private TextBox speedmultiply;
        private CheckBox LineSpeedCheck;
        private TextBox MinLenght;
        private Label Continue2;
        private TextBox linestartlayer;
        private Label continue3;
        private TextBox lineendlayer;
        private Label continue4;
        private TextBox linemultiply;
        private Button ModifyButton;
        private Label Continue5;
        private TextBox layertoview;
        private PictureBox Generated;
        private Button Generate;
        private CheckBox temperatureCheckBox;
        private TextBox tempstartlayer;
        private Label continue6;
        private TextBox tempendlayer;
        private CheckBox Insert;
        private Label continue7;
        private TextBox Tempvalue;
    }
}