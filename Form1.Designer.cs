namespace Car_Wash_Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            button2 = new Button();
            elipseControl2 = new ElipseToolDemo.ElipseControl();
            elipseControl3 = new ElipseToolDemo.ElipseControl();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(82, 78, 238);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.Actions_document_save_icon;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(1069, 578);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(141, 61);
            button1.TabIndex = 0;
            button1.Text = "حفظ الملف";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseDown += MD;
            button1.MouseUp += MU;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // elipseControl1
            // 
            elipseControl1.CornerRadius = 40;
            elipseControl1.Location = new Point(0, 0);
            elipseControl1.Name = "elipseControl1";
            elipseControl1.Size = new Size(1261, 672);
            elipseControl1.TabIndex = 1;
            elipseControl1.TargetControl = this;
            elipseControl1.Text = "elipseControl1";
            elipseControl1.Click += elipseControl1_Click;
            elipseControl1.MouseDown += MD;
            elipseControl1.MouseMove += MME;
            elipseControl1.MouseUp += MU;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(82, 78, 238);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.Actions_document_print_icon__1_;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(904, 578);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(146, 61);
            button2.TabIndex = 2;
            button2.Text = "طباعة الريسيت";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // elipseControl2
            // 
            elipseControl2.CornerRadius = 40;
            elipseControl2.Location = new Point(1069, 578);
            elipseControl2.Name = "elipseControl2";
            elipseControl2.Size = new Size(111, 61);
            elipseControl2.TabIndex = 3;
            elipseControl2.TargetControl = button1;
            elipseControl2.Text = "elipseControl2";
            // 
            // elipseControl3
            // 
            elipseControl3.CornerRadius = 30;
            elipseControl3.Location = new Point(8, 8);
            elipseControl3.Name = "elipseControl3";
            elipseControl3.Size = new Size(94, 29);
            elipseControl3.TabIndex = 4;
            elipseControl3.TargetControl = button2;
            elipseControl3.Text = "elipseControl3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1262, 673);
            Controls.Add(button1);
            Controls.Add(elipseControl3);
            Controls.Add(elipseControl2);
            Controls.Add(button2);
            Controls.Add(elipseControl1);
            Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ON ROAD (Car Care)";
            WindowState = FormWindowState.Minimized;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        
            
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Button button2;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private ElipseToolDemo.ElipseControl elipseControl3;
    }

}

