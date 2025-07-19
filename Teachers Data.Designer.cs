namespace Admin_UI
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            teacherdropdown = new Button();
            StudentDropDown = new Button();
            attendance = new Button();
            button1 = new Button();
            button9 = new Button();
            Studentreport = new Button();
            panel4 = new Panel();
            Search = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            imageList2 = new ImageList(components);
            panel5 = new Panel();
            button2 = new Button();
            button3 = new Button();
            panel3 = new Panel();
            addstudent = new Button();
            studentdetails = new Button();
            panel2 = new Panel();
            logout = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "view.png");
            imageList1.Images.SetKeyName(1, "NB icon.png");
            imageList1.Images.SetKeyName(2, "dropdown icon.png");
            imageList1.Images.SetKeyName(3, "student icon 1.png");
            imageList1.Images.SetKeyName(4, "Dashboard-icon.png");
            imageList1.Images.SetKeyName(5, "training_18097074.png");
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(teacherdropdown);
            panel1.Controls.Add(StudentDropDown);
            panel1.Controls.Add(attendance);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(Studentreport);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 749);
            panel1.TabIndex = 59;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Database_Project.Properties.Resources.pic;
            pictureBox2.Location = new Point(55, 37);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 60;
            pictureBox2.TabStop = false;
            // 
            // teacherdropdown
            // 
            teacherdropdown.BackColor = Color.White;
            teacherdropdown.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            teacherdropdown.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherdropdown.ImageAlign = ContentAlignment.MiddleLeft;
            teacherdropdown.ImageIndex = 5;
            teacherdropdown.ImageList = imageList1;
            teacherdropdown.Location = new Point(38, 559);
            teacherdropdown.Margin = new Padding(3, 2, 3, 2);
            teacherdropdown.Name = "teacherdropdown";
            teacherdropdown.Padding = new Padding(13, 0, 0, 0);
            teacherdropdown.Size = new Size(248, 56);
            teacherdropdown.TabIndex = 44;
            teacherdropdown.Text = "Teachers ▶";
            teacherdropdown.UseVisualStyleBackColor = false;
            teacherdropdown.Click += teacherdropdown_Click;
            // 
            // StudentDropDown
            // 
            StudentDropDown.BackColor = Color.White;
            StudentDropDown.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            StudentDropDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentDropDown.ImageAlign = ContentAlignment.MiddleLeft;
            StudentDropDown.ImageIndex = 3;
            StudentDropDown.ImageList = imageList1;
            StudentDropDown.Location = new Point(38, 368);
            StudentDropDown.Margin = new Padding(3, 2, 3, 2);
            StudentDropDown.Name = "StudentDropDown";
            StudentDropDown.Padding = new Padding(13, 0, 0, 0);
            StudentDropDown.Size = new Size(248, 56);
            StudentDropDown.TabIndex = 39;
            StudentDropDown.Text = "Students ▶";
            StudentDropDown.UseVisualStyleBackColor = false;
            StudentDropDown.Click += StudentDropDown_Click;
            // 
            // attendance
            // 
            attendance.BackColor = Color.White;
            attendance.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            attendance.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendance.ImageAlign = ContentAlignment.MiddleLeft;
            attendance.ImageIndex = 0;
            attendance.ImageList = imageList1;
            attendance.Location = new Point(38, 495);
            attendance.Margin = new Padding(3, 2, 3, 2);
            attendance.Name = "attendance";
            attendance.Padding = new Padding(13, 0, 0, 0);
            attendance.Size = new Size(248, 56);
            attendance.TabIndex = 40;
            attendance.Text = "  Attendence";
            attendance.UseVisualStyleBackColor = false;
            attendance.Click += attendance_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 4;
            button1.ImageList = imageList1;
            button1.Location = new Point(38, 240);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(13, 0, 0, 0);
            button1.Size = new Size(248, 56);
            button1.TabIndex = 37;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.ImageIndex = 1;
            button9.ImageList = imageList1;
            button9.Location = new Point(38, 304);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Padding = new Padding(13, 0, 0, 0);
            button9.Size = new Size(248, 56);
            button9.TabIndex = 49;
            button9.Text = " Notice Board";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click_1;
            // 
            // Studentreport
            // 
            Studentreport.BackColor = Color.White;
            Studentreport.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            Studentreport.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Studentreport.ImageAlign = ContentAlignment.MiddleLeft;
            Studentreport.ImageIndex = 0;
            Studentreport.ImageList = imageList1;
            Studentreport.Location = new Point(38, 431);
            Studentreport.Margin = new Padding(3, 2, 3, 2);
            Studentreport.Name = "Studentreport";
            Studentreport.Padding = new Padding(13, 0, 0, 0);
            Studentreport.Size = new Size(248, 56);
            Studentreport.TabIndex = 38;
            Studentreport.Text = "Student Report";
            Studentreport.UseVisualStyleBackColor = false;
            Studentreport.Click += Studentreport_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(Search);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(386, 71);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1208, 602);
            panel4.TabIndex = 60;
            panel4.Paint += panel4_Paint;
            // 
            // Search
            // 
            Search.BackColor = Color.Turquoise;
            Search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(543, 63);
            Search.Margin = new Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.Size = new Size(149, 45);
            Search.TabIndex = 41;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += button14_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(383, 76);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search by Class";
            textBox2.Size = new Size(154, 32);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(29, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Name";
            textBox1.Size = new Size(168, 32);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F);
            textBox5.Location = new Point(212, 76);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Search by ID";
            textBox5.Size = new Size(165, 32);
            textBox5.TabIndex = 2;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(277, 45);
            label1.TabIndex = 0;
            label1.Text = "All Teachers Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 137);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(759, 465);
            dataGridView1.TabIndex = 42;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "logout icon.png");
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Location = new Point(315, 548);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.MaximumSize = new Size(204, 81);
            panel5.MinimumSize = new Size(204, 37);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(13, 0, 0, 0);
            panel5.Size = new Size(204, 81);
            panel5.TabIndex = 63;
            panel5.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 43);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(204, 37);
            button2.TabIndex = 7;
            button2.Text = "Add Teacher";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 2);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(204, 37);
            button3.TabIndex = 10;
            button3.Text = "Teacher details";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(addstudent);
            panel3.Controls.Add(studentdetails);
            panel3.Location = new Point(315, 352);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.MaximumSize = new Size(204, 81);
            panel3.MinimumSize = new Size(204, 37);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(13, 0, 0, 0);
            panel3.Size = new Size(204, 81);
            panel3.TabIndex = 62;
            panel3.Visible = false;
            // 
            // addstudent
            // 
            addstudent.BackColor = Color.White;
            addstudent.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            addstudent.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addstudent.Location = new Point(0, 43);
            addstudent.Margin = new Padding(3, 2, 3, 2);
            addstudent.Name = "addstudent";
            addstudent.Size = new Size(204, 37);
            addstudent.TabIndex = 7;
            addstudent.Text = "Add Student";
            addstudent.UseVisualStyleBackColor = false;
            addstudent.Click += addstudent_Click_1;
            // 
            // studentdetails
            // 
            studentdetails.BackColor = Color.White;
            studentdetails.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            studentdetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentdetails.Location = new Point(0, 2);
            studentdetails.Margin = new Padding(3, 2, 3, 2);
            studentdetails.Name = "studentdetails";
            studentdetails.Size = new Size(204, 37);
            studentdetails.TabIndex = 10;
            studentdetails.Text = "Student details";
            studentdetails.UseVisualStyleBackColor = false;
            studentdetails.Click += studentdetails_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(logout);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(310, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1060, 52);
            panel2.TabIndex = 64;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 0;
            logout.ImageList = imageList2;
            logout.Location = new Point(922, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 65;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(556, 7);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 43;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Panel panel1;
        private Button teacherdropdown;
        private Button StudentDropDown;
        private Button attendance;
        private Button button1;
        private Button button9;
        private Button Studentreport;
        private Panel panel4;
        private Button Search;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label1;
        private DataGridView dataGridView1;
        private ImageList imageList2;
        private Panel panel5;
        private Button button2;
        private Button button3;
        private Panel panel3;
        private Button addstudent;
        private Button studentdetails;
        private PictureBox pictureBox2;
        private Label label12;
        private Panel panel2;
        private Button logout;
    }
}