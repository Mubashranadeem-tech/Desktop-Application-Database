namespace Admin_UI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            imageList1 = new ImageList(components);
            panel4 = new Panel();
            Search = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            addteacher = new Button();
            teachersetails = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            teacherdropdown = new Button();
            StudentDropDown = new Button();
            attendance = new Button();
            dashboard = new Button();
            noticeboard = new Button();
            Studentreport = new Button();
            panel2 = new Panel();
            addstudent = new Button();
            studentdetails = new Button();
            panel3 = new Panel();
            logout = new Button();
            imageList2 = new ImageList(components);
            label12 = new Label();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            // panel4
            // 
            panel4.Controls.Add(Search);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(362, 88);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1186, 586);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // Search
            // 
            Search.BackColor = Color.Turquoise;
            Search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(588, 59);
            Search.Margin = new Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.Size = new Size(149, 45);
            Search.TabIndex = 41;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(410, 72);
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
            textBox1.Location = new Point(48, 72);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Name";
            textBox1.Size = new Size(168, 32);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F);
            textBox5.Location = new Point(232, 72);
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
            label1.Size = new Size(279, 45);
            label1.TabIndex = 0;
            label1.Text = "All Students Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 125);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(851, 311);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(addteacher);
            panel5.Controls.Add(teachersetails);
            panel5.Location = new Point(315, 545);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.MaximumSize = new Size(204, 81);
            panel5.MinimumSize = new Size(204, 37);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(13, 0, 0, 0);
            panel5.Size = new Size(204, 81);
            panel5.TabIndex = 61;
            panel5.Visible = false;
            // 
            // addteacher
            // 
            addteacher.BackColor = Color.White;
            addteacher.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            addteacher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addteacher.Location = new Point(0, 43);
            addteacher.Margin = new Padding(3, 2, 3, 2);
            addteacher.Name = "addteacher";
            addteacher.Size = new Size(204, 37);
            addteacher.TabIndex = 7;
            addteacher.Text = "Add Teacher";
            addteacher.UseVisualStyleBackColor = false;
            addteacher.Click += addteacher_Click;
            // 
            // teachersetails
            // 
            teachersetails.BackColor = Color.White;
            teachersetails.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            teachersetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teachersetails.Location = new Point(0, 2);
            teachersetails.Margin = new Padding(3, 2, 3, 2);
            teachersetails.Name = "teachersetails";
            teachersetails.Size = new Size(204, 37);
            teachersetails.TabIndex = 10;
            teachersetails.Text = "Teacher details";
            teachersetails.UseVisualStyleBackColor = false;
            teachersetails.Click += teachersetails_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(teacherdropdown);
            panel1.Controls.Add(StudentDropDown);
            panel1.Controls.Add(attendance);
            panel1.Controls.Add(dashboard);
            panel1.Controls.Add(noticeboard);
            panel1.Controls.Add(Studentreport);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 749);
            panel1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Database_Project.Properties.Resources.Profile_icon;
            pictureBox1.Location = new Point(55, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
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
            // dashboard
            // 
            dashboard.BackColor = Color.White;
            dashboard.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            dashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.ImageIndex = 4;
            dashboard.ImageList = imageList1;
            dashboard.Location = new Point(38, 240);
            dashboard.Margin = new Padding(3, 2, 3, 2);
            dashboard.Name = "dashboard";
            dashboard.Padding = new Padding(13, 0, 0, 0);
            dashboard.Size = new Size(248, 56);
            dashboard.TabIndex = 37;
            dashboard.Text = "Dashboard";
            dashboard.UseVisualStyleBackColor = false;
            dashboard.Click += button1_Click;
            // 
            // noticeboard
            // 
            noticeboard.BackColor = Color.White;
            noticeboard.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            noticeboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noticeboard.ImageAlign = ContentAlignment.MiddleLeft;
            noticeboard.ImageIndex = 1;
            noticeboard.ImageList = imageList1;
            noticeboard.Location = new Point(38, 304);
            noticeboard.Margin = new Padding(3, 2, 3, 2);
            noticeboard.Name = "noticeboard";
            noticeboard.Padding = new Padding(13, 0, 0, 0);
            noticeboard.Size = new Size(248, 56);
            noticeboard.TabIndex = 49;
            noticeboard.Text = " Notice Board";
            noticeboard.UseVisualStyleBackColor = false;
            noticeboard.Click += noticeboard_Click;
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
            // panel2
            // 
            panel2.Controls.Add(addstudent);
            panel2.Controls.Add(studentdetails);
            panel2.Location = new Point(315, 350);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.MaximumSize = new Size(204, 81);
            panel2.MinimumSize = new Size(204, 37);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(13, 0, 0, 0);
            panel2.Size = new Size(204, 81);
            panel2.TabIndex = 59;
            panel2.Visible = false;
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
            addstudent.Click += addstudent_Click;
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
            studentdetails.Click += studentdetails_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(logout);
            panel3.Controls.Add(label12);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(310, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1060, 52);
            panel3.TabIndex = 62;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 0;
            logout.ImageList = imageList2;
            logout.Location = new Point(950, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 57;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "logout icon.png");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(462, 8);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 3;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Button Search;
        private DataGridView dataGridView1;
        private ImageList imageList1;
        private Panel panel5;
        private Button addteacher;
        private Button teachersetails;
        private Panel panel1;
        private Button teacherdropdown;
        private Button StudentDropDown;
        private Button attendance;
        private Button dashboard;
        private Button noticeboard;
        private Button Studentreport;
        private Panel panel2;
        private Button addstudent;
        private Button studentdetails;
        private Panel panel3;
        private Label label12;
        private Button logout;
        private ImageList imageList2;
        private PictureBox pictureBox1;
    }
}