namespace Database_Project
{
    partial class MarkLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkLeave));
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
            markattendance = new Button();
            button2 = new Button();
            pnlDropdown = new Panel();
            studentsearch = new Button();
            tchrDashboard = new Button();
            imageList2 = new ImageList(components);
            attendance = new Button();
            exams = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            buttonSaveAttendance = new Button();
            buttonMarkAllPresent = new Button();
            buttonMarkAllAbsent = new Button();
            labelStudentCount = new Label();
            labelDate = new Label();
            labelClass = new Label();
            comboBoxClass = new ComboBox();
            dateTimePickerAttendance = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            dataGridViewStudents = new DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel2.SuspendLayout();
            exampanel.SuspendLayout();
            pnlDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
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
            lecturereport.Location = new Point(38, 534);
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
            exampanel.Location = new Point(332, 449);
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
            button5.TabIndex = 54;
            button5.Text = "Marks Entry";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 1;
            button2.Location = new Point(0, 52);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(31, 0, 0, 0);
            button2.Size = new Size(248, 56);
            button2.TabIndex = 12;
            button2.Text = "Mark Attendance";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pnlDropdown
            // 
            pnlDropdown.Controls.Add(button2);
            pnlDropdown.Controls.Add(markattendance);
            pnlDropdown.Location = new Point(332, 272);
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
            panel3.Controls.Add(buttonSaveAttendance);
            panel3.Controls.Add(buttonMarkAllPresent);
            panel3.Controls.Add(buttonMarkAllAbsent);
            panel3.Controls.Add(labelStudentCount);
            panel3.Controls.Add(labelDate);
            panel3.Controls.Add(labelClass);
            panel3.Controls.Add(comboBoxClass);
            panel3.Controls.Add(dateTimePickerAttendance);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridViewStudents);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 749);
            panel3.TabIndex = 18;
            panel3.Paint += panel3_Paint;
            // 
            // buttonSaveAttendance
            // 
            buttonSaveAttendance.BackColor = Color.LightCoral;
            buttonSaveAttendance.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveAttendance.Location = new Point(586, 645);
            buttonSaveAttendance.Margin = new Padding(3, 2, 3, 2);
            buttonSaveAttendance.Name = "buttonSaveAttendance";
            buttonSaveAttendance.Size = new Size(150, 45);
            buttonSaveAttendance.TabIndex = 83;
            buttonSaveAttendance.Text = "Save Attendance";
            buttonSaveAttendance.UseVisualStyleBackColor = false;
            buttonSaveAttendance.Click += buttonSaveAttendance_Click;
            // 
            // buttonMarkAllPresent
            // 
            buttonMarkAllPresent.BackColor = Color.FromArgb(192, 255, 192);
            buttonMarkAllPresent.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMarkAllPresent.Location = new Point(788, 645);
            buttonMarkAllPresent.Margin = new Padding(3, 2, 3, 2);
            buttonMarkAllPresent.Name = "buttonMarkAllPresent";
            buttonMarkAllPresent.Size = new Size(150, 45);
            buttonMarkAllPresent.TabIndex = 84;
            buttonMarkAllPresent.Text = "Mark All Present";
            buttonMarkAllPresent.UseVisualStyleBackColor = false;
            buttonMarkAllPresent.Click += buttonMarkAllPresent_Click;
            // 
            // buttonMarkAllAbsent
            // 
            buttonMarkAllAbsent.BackColor = Color.FromArgb(192, 255, 255);
            buttonMarkAllAbsent.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMarkAllAbsent.Location = new Point(1000, 645);
            buttonMarkAllAbsent.Margin = new Padding(3, 2, 3, 2);
            buttonMarkAllAbsent.Name = "buttonMarkAllAbsent";
            buttonMarkAllAbsent.Size = new Size(150, 45);
            buttonMarkAllAbsent.TabIndex = 82;
            buttonMarkAllAbsent.Text = "Mark All Absent";
            buttonMarkAllAbsent.UseVisualStyleBackColor = false;
            buttonMarkAllAbsent.Click += buttonMarkAllAbsent_Click;
            // 
            // labelStudentCount
            // 
            labelStudentCount.AutoSize = true;
            labelStudentCount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentCount.Location = new Point(892, 149);
            labelStudentCount.Margin = new Padding(4, 0, 4, 0);
            labelStudentCount.Name = "labelStudentCount";
            labelStudentCount.Size = new Size(186, 30);
            labelStudentCount.TabIndex = 22;
            labelStudentCount.Text = "Total Students: 0";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(610, 159);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(68, 30);
            labelDate.TabIndex = 20;
            labelDate.Text = "Date:";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClass.Location = new Point(438, 159);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(71, 30);
            labelClass.TabIndex = 19;
            labelClass.Text = "Class:";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(438, 191);
            comboBoxClass.Margin = new Padding(3, 2, 3, 2);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(133, 23);
            comboBoxClass.TabIndex = 15;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // dateTimePickerAttendance
            // 
            dateTimePickerAttendance.Location = new Point(610, 191);
            dateTimePickerAttendance.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            dateTimePickerAttendance.Size = new Size(219, 23);
            dateTimePickerAttendance.TabIndex = 14;
            dateTimePickerAttendance.ValueChanged += dateTimePickerAttendance_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(471, 70);
            label3.Name = "label3";
            label3.Size = new Size(238, 37);
            label3.TabIndex = 11;
            label3.Text = "Mark Attendance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 10;
            label1.Text = "Daily Attendance*";
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(414, 229);
            dataGridViewStudents.Margin = new Padding(3, 2, 3, 2);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(944, 346);
            dataGridViewStudents.TabIndex = 23;
            dataGridViewStudents.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // MarkLeave
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
            Name = "MarkLeave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarkLeave";
            WindowState = FormWindowState.Maximized;
            Load += MarkLeave_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            exampanel.ResumeLayout(false);
            pnlDropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
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
        private Button button2;
        private Panel pnlDropdown;
        private Button studentsearch;
        private Button tchrDashboard;
        private Button attendance;
        private Button exams;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button3;
        private Panel panel3;
        private Label label3;
        private Label label1;
        private Button button5;
        private ImageList imageList3;
        private DateTimePicker dateTimePickerAttendance;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox comboBoxClass;
        private Label labelDate;
        private Label labelClass;
        private Label labelStudentCount;
        private DataGridView dataGridViewStudents;
        private Button buttonSaveAttendance;
        private Button buttonMarkAllPresent;
        private Button buttonMarkAllAbsent;
        private ImageList imageList2;
    }
}