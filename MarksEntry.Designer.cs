namespace Database_Project
{
    partial class MarksEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksEntry));
            logout = new Button();
            imageList1 = new ImageList(components);
            panel2 = new Panel();
            button3 = new Button();
            label12 = new Label();
            sectionwiseresult = new Button();
            lecturereport = new Button();
            imageList3 = new ImageList(components);
            exampanel = new Panel();
            button2 = new Button();
            markattendance = new Button();
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
            panel4 = new Panel();
            Exam_Type = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Enter_class = new TextBox();
            Enter_total_marks = new TextBox();
            label3 = new Label();
            Enter_obtained_marks = new TextBox();
            label5 = new Label();
            Fetch = new Button();
            Edit = new Button();
            Add = new Button();
            label7 = new Label();
            Enter_id = new TextBox();
            label9 = new Label();
            panel2.SuspendLayout();
            exampanel.SuspendLayout();
            pnlDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            button3.TabIndex = 59;
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
            lecturereport.Location = new Point(38, 542);
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
            exampanel.Controls.Add(button2);
            exampanel.Controls.Add(sectionwiseresult);
            exampanel.Location = new Point(332, 442);
            exampanel.Margin = new Padding(3, 2, 3, 2);
            exampanel.MaximumSize = new Size(248, 108);
            exampanel.MinimumSize = new Size(248, 56);
            exampanel.Name = "exampanel";
            exampanel.Size = new Size(248, 108);
            exampanel.TabIndex = 15;
            exampanel.Visible = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 1;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(248, 56);
            button2.TabIndex = 53;
            button2.Text = "Marks Entry";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // markattendance
            // 
            markattendance.FlatAppearance.BorderSize = 0;
            markattendance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            markattendance.ImageAlign = ContentAlignment.MiddleLeft;
            markattendance.ImageIndex = 1;
            markattendance.Location = new Point(0, 0);
            markattendance.Margin = new Padding(3, 2, 3, 2);
            markattendance.Name = "markattendance";
            markattendance.Padding = new Padding(31, 0, 0, 0);
            markattendance.Size = new Size(248, 56);
            markattendance.TabIndex = 11;
            markattendance.Text = "Daily Attendance";
            markattendance.UseVisualStyleBackColor = true;
            markattendance.Click += markattendance_Click;
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
            pnlDropdown.Controls.Add(markattendance);
            pnlDropdown.Location = new Point(332, 259);
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
            imageList2.Images.SetKeyName(1, "Attendance icon in teacher.jpg");
            // 
            // attendance
            // 
            attendance.FlatAppearance.BorderSize = 0;
            attendance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            attendance.ImageAlign = ContentAlignment.MiddleLeft;
            attendance.ImageIndex = 1;
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
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 749);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.Controls.Add(Exam_Type);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(Enter_class);
            panel4.Controls.Add(Enter_total_marks);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Enter_obtained_marks);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(Fetch);
            panel4.Controls.Add(Edit);
            panel4.Controls.Add(Add);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(Enter_id);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(431, 76);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(829, 673);
            panel4.TabIndex = 55;
            panel4.Paint += panel4_Paint;
            // 
            // Exam_Type
            // 
            Exam_Type.Location = new Point(356, 421);
            Exam_Type.Margin = new Padding(3, 2, 3, 2);
            Exam_Type.Multiline = true;
            Exam_Type.Name = "Exam_Type";
            Exam_Type.Size = new Size(259, 33);
            Exam_Type.TabIndex = 89;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(356, 378);
            label2.Name = "label2";
            label2.Size = new Size(135, 30);
            label2.TabIndex = 88;
            label2.Text = "Exam Type*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(539, 122);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 84;
            label1.Text = "Subject*";
            // 
            // Enter_class
            // 
            Enter_class.Location = new Point(539, 164);
            Enter_class.Margin = new Padding(3, 2, 3, 2);
            Enter_class.Multiline = true;
            Enter_class.Name = "Enter_class";
            Enter_class.Size = new Size(259, 33);
            Enter_class.TabIndex = 87;
            // 
            // Enter_total_marks
            // 
            Enter_total_marks.Location = new Point(539, 306);
            Enter_total_marks.Margin = new Padding(3, 2, 3, 2);
            Enter_total_marks.Multiline = true;
            Enter_total_marks.Name = "Enter_total_marks";
            Enter_total_marks.Size = new Size(259, 33);
            Enter_total_marks.TabIndex = 86;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(539, 263);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 85;
            label3.Text = "Total Marks*";
            // 
            // Enter_obtained_marks
            // 
            Enter_obtained_marks.Location = new Point(193, 306);
            Enter_obtained_marks.Margin = new Padding(3, 2, 3, 2);
            Enter_obtained_marks.Multiline = true;
            Enter_obtained_marks.Name = "Enter_obtained_marks";
            Enter_obtained_marks.Size = new Size(259, 33);
            Enter_obtained_marks.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(193, 263);
            label5.Name = "label5";
            label5.Size = new Size(190, 30);
            label5.TabIndex = 82;
            label5.Text = "Obtained Marks*";
            // 
            // Fetch
            // 
            Fetch.BackColor = Color.FromArgb(255, 224, 192);
            Fetch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fetch.Location = new Point(561, 496);
            Fetch.Margin = new Padding(3, 2, 3, 2);
            Fetch.Name = "Fetch";
            Fetch.Size = new Size(150, 37);
            Fetch.TabIndex = 79;
            Fetch.Text = "Fetch";
            Fetch.UseVisualStyleBackColor = false;
            Fetch.Click += Fetch_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.LightCoral;
            Edit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.Location = new Point(195, 496);
            Edit.Margin = new Padding(3, 2, 3, 2);
            Edit.Name = "Edit";
            Edit.Size = new Size(150, 37);
            Edit.TabIndex = 80;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(192, 255, 255);
            Add.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(375, 496);
            Add.Margin = new Padding(3, 2, 3, 2);
            Add.Name = "Add";
            Add.Size = new Size(150, 37);
            Add.TabIndex = 78;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(193, 122);
            label7.Name = "label7";
            label7.Size = new Size(52, 30);
            label7.TabIndex = 49;
            label7.Text = "ID *";
            // 
            // Enter_id
            // 
            Enter_id.Location = new Point(193, 164);
            Enter_id.Margin = new Padding(3, 2, 3, 2);
            Enter_id.Multiline = true;
            Enter_id.Name = "Enter_id";
            Enter_id.Size = new Size(259, 33);
            Enter_id.TabIndex = 61;
            Enter_id.TextChanged += Enter_id_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(232, 34);
            label9.Name = "label9";
            label9.Size = new Size(359, 47);
            label9.TabIndex = 0;
            label9.Text = "Enter Student Marks";
            // 
            // MarksEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(exampanel);
            Controls.Add(pnlDropdown);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MarksEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarksEntry";
            WindowState = FormWindowState.Maximized;
            Load += MarksEntry_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            exampanel.ResumeLayout(false);
            pnlDropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button markattendance;
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
        private Button button2;
        private ImageList imageList3;
        private ImageList imageList2;
        private Panel panel4;
        private Button Fetch;
        private Button Edit;
        private Button Add;
        private Label label7;
        private TextBox Enter_id;
        private Label label9;
        private Label label1;
        private TextBox Enter_class;
        private TextBox Enter_total_marks;
        private Label label3;
        private TextBox Enter_obtained_marks;
        private Label label5;
        private TextBox Exam_Type;
        private Label label2;
    }
}