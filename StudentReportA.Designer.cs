namespace Database_Project
{
    partial class StudentReportA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReportA));
            markattendance = new Button();
            button1 = new Button();
            markleave = new Button();
            pnlDropdown = new Panel();
            sectionwiseresult = new Button();
            button2 = new Button();
            exampanel = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel3 = new Panel();
            Search_id = new TextBox();
            panel5 = new Panel();
            addteacher = new Button();
            teachersetails = new Button();
            search = new Button();
            panel4 = new Panel();
            addstudent = new Button();
            studentdetails = new Button();
            label3 = new Label();
            panel2 = new Panel();
            logout = new Button();
            imageList2 = new ImageList(components);
            label12 = new Label();
            select_exam = new ComboBox();
            panel1 = new Panel();
            button11 = new Button();
            imageList1 = new ImageList(components);
            button10 = new Button();
            pictureBox1 = new PictureBox();
            button9 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label7 = new Label();
            select_subject = new ComboBox();
            select_class = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            button6 = new Button();
            pnlDropdown.SuspendLayout();
            exampanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            markattendance.Text = "Mark Attendance";
            markattendance.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 1;
            button1.Location = new Point(0, 52);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(31, 0, 0, 0);
            button1.Size = new Size(248, 56);
            button1.TabIndex = 12;
            button1.Text = "Section wise Attendance";
            button1.UseVisualStyleBackColor = true;
            // 
            // markleave
            // 
            markleave.FlatAppearance.BorderSize = 0;
            markleave.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            markleave.ImageAlign = ContentAlignment.MiddleLeft;
            markleave.ImageIndex = 1;
            markleave.Location = new Point(0, 105);
            markleave.Margin = new Padding(3, 2, 3, 2);
            markleave.Name = "markleave";
            markleave.Padding = new Padding(31, 0, 0, 0);
            markleave.Size = new Size(248, 56);
            markleave.TabIndex = 12;
            markleave.Text = "Mark leave";
            markleave.UseVisualStyleBackColor = true;
            // 
            // pnlDropdown
            // 
            pnlDropdown.Controls.Add(markleave);
            pnlDropdown.Controls.Add(button1);
            pnlDropdown.Controls.Add(markattendance);
            pnlDropdown.Location = new Point(332, 274);
            pnlDropdown.Margin = new Padding(3, 2, 3, 2);
            pnlDropdown.MaximumSize = new Size(248, 160);
            pnlDropdown.MinimumSize = new Size(248, 56);
            pnlDropdown.Name = "pnlDropdown";
            pnlDropdown.Size = new Size(248, 160);
            pnlDropdown.TabIndex = 21;
            pnlDropdown.Visible = false;
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
            sectionwiseresult.Text = "Section wise result";
            sectionwiseresult.UseVisualStyleBackColor = true;
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
            button2.TabIndex = 52;
            button2.Text = "Marks Entry";
            button2.UseVisualStyleBackColor = true;
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
            exampanel.TabIndex = 20;
            exampanel.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 244);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 254);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(382, 64);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 37;
            label1.Text = "Exam Result";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(Search_id);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(search);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(select_exam);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(select_subject);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(select_class);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1370, 749);
            panel3.TabIndex = 23;
            // 
            // Search_id
            // 
            Search_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search_id.Location = new Point(373, 204);
            Search_id.Margin = new Padding(3, 2, 3, 2);
            Search_id.Multiline = true;
            Search_id.Name = "Search_id";
            Search_id.PlaceholderText = "Search by Student ID..";
            Search_id.Size = new Size(191, 34);
            Search_id.TabIndex = 111;
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
            panel5.TabIndex = 62;
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
            // search
            // 
            search.BackColor = Color.FromArgb(255, 192, 192);
            search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.Location = new Point(1388, 167);
            search.Margin = new Padding(3, 2, 3, 2);
            search.Name = "search";
            search.Size = new Size(138, 45);
            search.TabIndex = 116;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(addstudent);
            panel4.Controls.Add(studentdetails);
            panel4.Location = new Point(315, 350);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.MaximumSize = new Size(204, 81);
            panel4.MinimumSize = new Size(204, 37);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(13, 0, 0, 0);
            panel4.Size = new Size(204, 81);
            panel4.TabIndex = 60;
            panel4.Visible = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(382, 167);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 110;
            label3.Text = "Enter ID*";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(logout);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(310, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1060, 52);
            panel2.TabIndex = 53;
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
            logout.TabIndex = 58;
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
            label12.Location = new Point(520, 7);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 54;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // select_exam
            // 
            select_exam.FormattingEnabled = true;
            select_exam.Location = new Point(750, 217);
            select_exam.Margin = new Padding(3, 2, 3, 2);
            select_exam.Name = "select_exam";
            select_exam.Size = new Size(117, 23);
            select_exam.TabIndex = 118;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 749);
            panel1.TabIndex = 52;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.ImageIndex = 0;
            button11.ImageList = imageList1;
            button11.Location = new Point(38, 495);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Padding = new Padding(13, 0, 0, 0);
            button11.Size = new Size(248, 55);
            button11.TabIndex = 58;
            button11.Text = "  Attendence";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
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
            // button10
            // 
            button10.BackColor = Color.White;
            button10.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.ImageIndex = 0;
            button10.ImageList = imageList1;
            button10.Location = new Point(38, 434);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Padding = new Padding(13, 0, 0, 0);
            button10.Size = new Size(248, 55);
            button10.TabIndex = 57;
            button10.Text = "Student Report";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Profile_icon;
            pictureBox1.Location = new Point(55, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
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
            button9.Size = new Size(248, 53);
            button9.TabIndex = 16;
            button9.Text = "    Notice Board";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 4;
            button3.ImageList = imageList1;
            button3.Location = new Point(38, 240);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(13, 0, 0, 0);
            button3.Size = new Size(248, 56);
            button3.TabIndex = 6;
            button3.Text = "Dashboard";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 3;
            button4.ImageList = imageList1;
            button4.Location = new Point(38, 368);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(13, 0, 0, 0);
            button4.Size = new Size(248, 55);
            button4.TabIndex = 8;
            button4.Text = "Students ▶";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 5;
            button5.ImageList = imageList1;
            button5.Location = new Point(38, 559);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(13, 0, 0, 0);
            button5.Size = new Size(248, 55);
            button5.TabIndex = 11;
            button5.Text = "Teachers ▶";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(750, 167);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 115;
            label7.Text = "Select Exam*";
            // 
            // select_subject
            // 
            select_subject.FormattingEnabled = true;
            select_subject.Location = new Point(894, 217);
            select_subject.Margin = new Padding(3, 2, 3, 2);
            select_subject.Name = "select_subject";
            select_subject.Size = new Size(117, 23);
            select_subject.TabIndex = 117;
            // 
            // select_class
            // 
            select_class.FormattingEnabled = true;
            select_class.Location = new Point(597, 217);
            select_class.Margin = new Padding(3, 2, 3, 2);
            select_class.Name = "select_class";
            select_class.Size = new Size(117, 23);
            select_class.TabIndex = 113;
            select_class.SelectedIndexChanged += select_class_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(903, 177);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 114;
            label6.Text = "Select Subject*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(597, 167);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 112;
            label5.Text = "Select Class*";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 192, 192);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(1067, 195);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(138, 45);
            button6.TabIndex = 119;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = false;
            // 
            // StudentReportA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(exampanel);
            Controls.Add(pnlDropdown);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentReportA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentReportA";
            WindowState = FormWindowState.Maximized;
            pnlDropdown.ResumeLayout(false);
            exampanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button markattendance;
        private Button button1;
        private Button markleave;
        private Panel pnlDropdown;
        private Button sectionwiseresult;
        private Button button2;
        private Panel exampanel;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel3;
        private ImageList imageList2;
        private ImageList imageList1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button9;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button10;
        private Button button11;
        private Panel panel2;
        private Label label12;
        private Button logout;
        private Panel panel4;
        private Button addstudent;
        private Button studentdetails;
        private Panel panel5;
        private Button addteacher;
        private Button teachersetails;
        private TextBox Search_id;
        private Button search;
        private Label label3;
        private ComboBox select_exam;
        private Label label7;
        private ComboBox select_subject;
        private ComboBox select_class;
        private Label label6;
        private Label label5;
        private Button button6;
    }
}