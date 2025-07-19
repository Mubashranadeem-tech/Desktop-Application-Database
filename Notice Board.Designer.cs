namespace Admin_UI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            imageList1 = new ImageList(components);
            panel4 = new Panel();
            Delete = new Button();
            Save = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Date = new TextBox();
            Posted_by = new TextBox();
            Detail = new TextBox();
            Title = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button6 = new Button();
            panel3 = new Panel();
            ADDteacher = new Button();
            teacherdetails = new Button();
            attendance = new Button();
            studentreport = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            dashboard = new Button();
            noticeboard = new Button();
            student = new Button();
            teacher = new Button();
            imageList2 = new ImageList(components);
            panel6 = new Panel();
            logout = new Button();
            label12 = new Label();
            Text_panel = new Panel();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
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
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Delete);
            panel4.Controls.Add(Save);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Date);
            panel4.Controls.Add(Posted_by);
            panel4.Controls.Add(Detail);
            panel4.Controls.Add(Title);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(336, 102);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(341, 680);
            panel4.TabIndex = 38;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(255, 192, 192);
            Delete.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Delete.Location = new Point(216, 566);
            Delete.Margin = new Padding(3, 2, 3, 2);
            Delete.Name = "Delete";
            Delete.Size = new Size(114, 44);
            Delete.TabIndex = 11;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.PaleTurquoise;
            Save.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Save.Location = new Point(27, 566);
            Save.Margin = new Padding(3, 2, 3, 2);
            Save.Name = "Save";
            Save.Size = new Size(114, 44);
            Save.TabIndex = 10;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(89, 447);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 405);
            label5.Name = "label5";
            label5.Size = new Size(58, 30);
            label5.TabIndex = 8;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 192);
            label4.Name = "label4";
            label4.Size = new Size(77, 30);
            label4.TabIndex = 7;
            label4.Text = "Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 291);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 6;
            label3.Text = "Posted By";
            // 
            // Date
            // 
            Date.BackColor = Color.LightGray;
            Date.Location = new Point(27, 442);
            Date.Margin = new Padding(3, 2, 3, 2);
            Date.Multiline = true;
            Date.Name = "Date";
            Date.Size = new Size(290, 40);
            Date.TabIndex = 5;
            Date.TextChanged += Date_TextChanged;
            // 
            // Posted_by
            // 
            Posted_by.BackColor = Color.LightGray;
            Posted_by.Location = new Point(27, 341);
            Posted_by.Margin = new Padding(3, 2, 3, 2);
            Posted_by.Multiline = true;
            Posted_by.Name = "Posted_by";
            Posted_by.Size = new Size(281, 48);
            Posted_by.TabIndex = 4;
            // 
            // Detail
            // 
            Detail.BackColor = Color.LightGray;
            Detail.Location = new Point(27, 237);
            Detail.Margin = new Padding(3, 2, 3, 2);
            Detail.Multiline = true;
            Detail.Name = "Detail";
            Detail.Size = new Size(281, 42);
            Detail.TabIndex = 3;
            Detail.TextChanged += Detail_TextChanged;
            // 
            // Title
            // 
            Title.BackColor = Color.LightGray;
            Title.Location = new Point(27, 134);
            Title.Margin = new Padding(3, 2, 3, 2);
            Title.Multiline = true;
            Title.Name = "Title";
            Title.Size = new Size(281, 44);
            Title.TabIndex = 2;
            Title.TextChanged += Title_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(281, 47);
            label1.TabIndex = 0;
            label1.Text = "Create A Notice";
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(310, 358);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.MaximumSize = new Size(204, 81);
            panel2.MinimumSize = new Size(204, 37);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(13, 0, 0, 0);
            panel2.Size = new Size(204, 81);
            panel2.TabIndex = 59;
            panel2.Visible = false;
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
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 0);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(204, 37);
            button6.TabIndex = 10;
            button6.Text = "Student details";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ADDteacher);
            panel3.Controls.Add(teacherdetails);
            panel3.Location = new Point(316, 576);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.MaximumSize = new Size(204, 81);
            panel3.MinimumSize = new Size(204, 37);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(13, 0, 0, 0);
            panel3.Size = new Size(204, 81);
            panel3.TabIndex = 60;
            panel3.Visible = false;
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
            // attendance
            // 
            attendance.BackColor = Color.White;
            attendance.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            attendance.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendance.ImageAlign = ContentAlignment.MiddleLeft;
            attendance.ImageIndex = 0;
            attendance.ImageList = imageList1;
            attendance.Location = new Point(38, 496);
            attendance.Margin = new Padding(3, 2, 3, 2);
            attendance.Name = "attendance";
            attendance.Padding = new Padding(13, 0, 0, 0);
            attendance.Size = new Size(248, 55);
            attendance.TabIndex = 58;
            attendance.Text = "  Attendence";
            attendance.UseVisualStyleBackColor = false;
            attendance.Click += attendance_Click;
            // 
            // studentreport
            // 
            studentreport.BackColor = Color.White;
            studentreport.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            studentreport.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentreport.ImageAlign = ContentAlignment.MiddleLeft;
            studentreport.ImageIndex = 0;
            studentreport.ImageList = imageList1;
            studentreport.Location = new Point(38, 436);
            studentreport.Margin = new Padding(3, 2, 3, 2);
            studentreport.Name = "studentreport";
            studentreport.Padding = new Padding(13, 0, 0, 0);
            studentreport.Size = new Size(248, 55);
            studentreport.TabIndex = 57;
            studentreport.Text = "Student Report";
            studentreport.UseVisualStyleBackColor = false;
            studentreport.Click += studentreport_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(dashboard);
            panel1.Controls.Add(attendance);
            panel1.Controls.Add(studentreport);
            panel1.Controls.Add(noticeboard);
            panel1.Controls.Add(student);
            panel1.Controls.Add(teacher);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 749);
            panel1.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Database_Project.Properties.Resources.pic;
            pictureBox1.Location = new Point(55, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.White;
            dashboard.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            dashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.ImageIndex = 4;
            dashboard.ImageList = imageList1;
            dashboard.Location = new Point(38, 236);
            dashboard.Margin = new Padding(3, 2, 3, 2);
            dashboard.Name = "dashboard";
            dashboard.Padding = new Padding(13, 0, 0, 0);
            dashboard.Size = new Size(248, 56);
            dashboard.TabIndex = 59;
            dashboard.Text = "Dashboard";
            dashboard.UseVisualStyleBackColor = false;
            dashboard.Click += dashboard_Click;
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
            noticeboard.Size = new Size(248, 53);
            noticeboard.TabIndex = 16;
            noticeboard.Text = "    Notice Board";
            noticeboard.UseVisualStyleBackColor = false;
            noticeboard.Click += noticeboard_Click;
            // 
            // student
            // 
            student.BackColor = Color.White;
            student.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            student.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            student.ImageAlign = ContentAlignment.MiddleLeft;
            student.ImageIndex = 3;
            student.ImageList = imageList1;
            student.Location = new Point(38, 368);
            student.Margin = new Padding(3, 2, 3, 2);
            student.Name = "student";
            student.Padding = new Padding(13, 0, 0, 0);
            student.Size = new Size(248, 55);
            student.TabIndex = 8;
            student.Text = "Students ▶";
            student.UseVisualStyleBackColor = false;
            student.Click += student_Click;
            // 
            // teacher
            // 
            teacher.BackColor = Color.White;
            teacher.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            teacher.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacher.ImageAlign = ContentAlignment.MiddleLeft;
            teacher.ImageIndex = 5;
            teacher.ImageList = imageList1;
            teacher.Location = new Point(38, 559);
            teacher.Margin = new Padding(3, 2, 3, 2);
            teacher.Name = "teacher";
            teacher.Padding = new Padding(13, 0, 0, 0);
            teacher.Size = new Size(248, 55);
            teacher.TabIndex = 11;
            teacher.Text = "Teachers ▶";
            teacher.UseVisualStyleBackColor = false;
            teacher.Click += teacher_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "logout icon.png");
            // 
            // panel6
            // 
            panel6.Controls.Add(logout);
            panel6.Controls.Add(label12);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(310, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(1060, 52);
            panel6.TabIndex = 61;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 0;
            logout.ImageList = imageList2;
            logout.Location = new Point(911, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 57;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(311, 9);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 3;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // Text_panel
            // 
            Text_panel.BackColor = Color.Silver;
            Text_panel.ForeColor = Color.Black;
            Text_panel.Location = new Point(702, 102);
            Text_panel.Margin = new Padding(3, 2, 3, 2);
            Text_panel.Name = "Text_panel";
            Text_panel.Size = new Size(540, 514);
            Text_panel.TabIndex = 1;
            Text_panel.Paint += Text_panel_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(Text_panel);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox Date;
        private TextBox Posted_by;
        private TextBox Detail;
        private TextBox Title;
        private DateTimePicker dateTimePicker1;
        private Button Save;
        private ImageList imageList1;
        private Panel panel3;
        private Button ADDteacher;
        private Button teacherdetails;
        private Panel panel2;
        private Button button4;
        private Button button6;
        private Button attendance;
        private Button studentreport;
        private Panel panel1;
        private Button noticeboard;
        private Button student;
        private Button teacher;
        private ImageList imageList2;
        private Button dashboard;
        private Panel panel6;
        private Label label12;
        private Button logout;
        private PictureBox pictureBox1;
        private Button Delete;
        private Panel Text_panel;
    }
}