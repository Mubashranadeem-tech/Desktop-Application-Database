namespace Database_Project
{
    partial class DailyAttendanceA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyAttendanceA));
            logout = new Button();
            panel2 = new Panel();
            button3 = new Button();
            imageList2 = new ImageList(components);
            label12 = new Label();
            panel3 = new Panel();
            teacher_dropdown = new Panel();
            ADDteacher = new Button();
            teacherdetails = new Button();
            Student_Dropdown = new Panel();
            button4 = new Button();
            button1 = new Button();
            button11 = new Button();
            imageList1 = new ImageList(components);
            button10 = new Button();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            button9 = new Button();
            button2 = new Button();
            button5 = new Button();
            teacher_click = new Button();
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
            panel3.SuspendLayout();
            teacher_dropdown.SuspendLayout();
            Student_Dropdown.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.Location = new Point(2342, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 58;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(logout);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(310, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1374, 52);
            panel2.TabIndex = 17;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 0;
            button3.ImageList = imageList2;
            button3.Location = new Point(1236, 0);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(137, 52);
            button3.TabIndex = 58;
            button3.Text = "Logout";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            label12.TabIndex = 12;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(teacher_dropdown);
            panel3.Controls.Add(Student_Dropdown);
            panel3.Controls.Add(button11);
            panel3.Controls.Add(button10);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(Enter_ID);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(Enter_CLASS_ID);
            panel3.Controls.Add(Search);
            panel3.Controls.Add(dataGridView1);
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
            // teacher_dropdown
            // 
            teacher_dropdown.Controls.Add(ADDteacher);
            teacher_dropdown.Controls.Add(teacherdetails);
            teacher_dropdown.Location = new Point(311, 544);
            teacher_dropdown.Margin = new Padding(3, 2, 3, 2);
            teacher_dropdown.MaximumSize = new Size(204, 81);
            teacher_dropdown.MinimumSize = new Size(204, 37);
            teacher_dropdown.Name = "teacher_dropdown";
            teacher_dropdown.Padding = new Padding(13, 0, 0, 0);
            teacher_dropdown.Size = new Size(204, 81);
            teacher_dropdown.TabIndex = 60;
            teacher_dropdown.Visible = false;
            // 
            // ADDteacher
            // 
            ADDteacher.BackColor = Color.White;
            ADDteacher.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            ADDteacher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADDteacher.Location = new Point(0, 43);
            ADDteacher.Margin = new Padding(3, 2, 3, 2);
            ADDteacher.Name = "ADDteacher";
            ADDteacher.Size = new Size(204, 37);
            ADDteacher.TabIndex = 7;
            ADDteacher.Text = "Add Teacher";
            ADDteacher.UseVisualStyleBackColor = false;
            ADDteacher.Click += ADDteacher_Click;
            // 
            // teacherdetails
            // 
            teacherdetails.BackColor = Color.White;
            teacherdetails.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            teacherdetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherdetails.Location = new Point(0, 0);
            teacherdetails.Margin = new Padding(3, 2, 3, 2);
            teacherdetails.Name = "teacherdetails";
            teacherdetails.Size = new Size(204, 37);
            teacherdetails.TabIndex = 10;
            teacherdetails.Text = "Teacher details";
            teacherdetails.UseVisualStyleBackColor = false;
            teacherdetails.Click += teacherdetails_Click;
            // 
            // Student_Dropdown
            // 
            Student_Dropdown.Controls.Add(button4);
            Student_Dropdown.Controls.Add(button1);
            Student_Dropdown.Location = new Point(311, 355);
            Student_Dropdown.Margin = new Padding(3, 2, 3, 2);
            Student_Dropdown.MaximumSize = new Size(204, 81);
            Student_Dropdown.MinimumSize = new Size(204, 37);
            Student_Dropdown.Name = "Student_Dropdown";
            Student_Dropdown.Padding = new Padding(13, 0, 0, 0);
            Student_Dropdown.Size = new Size(204, 81);
            Student_Dropdown.TabIndex = 59;
            Student_Dropdown.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(0, 43);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(204, 37);
            button4.TabIndex = 7;
            button4.Text = "Add Student";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(204, 37);
            button1.TabIndex = 10;
            button1.Text = "Student details";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            imageList1.Images.SetKeyName(2, "student icon 1.png");
            imageList1.Images.SetKeyName(3, "Dashboard-icon.png");
            imageList1.Images.SetKeyName(4, "training_18097074.png");
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.ImageIndex = 0;
            button10.ImageList = imageList1;
            button10.Location = new Point(38, 431);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Padding = new Padding(13, 0, 0, 0);
            button10.Size = new Size(248, 55);
            button10.TabIndex = 57;
            button10.Text = "Student Report";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.PaleTurquoise;
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(button9);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(teacher_click);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(310, 749);
            panel5.TabIndex = 56;
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
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 3;
            button2.ImageList = imageList1;
            button2.Location = new Point(38, 240);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(13, 0, 0, 0);
            button2.Size = new Size(248, 56);
            button2.TabIndex = 6;
            button2.Text = "Dashboard";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 2;
            button5.ImageList = imageList1;
            button5.Location = new Point(38, 368);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(13, 0, 0, 0);
            button5.Size = new Size(248, 55);
            button5.TabIndex = 8;
            button5.Text = "Students ▶";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // teacher_click
            // 
            teacher_click.BackColor = Color.White;
            teacher_click.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            teacher_click.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacher_click.ImageAlign = ContentAlignment.MiddleLeft;
            teacher_click.ImageIndex = 4;
            teacher_click.ImageList = imageList1;
            teacher_click.Location = new Point(38, 559);
            teacher_click.Margin = new Padding(3, 2, 3, 2);
            teacher_click.Name = "teacher_click";
            teacher_click.Padding = new Padding(13, 0, 0, 0);
            teacher_click.Size = new Size(248, 55);
            teacher_click.TabIndex = 11;
            teacher_click.Text = "Teachers ▶";
            teacher_click.UseVisualStyleBackColor = false;
            teacher_click.Click += teacher_click_Click;
            // 
            // Enter_ID
            // 
            Enter_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter_ID.Location = new Point(433, 167);
            Enter_ID.Margin = new Padding(3, 2, 3, 2);
            Enter_ID.Multiline = true;
            Enter_ID.Name = "Enter_ID";
            Enter_ID.PlaceholderText = "Search by Student ID..";
            Enter_ID.Size = new Size(191, 34);
            Enter_ID.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(422, 140);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 50;
            label3.Text = "Enter ID*";
            // 
            // Enter_CLASS_ID
            // 
            Enter_CLASS_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter_CLASS_ID.Location = new Point(656, 167);
            Enter_CLASS_ID.Margin = new Padding(3, 2, 3, 2);
            Enter_CLASS_ID.Multiline = true;
            Enter_CLASS_ID.Name = "Enter_CLASS_ID";
            Enter_CLASS_ID.PlaceholderText = "Search by Class ID..";
            Enter_CLASS_ID.Size = new Size(191, 34);
            Enter_CLASS_ID.TabIndex = 49;
            Enter_CLASS_ID.TextChanged += Enter_CLASS_ID_TextChanged;
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
            dataGridView1.Location = new Point(410, 223);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(900, 418);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(877, 169);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(656, 128);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 4;
            label5.Text = "Select Class*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(877, 140);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Select Date*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(326, 54);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 0;
            label1.Text = "Daily Attendance*";
            label1.Click += label1_Click;
            // 
            // DailyAttendanceA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DailyAttendanceA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarkAttendance";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            teacher_dropdown.ResumeLayout(false);
            Student_Dropdown.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button logout;
        private Panel panel2;
        private Label label12;
        private Button button3;
        private Panel panel3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label2;
        private DataGridView dataGridView1;
        private Button Search;
        private TextBox Enter_CLASS_ID;
        private TextBox Enter_ID;
        private Label label3;
        private Panel teacher_dropdown;
        private Button ADDteacher;
        private Button teacherdetails;
        private Panel Student_Dropdown;
        private Button button4;
        private Button button1;
        private Button button11;
        private Button button10;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Button button9;
        private Button button2;
        private Button button5;
        private Button teacher_click;
        private ImageList imageList2;
        private ImageList imageList1;
    }
}