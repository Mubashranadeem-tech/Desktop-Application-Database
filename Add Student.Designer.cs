using Database_Project.Properties;
namespace Admin_UI
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            teacherdropdown = new Button();
            imageList1 = new ImageList(components);
            StudentDropDown = new Button();
            attendance = new Button();
            button1 = new Button();
            button9 = new Button();
            Studentreport = new Button();
            panel2 = new Panel();
            addstudent = new Button();
            studentdetails = new Button();
            imageList2 = new ImageList(components);
            panel4 = new Panel();
            Enter_Address = new TextBox();
            Fetch = new Button();
            Edit = new Button();
            Delete = new Button();
            ADD = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            Select_Gender = new GroupBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            label7 = new Label();
            Enter_Id = new TextBox();
            Enter_Class = new TextBox();
            Enter_dob = new TextBox();
            Enter_Father_name = new TextBox();
            Enter_phone_no = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            Enter_Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            logout = new Button();
            panel5 = new Panel();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            Select_Gender.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(pictureBox1);
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
            panel1.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.pic;
            pictureBox1.Location = new Point(55, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // teacherdropdown
            // 
            teacherdropdown.BackColor = Color.White;
            teacherdropdown.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            teacherdropdown.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teacherdropdown.ImageAlign = ContentAlignment.MiddleLeft;
            teacherdropdown.ImageIndex = 1;
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Student.jpg");
            imageList1.Images.SetKeyName(1, "Teacher .jpg");
            imageList1.Images.SetKeyName(2, "Attendance View Student.jpg");
            imageList1.Images.SetKeyName(3, "dashboard.png");
            imageList1.Images.SetKeyName(4, "Notice board icon.jpg");
            // 
            // StudentDropDown
            // 
            StudentDropDown.BackColor = Color.White;
            StudentDropDown.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            StudentDropDown.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentDropDown.ImageAlign = ContentAlignment.MiddleLeft;
            StudentDropDown.ImageIndex = 0;
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
            attendance.ImageIndex = 2;
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
            button1.ImageIndex = 3;
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
            button9.ImageIndex = 4;
            button9.ImageList = imageList1;
            button9.Location = new Point(38, 304);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Padding = new Padding(13, 0, 0, 0);
            button9.Size = new Size(248, 56);
            button9.TabIndex = 49;
            button9.Text = " Notice Board";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // Studentreport
            // 
            Studentreport.BackColor = Color.White;
            Studentreport.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            Studentreport.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Studentreport.ImageAlign = ContentAlignment.MiddleLeft;
            Studentreport.ImageIndex = 2;
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
            panel2.Location = new Point(310, 354);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.MaximumSize = new Size(204, 81);
            panel2.MinimumSize = new Size(204, 37);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(13, 0, 0, 0);
            panel2.Size = new Size(204, 81);
            panel2.TabIndex = 50;
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
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "logout icon.png");
            // 
            // panel4
            // 
            panel4.Controls.Add(Enter_Address);
            panel4.Controls.Add(Fetch);
            panel4.Controls.Add(Edit);
            panel4.Controls.Add(Delete);
            panel4.Controls.Add(ADD);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(Select_Gender);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(Enter_Id);
            panel4.Controls.Add(Enter_Class);
            panel4.Controls.Add(Enter_dob);
            panel4.Controls.Add(Enter_Father_name);
            panel4.Controls.Add(Enter_phone_no);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Enter_Name);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(363, 65);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(829, 673);
            panel4.TabIndex = 54;
            panel4.Paint += panel4_Paint;
            // 
            // Enter_Address
            // 
            Enter_Address.Location = new Point(546, 398);
            Enter_Address.Margin = new Padding(3, 2, 3, 2);
            Enter_Address.Multiline = true;
            Enter_Address.Name = "Enter_Address";
            Enter_Address.Size = new Size(259, 33);
            Enter_Address.TabIndex = 82;
            // 
            // Fetch
            // 
            Fetch.BackColor = Color.FromArgb(255, 224, 192);
            Fetch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fetch.Location = new Point(660, 634);
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
            Edit.Location = new Point(136, 634);
            Edit.Margin = new Padding(3, 2, 3, 2);
            Edit.Name = "Edit";
            Edit.Size = new Size(150, 37);
            Edit.TabIndex = 80;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(192, 255, 192);
            Delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(306, 634);
            Delete.Margin = new Padding(3, 2, 3, 2);
            Delete.Name = "Delete";
            Delete.Size = new Size(150, 37);
            Delete.TabIndex = 81;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // ADD
            // 
            ADD.BackColor = Color.FromArgb(192, 255, 255);
            ADD.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADD.Location = new Point(474, 634);
            ADD.Margin = new Padding(3, 2, 3, 2);
            ADD.Name = "ADD";
            ADD.Size = new Size(150, 37);
            ADD.TabIndex = 78;
            ADD.Text = "Add";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(546, 355);
            label6.Name = "label6";
            label6.Size = new Size(113, 30);
            label6.TabIndex = 75;
            label6.Text = "Address *";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(193, 589);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 33);
            textBox3.TabIndex = 66;
            textBox3.Leave += textBox3_Leave;
            // 
            // Select_Gender
            // 
            Select_Gender.BackColor = Color.Transparent;
            Select_Gender.Controls.Add(radioButton_female);
            Select_Gender.Controls.Add(radioButton_male);
            Select_Gender.Location = new Point(193, 260);
            Select_Gender.Margin = new Padding(3, 2, 3, 2);
            Select_Gender.Name = "Select_Gender";
            Select_Gender.Padding = new Padding(3, 2, 3, 2);
            Select_Gender.Size = new Size(258, 53);
            Select_Gender.TabIndex = 65;
            Select_Gender.TabStop = false;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_female.Location = new Point(125, 20);
            radioButton_female.Margin = new Padding(3, 2, 3, 2);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(75, 24);
            radioButton_female.TabIndex = 1;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_male.Location = new Point(36, 20);
            radioButton_male.Margin = new Padding(3, 2, 3, 2);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(60, 24);
            radioButton_male.TabIndex = 0;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
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
            // Enter_Id
            // 
            Enter_Id.Location = new Point(193, 164);
            Enter_Id.Margin = new Padding(3, 2, 3, 2);
            Enter_Id.Multiline = true;
            Enter_Id.Name = "Enter_Id";
            Enter_Id.Size = new Size(259, 33);
            Enter_Id.TabIndex = 61;
            Enter_Id.KeyPress += textBox9_KeyPress;
            // 
            // Enter_Class
            // 
            Enter_Class.Location = new Point(193, 398);
            Enter_Class.Margin = new Padding(3, 2, 3, 2);
            Enter_Class.Multiline = true;
            Enter_Class.Name = "Enter_Class";
            Enter_Class.Size = new Size(259, 33);
            Enter_Class.TabIndex = 60;
            Enter_Class.KeyPress += textBox8_KeyPress;
            // 
            // Enter_dob
            // 
            Enter_dob.Location = new Point(193, 498);
            Enter_dob.Margin = new Padding(3, 2, 3, 2);
            Enter_dob.Multiline = true;
            Enter_dob.Name = "Enter_dob";
            Enter_dob.Size = new Size(259, 33);
            Enter_dob.TabIndex = 59;
            Enter_dob.KeyPress += textBox7_KeyPress;
            // 
            // Enter_Father_name
            // 
            Enter_Father_name.Location = new Point(546, 272);
            Enter_Father_name.Margin = new Padding(3, 2, 3, 2);
            Enter_Father_name.Multiline = true;
            Enter_Father_name.Name = "Enter_Father_name";
            Enter_Father_name.Size = new Size(259, 33);
            Enter_Father_name.TabIndex = 57;
            Enter_Father_name.Click += textBox4_Click;
            Enter_Father_name.KeyPress += textBox4_KeyPress;
            // 
            // Enter_phone_no
            // 
            Enter_phone_no.Location = new Point(546, 498);
            Enter_phone_no.Margin = new Padding(3, 2, 3, 2);
            Enter_phone_no.Multiline = true;
            Enter_phone_no.Name = "Enter_phone_no";
            Enter_phone_no.Size = new Size(259, 33);
            Enter_phone_no.TabIndex = 55;
            Enter_phone_no.KeyPress += textBox2_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label11.Location = new Point(546, 455);
            label11.Name = "label11";
            label11.Size = new Size(185, 30);
            label11.TabIndex = 54;
            label11.Text = "Phone Number *";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.Location = new Point(193, 548);
            label10.Name = "label10";
            label10.Size = new Size(85, 30);
            label10.TabIndex = 53;
            label10.Text = "Email *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(193, 455);
            label8.Name = "label8";
            label8.Size = new Size(76, 30);
            label8.TabIndex = 51;
            label8.Text = "DOB *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(193, 355);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 50;
            label4.Text = "Class *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(546, 230);
            label5.Name = "label5";
            label5.Size = new Size(157, 30);
            label5.TabIndex = 47;
            label5.Text = "Father name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(193, 230);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 45;
            label3.Text = "Gender *";
            // 
            // Enter_Name
            // 
            Enter_Name.Location = new Point(546, 164);
            Enter_Name.Margin = new Padding(3, 2, 3, 2);
            Enter_Name.Multiline = true;
            Enter_Name.Name = "Enter_Name";
            Enter_Name.Size = new Size(259, 33);
            Enter_Name.TabIndex = 44;
            Enter_Name.Click += textBox1_Click;
            Enter_Name.TextChanged += textBox1_TextChanged;
            Enter_Name.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(546, 122);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 43;
            label2.Text = "Name *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 61);
            label1.Name = "label1";
            label1.Size = new Size(229, 47);
            label1.TabIndex = 0;
            label1.Text = "Add Student";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Controls.Add(logout);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(310, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1060, 52);
            panel3.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(442, 8);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 2;
            label12.Text = "Al Hamd Knowledge House";
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
            logout.TabIndex = 56;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Controls.Add(button3);
            panel5.Location = new Point(310, 545);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.MaximumSize = new Size(204, 81);
            panel5.MinimumSize = new Size(204, 37);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(13, 0, 0, 0);
            panel5.Size = new Size(204, 81);
            panel5.TabIndex = 57;
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
            button2.Click += button2_Click_1;
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
            // Add_Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Add_Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Student";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Select_Gender.ResumeLayout(false);
            Select_Gender.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button teacherdropdown;
        private Button StudentDropDown;
        private Button attendance;
        private Button button1;
        private Button button9;
        private Button Studentreport;
        private Panel panel2;
        private Button addstudent;
        private Button studentdetails;
        private ImageList imageList1;
        private Panel panel4;
        private TextBox Enter_Id;
        private TextBox Enter_Class;
        private TextBox Enter_dob;
        private TextBox Enter_Father_name;
        private TextBox Enter_phone_no;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label3;
        private TextBox Enter_Name;
        private Label label2;
        private Label label1;
        private ImageList imageList2;
        private Panel panel3;
        private Label label12;
        private Button logout;
        private Panel panel5;
        private Button button2;
        private Button button3;
        private GroupBox Select_Gender;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Label label6;
        private Button Fetch;
        private Button Edit;
        private Button Delete;
        private Button ADD;
        private TextBox Enter_Address;
    }
}