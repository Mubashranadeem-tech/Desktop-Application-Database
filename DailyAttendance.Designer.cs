namespace Database_Project
{
    partial class DailyAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyAttendance));
            logout = new Button();
            imageList1 = new ImageList(components);
            panel2 = new Panel();
            button3 = new Button();
            label12 = new Label();
            sectionwiseresult = new Button();
            lecturereport = new Button();
            imageList3 = new ImageList(components);
            exampanel = new Panel();
            button5 = new Button();
            button2 = new Button();
            markleave = new Button();
            pnlDropdown = new Panel();
            studentsearch = new Button();
            tchrDashboard = new Button();
            imageList2 = new ImageList(components);
            attendance = new Button();
            exams = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            Enter_ID = new TextBox();
            label3 = new Label();
            Enter_CLASS_ID = new TextBox();
            Search = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            exampanel.SuspendLayout();
            pnlDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 0;
            logout.ImageList = imageList1;
            logout.Location = new Point(2013, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 58;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logout icon.png");
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(logout);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(326, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1044, 52);
            panel2.TabIndex = 17;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 0;
            button3.ImageList = imageList1;
            button3.Location = new Point(907, 0);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(137, 52);
            button3.TabIndex = 58;
            button3.Text = "Logout";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(462, 8);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 12;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // sectionwiseresult
            // 
            sectionwiseresult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            sectionwiseresult.ImageAlign = ContentAlignment.MiddleLeft;
            sectionwiseresult.ImageIndex = 1;
            sectionwiseresult.Location = new Point(0, 52);
            sectionwiseresult.Margin = new Padding(3, 2, 3, 2);
            sectionwiseresult.Name = "sectionwiseresult";
            sectionwiseresult.Size = new Size(248, 56);
            sectionwiseresult.TabIndex = 10;
            sectionwiseresult.Text = "Exam Result";
            sectionwiseresult.UseVisualStyleBackColor = true;
            sectionwiseresult.Click += sectionwiseresult_Click;
            // 
            // lecturereport
            // 
            lecturereport.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lecturereport.ImageAlign = ContentAlignment.MiddleLeft;
            lecturereport.ImageIndex = 2;
            lecturereport.ImageList = imageList3;
            lecturereport.Location = new Point(38, 549);
            lecturereport.Margin = new Padding(3, 2, 3, 2);
            lecturereport.Name = "lecturereport";
            lecturereport.Size = new Size(248, 56);
            lecturereport.TabIndex = 8;
            lecturereport.Text = "Lecture Report";
            lecturereport.UseVisualStyleBackColor = true;
            lecturereport.Click += lecturereport_Click;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "student search icon.png");
            imageList3.Images.SetKeyName(1, "exam icon.png");
            imageList3.Images.SetKeyName(2, "Screenshot 2025-04-01 124001.png");
            // 
            // exampanel
            // 
            exampanel.Controls.Add(button5);
            exampanel.Controls.Add(sectionwiseresult);
            exampanel.Location = new Point(332, 450);
            exampanel.Margin = new Padding(3, 2, 3, 2);
            exampanel.MaximumSize = new Size(248, 108);
            exampanel.MinimumSize = new Size(248, 56);
            exampanel.Name = "exampanel";
            exampanel.Size = new Size(248, 108);
            exampanel.TabIndex = 15;
            exampanel.Visible = false;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 1;
            button5.Location = new Point(0, 0);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(248, 56);
            button5.TabIndex = 53;
            button5.Text = "Marks Entry";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 1;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(31, 0, 0, 0);
            button2.Size = new Size(248, 56);
            button2.TabIndex = 11;
            button2.Text = "Daily Attendance";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // markleave
            // 
            markleave.FlatAppearance.BorderSize = 0;
            markleave.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            markleave.ImageAlign = ContentAlignment.MiddleLeft;
            markleave.ImageIndex = 1;
            markleave.Location = new Point(0, 52);
            markleave.Margin = new Padding(3, 2, 3, 2);
            markleave.Name = "markleave";
            markleave.Padding = new Padding(31, 0, 0, 0);
            markleave.Size = new Size(248, 56);
            markleave.TabIndex = 12;
            markleave.Text = "Mark Attendance";
            markleave.UseVisualStyleBackColor = true;
            markleave.Click += markleave_Click;
            // 
            // pnlDropdown
            // 
            pnlDropdown.Controls.Add(markleave);
            pnlDropdown.Controls.Add(button2);
            pnlDropdown.Location = new Point(332, 268);
            pnlDropdown.Margin = new Padding(3, 2, 3, 2);
            pnlDropdown.MaximumSize = new Size(248, 109);
            pnlDropdown.MinimumSize = new Size(248, 56);
            pnlDropdown.Name = "pnlDropdown";
            pnlDropdown.Size = new Size(248, 109);
            pnlDropdown.TabIndex = 16;
            pnlDropdown.Visible = false;
            // 
            // studentsearch
            // 
            studentsearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            studentsearch.ImageAlign = ContentAlignment.MiddleLeft;
            studentsearch.ImageIndex = 0;
            studentsearch.ImageList = imageList3;
            studentsearch.Location = new Point(38, 393);
            studentsearch.Margin = new Padding(3, 2, 3, 2);
            studentsearch.Name = "studentsearch";
            studentsearch.Size = new Size(248, 56);
            studentsearch.TabIndex = 3;
            studentsearch.Text = "Student Search";
            studentsearch.UseVisualStyleBackColor = true;
            studentsearch.Click += studentsearch_Click;
            // 
            // tchrDashboard
            // 
            tchrDashboard.FlatAppearance.BorderSize = 0;
            tchrDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tchrDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            tchrDashboard.ImageIndex = 0;
            tchrDashboard.ImageList = imageList2;
            tchrDashboard.Location = new Point(38, 244);
            tchrDashboard.Margin = new Padding(3, 2, 3, 2);
            tchrDashboard.Name = "tchrDashboard";
            tchrDashboard.Size = new Size(248, 56);
            tchrDashboard.TabIndex = 4;
            tchrDashboard.Text = "Dashboard";
            tchrDashboard.UseVisualStyleBackColor = true;
            tchrDashboard.Click += tchrDashboard_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "dashboard.png");
            imageList2.Images.SetKeyName(1, "exam icon.png");
            imageList2.Images.SetKeyName(2, "Attendance icon in teacher.jpg");
            // 
            // attendance
            // 
            attendance.FlatAppearance.BorderSize = 0;
            attendance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            attendance.ImageAlign = ContentAlignment.MiddleLeft;
            attendance.ImageIndex = 2;
            attendance.ImageList = imageList2;
            attendance.Location = new Point(38, 321);
            attendance.Margin = new Padding(3, 2, 3, 2);
            attendance.MinimumSize = new Size(248, 56);
            attendance.Name = "attendance";
            attendance.Padding = new Padding(9, 0, 0, 0);
            attendance.Size = new Size(248, 56);
            attendance.TabIndex = 11;
            attendance.Text = "   Attendance ▶";
            attendance.UseVisualStyleBackColor = true;
            attendance.Click += attendance_Click;
            // 
            // exams
            // 
            exams.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            exams.ImageAlign = ContentAlignment.MiddleLeft;
            exams.ImageIndex = 1;
            exams.ImageList = imageList3;
            exams.Location = new Point(38, 464);
            exams.Margin = new Padding(3, 2, 3, 2);
            exams.Name = "exams";
            exams.Size = new Size(248, 56);
            exams.TabIndex = 2;
            exams.Text = "Exams ▶";
            exams.UseVisualStyleBackColor = true;
            exams.Click += exams_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pic;
            pictureBox1.Location = new Point(55, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(studentsearch);
            panel1.Controls.Add(lecturereport);
            panel1.Controls.Add(tchrDashboard);
            panel1.Controls.Add(attendance);
            panel1.Controls.Add(exams);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 749);
            panel1.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(Enter_ID);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Enter_CLASS_ID);
            panel3.Controls.Add(Search);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(pnlDropdown);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 749);
            panel3.TabIndex = 18;
            panel3.Paint += panel3_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1085, 138);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(138, 45);
            button1.TabIndex = 52;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Enter_ID
            // 
            Enter_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter_ID.Location = new Point(440, 187);
            Enter_ID.Margin = new Padding(3, 2, 3, 2);
            Enter_ID.Multiline = true;
            Enter_ID.Name = "Enter_ID";
            Enter_ID.PlaceholderText = "Search by Student ID..";
            Enter_ID.Size = new Size(191, 34);
            Enter_ID.TabIndex = 51;
            Enter_ID.TextChanged += Enter_ID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(440, 158);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 50;
            label3.Text = "Enter ID*";
            // 
            // Enter_CLASS_ID
            // 
            Enter_CLASS_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter_CLASS_ID.Location = new Point(656, 184);
            Enter_CLASS_ID.Margin = new Padding(3, 2, 3, 2);
            Enter_CLASS_ID.Multiline = true;
            Enter_CLASS_ID.Name = "Enter_CLASS_ID";
            Enter_CLASS_ID.PlaceholderText = "Search by Class ID..";
            Enter_CLASS_ID.Size = new Size(191, 34);
            Enter_CLASS_ID.TabIndex = 49;
            // 
            // Search
            // 
            Search.BackColor = Color.FromArgb(255, 192, 192);
            Search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(1379, 172);
            Search.Margin = new Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.Size = new Size(138, 45);
            Search.TabIndex = 48;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(388, 232);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(900, 418);
            dataGridView1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(870, 189);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(656, 148);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 4;
            label5.Text = "Select Class*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(852, 148);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Select Date*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(351, 65);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 0;
            label1.Text = "Daily Attendance*";
            // 
            // DailyAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(exampanel);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DailyAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarkAttendance";
            WindowState = FormWindowState.Maximized;
            Load += DailyAttendance_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            exampanel.ResumeLayout(false);
            pnlDropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button logout;
        private ImageList imageList1;
        private Panel panel2;
        private Label label12;
        private Button sectionwiseresult;
        private Button lecturereport;
        private Panel exampanel;
        private Button button2;
        private Button markleave;
        private Panel pnlDropdown;
        private Button studentsearch;
        private Button tchrDashboard;
        private Button attendance;
        private Button exams;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Panel panel3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button5;
        private ImageList imageList3;
        private ImageList imageList2;
        private Button Search;
        private TextBox Enter_CLASS_ID;
        private TextBox Enter_ID;
        private Label label3;
        private Button button1;
    }
}