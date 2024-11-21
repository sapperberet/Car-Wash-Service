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
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            button4 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            button3 = new Button();
            textBox5 = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            elipseControl1 = new ElipseToolDemo.ElipseControl();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(36, 85, 70);
            button1.Image = Properties.Resources.Actions_document_save_icon;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(1092, 0);
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
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(36, 85, 70);
            button2.Image = Properties.Resources.Actions_document_print_icon__1_;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(912, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(141, 61);
            button2.TabIndex = 2;
            button2.Text = "طباعة الريسيت";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(222, 222, 222);
            textBox1.Location = new Point(50, 86);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "إسم العميل";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(257, 32);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(222, 222, 222);
            textBox2.Location = new Point(50, 154);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "رقم التيلفون";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(257, 32);
            textBox2.TabIndex = 9;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(222, 222, 222);
            textBox3.Location = new Point(50, 222);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "رقم السيارة";
            textBox3.RightToLeft = RightToLeft.Yes;
            textBox3.Size = new Size(257, 32);
            textBox3.TabIndex = 10;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(41, 95, 78);
            label4.Font = new Font("MV Boli", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(132, 405);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 13;
            label4.Text = "الملاحظات";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(222, 222, 222);
            textBox4.Location = new Point(50, 437);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "لا يوجد";
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.ScrollBars = ScrollBars.Both;
            textBox4.Size = new Size(257, 96);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 607);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 68);
            panel2.TabIndex = 6;
            panel2.MouseDown += MD;
            panel2.MouseMove += MME;
            panel2.MouseUp += MU;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(222, 222, 222);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            comboBox1.Location = new Point(50, 364);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.Yes;
            comboBox1.Size = new Size(257, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(41, 95, 78);
            label5.Font = new Font("MV Boli", 13F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(132, 332);
            label5.Name = "label5";
            label5.Size = new Size(91, 29);
            label5.TabIndex = 15;
            label5.Text = "نوع الخدمة";
            label5.Click += label5_Click;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.BackColor = Color.FromArgb(222, 222, 222);
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "لا يوجد\t", "30% عرض الإفتتاح", "50% النص " });
            comboBox3.Location = new Point(186, 289);
            comboBox3.Name = "comboBox3";
            comboBox3.RightToLeft = RightToLeft.Yes;
            comboBox3.Size = new Size(121, 28);
            comboBox3.TabIndex = 20;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(41, 95, 78);
            label7.Font = new Font("MV Boli", 13F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(204, 257);
            label7.Name = "label7";
            label7.Size = new Size(93, 29);
            label7.TabIndex = 19;
            label7.Text = "الخصومات";
            label7.Click += label7_Click;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.BackColor = Color.FromArgb(222, 222, 222);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "لا يوجد\t", "30% عرض الإفتتاح", "50% النص " });
            comboBox2.Location = new Point(50, 289);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.Yes;
            comboBox2.Size = new Size(121, 28);
            comboBox2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(41, 95, 78);
            label6.Font = new Font("MV Boli", 13F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(65, 257);
            label6.Name = "label6";
            label6.Size = new Size(91, 29);
            label6.TabIndex = 24;
            label6.Text = "نوع الخدمة";
            label6.Click += label6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.Actions_dialog_close_icon;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(1203, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(59, 55);
            button4.TabIndex = 3;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 55);
            panel1.TabIndex = 7;
            panel1.MouseDown += MD;
            panel1.MouseMove += MME;
            panel1.MouseUp += MU;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.Image = Properties.Resources.Actions_list_remove_icon;
            button5.Location = new Point(1140, 7);
            button5.Name = "button5";
            button5.Size = new Size(60, 40);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(169, 191, 184);
            button3.FlatAppearance.BorderColor = Color.FromArgb(83, 126, 113);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(83, 126, 113);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 126, 113);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("MV Boli", 16F);
            button3.ForeColor = Color.FromArgb(41, 85, 95);
            button3.Location = new Point(113, 549);
            button3.Name = "button3";
            button3.Size = new Size(125, 44);
            button3.TabIndex = 4;
            button3.Text = "اضافة";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(222, 222, 222);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("MV Boli", 20F);
            textBox5.Location = new Point(497, 70);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "البحث";
            textBox5.RightToLeft = RightToLeft.Yes;
            textBox5.Size = new Size(588, 48);
            textBox5.TabIndex = 26;
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(222, 222, 222);
            pictureBox1.ErrorImage = Properties.Resources.Actions_page_zoom_icon2;
            pictureBox1.Image = Properties.Resources.Actions_page_zoom_icon;
            pictureBox1.InitialImage = Properties.Resources.Actions_page_zoom_icon1;
            pictureBox1.Location = new Point(1037, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 469);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // elipseControl1
            // 
            elipseControl1.BackColor = Color.FromArgb(41, 95, 78);
            elipseControl1.CornerRadius = 40;
            elipseControl1.Location = new Point(0, 43);
            elipseControl1.Name = "elipseControl1";
            elipseControl1.Size = new Size(1267, 758);
            elipseControl1.TabIndex = 1;
            elipseControl1.TargetControl = this;
            elipseControl1.Text = "elipseControl1";
            elipseControl1.Click += elipseControl1_Click;
            elipseControl1.MouseDown += MD;
            elipseControl1.MouseMove += MME;
            elipseControl1.MouseUp += MU;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1262, 673);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        
            
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox3;
        private Label label7;
        private ComboBox comboBox2;
        private Label label6;
        private Button button4;
        private Panel panel1;
        private PageSetupDialog pageSetupDialog1;
        private Button button3;
        private TextBox textBox5;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button5;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }

}

