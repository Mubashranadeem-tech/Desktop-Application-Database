namespace Database_Project
{
    partial class TeacherDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            panel1 = new Panel();
            studentsearch = new Button();
            imageList3 = new ImageList(components);
            lecturereport = new Button();
            tchrDashboard = new Button();
            imageList2 = new ImageList(components);
            attendance = new Button();
            exams = new Button();
            pictureBox1 = new PictureBox();
            pnlDropdown = new Panel();
            markattendance = new Button();
            markleave = new Button();
            exampanel = new Panel();
            button2 = new Button();
            sectionwiseresult = new Button();
            label12 = new Label();
            panel2 = new Panel();
            logout = new Button();
            imageList1 = new ImageList(components);
            panel3 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            select_class = new ComboBox();
            select_date = new DateTimePicker();
            label13 = new Label();
            panel11 = new Panel();
            pictureBox3 = new PictureBox();
            topperstudentname = new Label();
            label9 = new Label();
            panel10 = new Panel();
            pictureBox4 = new PictureBox();
            totalstudentcount = new Label();
            Total_Students = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            textBox1 = new TextBox();
            panel5 = new Panel();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel8 = new Panel();
            countabsentstudents = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDropdown.SuspendLayout();
            exampanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(291, 749);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // studentsearch
            // 
            studentsearch.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            studentsearch.ImageAlign = ContentAlignment.MiddleLeft;
            studentsearch.ImageIndex = 0;
            studentsearch.ImageList = imageList3;
            studentsearch.Location = new Point(22, 386);
            studentsearch.Margin = new Padding(3, 2, 3, 2);
            studentsearch.Name = "studentsearch";
            studentsearch.Size = new Size(248, 56);
            studentsearch.TabIndex = 3;
            studentsearch.Text = "Student Search";
            studentsearch.UseVisualStyleBackColor = true;
            studentsearch.Click += studentsearch_Click;
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
            // lecturereport
            // 
            lecturereport.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lecturereport.ImageAlign = ContentAlignment.MiddleLeft;
            lecturereport.ImageIndex = 2;
            lecturereport.ImageList = imageList3;
            lecturereport.Location = new Point(22, 534);
            lecturereport.Margin = new Padding(3, 2, 3, 2);
            lecturereport.Name = "lecturereport";
            lecturereport.Size = new Size(248, 56);
            lecturereport.TabIndex = 8;
            lecturereport.Text = "Lecture Report";
            lecturereport.UseVisualStyleBackColor = true;
            lecturereport.Click += lecturereport_Click;
            // 
            // tchrDashboard
            // 
            tchrDashboard.FlatAppearance.BorderSize = 0;
            tchrDashboard.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            tchrDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            tchrDashboard.ImageIndex = 0;
            tchrDashboard.ImageList = imageList2;
            tchrDashboard.Location = new Point(22, 243);
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
            attendance.Location = new Point(22, 315);
            attendance.Margin = new Padding(3, 2, 3, 2);
            attendance.MinimumSize = new Size(248, 56);
            attendance.Name = "attendance";
            attendance.Padding = new Padding(9, 0, 0, 0);
            attendance.Size = new Size(248, 56);
            attendance.TabIndex = 11;
            attendance.Text = "Attendance ▶";
            attendance.TextAlign = ContentAlignment.MiddleRight;
            attendance.UseVisualStyleBackColor = true;
            attendance.Click += attendance_Click;
            // 
            // exams
            // 
            exams.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            exams.ImageAlign = ContentAlignment.MiddleLeft;
            exams.ImageIndex = 1;
            exams.ImageList = imageList3;
            exams.Location = new Point(22, 462);
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
            pictureBox1.Location = new Point(35, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlDropdown
            // 
            pnlDropdown.Controls.Add(markattendance);
            pnlDropdown.Controls.Add(markleave);
            pnlDropdown.Location = new Point(332, 274);
            pnlDropdown.Margin = new Padding(3, 2, 3, 2);
            pnlDropdown.MaximumSize = new Size(248, 109);
            pnlDropdown.MinimumSize = new Size(248, 56);
            pnlDropdown.Name = "pnlDropdown";
            pnlDropdown.Size = new Size(248, 109);
            pnlDropdown.TabIndex = 11;
            pnlDropdown.Visible = false;
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
            // exampanel
            // 
            exampanel.Controls.Add(button2);
            exampanel.Controls.Add(sectionwiseresult);
            exampanel.Location = new Point(332, 450);
            exampanel.Margin = new Padding(3, 2, 3, 2);
            exampanel.MaximumSize = new Size(248, 108);
            exampanel.MinimumSize = new Size(248, 56);
            exampanel.Name = "exampanel";
            exampanel.Size = new Size(248, 108);
            exampanel.TabIndex = 3;
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
            sectionwiseresult.Text = "Exam result";
            sectionwiseresult.UseVisualStyleBackColor = true;
            sectionwiseresult.Click += sectionwiseresult_Click;
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
            // panel2
            // 
            panel2.Controls.Add(logout);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(291, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 52);
            panel2.TabIndex = 13;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 0;
            logout.ImageList = imageList1;
            logout.Location = new Point(942, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 58;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logout icon.png");
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(chart1);
            panel3.Controls.Add(panel8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 749);
            panel3.TabIndex = 14;
            panel3.Paint += panel3_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(select_class);
            panel7.Controls.Add(select_date);
            panel7.Controls.Add(label13);
            panel7.Location = new Point(1120, 78);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(265, 140);
            panel7.TabIndex = 128;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 15F, FontStyle.Bold);
            label10.Location = new Point(59, 8);
            label10.Name = "label10";
            label10.Size = new Size(114, 23);
            label10.TabIndex = 121;
            label10.Text = "Select Class";
            // 
            // select_class
            // 
            select_class.FormattingEnabled = true;
            select_class.Location = new Point(52, 33);
            select_class.Margin = new Padding(3, 2, 3, 2);
            select_class.Name = "select_class";
            select_class.Size = new Size(133, 23);
            select_class.TabIndex = 120;
            select_class.SelectedIndexChanged += select_class_SelectedIndexChanged;
            // 
            // select_date
            // 
            select_date.Location = new Point(31, 104);
            select_date.Margin = new Padding(3, 2, 3, 2);
            select_date.Name = "select_date";
            select_date.Size = new Size(219, 23);
            select_date.TabIndex = 125;
            select_date.ValueChanged += select_date_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 15F, FontStyle.Bold);
            label13.Location = new Point(31, 69);
            label13.Name = "label13";
            label13.Size = new Size(111, 23);
            label13.TabIndex = 124;
            label13.Text = "Select Date";
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(pictureBox3);
            panel11.Controls.Add(topperstudentname);
            panel11.Controls.Add(label9);
            panel11.Location = new Point(843, 77);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(273, 141);
            panel11.TabIndex = 119;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.topper;
            pictureBox3.Location = new Point(3, 42);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 118;
            pictureBox3.TabStop = false;
            // 
            // topperstudentname
            // 
            topperstudentname.AutoSize = true;
            topperstudentname.Font = new Font("Cambria", 20F, FontStyle.Bold);
            topperstudentname.Location = new Point(69, 61);
            topperstudentname.Name = "topperstudentname";
            topperstudentname.Size = new Size(46, 32);
            topperstudentname.TabIndex = 117;
            topperstudentname.Text = "15";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 22F, FontStyle.Bold);
            label9.Location = new Point(47, 8);
            label9.Name = "label9";
            label9.Size = new Size(229, 36);
            label9.TabIndex = 116;
            label9.Text = "Best performer";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(pictureBox4);
            panel10.Controls.Add(totalstudentcount);
            panel10.Controls.Add(Total_Students);
            panel10.Location = new Point(569, 77);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(252, 141);
            panel10.TabIndex = 118;
            panel10.Paint += panel10_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2025_05_28_153914;
            pictureBox4.Location = new Point(3, 42);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(98, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 118;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // totalstudentcount
            // 
            totalstudentcount.AutoSize = true;
            totalstudentcount.Font = new Font("Cambria", 20F, FontStyle.Bold);
            totalstudentcount.Location = new Point(162, 63);
            totalstudentcount.Name = "totalstudentcount";
            totalstudentcount.Size = new Size(46, 32);
            totalstudentcount.TabIndex = 117;
            totalstudentcount.Text = "15";
            // 
            // Total_Students
            // 
            Total_Students.AutoSize = true;
            Total_Students.Font = new Font("Cambria", 22F, FontStyle.Bold);
            Total_Students.Location = new Point(44, 8);
            Total_Students.Name = "Total_Students";
            Total_Students.Size = new Size(212, 36);
            Total_Students.TabIndex = 116;
            Total_Students.Text = "Total Students";
            Total_Students.Click += Total_Students_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PeachPuff;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(901, 222);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 480);
            panel4.TabIndex = 110;
            panel4.Paint += panel4_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Beige;
            panel6.Controls.Add(textBox1);
            panel6.Location = new Point(12, 65);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(422, 172);
            panel6.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(13, 11);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(400, 144);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Beige;
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(12, 269);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(431, 172);
            panel5.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(13, 11);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(400, 144);
            textBox2.TabIndex = 94;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 26.2F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(123, 25);
            label6.Name = "label6";
            label6.Size = new Size(293, 38);
            label6.TabIndex = 93;
            label6.Text = "Upcoming Events!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(624, 243);
            label5.Name = "label5";
            label5.Size = new Size(234, 21);
            label5.TabIndex = 117;
            label5.Text = "Average Exam Marks by Class";
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            chart1.Legends.Add(legend7);
            chart1.Location = new Point(298, 257);
            chart1.Name = "chart1";
            chart1.Size = new Size(597, 480);
            chart1.TabIndex = 116;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(countabsentstudents);
            panel8.Controls.Add(pictureBox2);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(297, 77);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(258, 141);
            panel8.TabIndex = 115;
            panel8.Paint += panel8_Paint;
            // 
            // countabsentstudents
            // 
            countabsentstudents.AutoSize = true;
            countabsentstudents.Font = new Font("Cambria", 20F, FontStyle.Bold);
            countabsentstudents.Location = new Point(162, 63);
            countabsentstudents.Name = "countabsentstudents";
            countabsentstudents.Size = new Size(46, 32);
            countabsentstudents.TabIndex = 117;
            countabsentstudents.Text = "15";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 42);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 116;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 22F, FontStyle.Bold);
            label7.Location = new Point(21, 8);
            label7.Name = "label7";
            label7.Size = new Size(240, 36);
            label7.TabIndex = 116;
            label7.Text = "Absent Students";
            // 
            // TeacherDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(pnlDropdown);
            Controls.Add(exampanel);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TeacherDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherDashboard";
            WindowState = FormWindowState.Maximized;
            Load += TeacherDashboard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDropdown.ResumeLayout(false);
            exampanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button tchrDashboard;
        private Button exams;
        private Button studentsearch;
        private PictureBox pictureBox1;
        private Button lecturereport;
        private Button sectionwiseresult;
        private Panel pnlDropdown;
        private Button markleave;
        private Button markattendance;
        private Button attendance;
        private Panel exampanel;
        private Label label12;
        private Panel panel2;
        private ImageList imageList1;
        private ImageList imageList2;
        private Button button2;
        private ImageList imageList3;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Label label6;
        private Panel panel8;
        private Label countabsentstudents;
        private Label label7;
        private Button logout;
        private PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label5;
        private Panel panel10;
        private Label totalstudentcount;
        private Label Total_Students;
        private Label label13;
        private Label label10;
        private ComboBox select_class;
        private Panel panel11;
        private Label topperstudentname;
        private Label label9;
        private DateTimePicker select_date;
        private Panel panel7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}