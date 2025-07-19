namespace Admin_UI
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            button5 = new Button();
            imageList1 = new ImageList(components);
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button11 = new Button();
            button1 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            button7 = new Button();
            button6 = new Button();
            label2 = new Label();
            Enter_Name = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Enter_Phone_no = new TextBox();
            Enter_Subject = new TextBox();
            Enter_Class = new TextBox();
            Enter_Id = new TextBox();
            Enter_Address = new TextBox();
            Enter_dob = new TextBox();
            panel4 = new Panel();
            Fetch = new Button();
            Edit = new Button();
            Delete = new Button();
            Enter_cnic = new TextBox();
            label8 = new Label();
            Enter_email = new TextBox();
            ADD = new Button();
            groupBox1 = new GroupBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            label1 = new Label();
            logout = new Button();
            imageList2 = new ImageList(components);
            panel5 = new Panel();
            label12 = new Label();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 749);
            panel1.TabIndex = 0;
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
            button5.Size = new Size(248, 56);
            button5.TabIndex = 44;
            button5.Text = "Teachers ▶";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Teachers_Click;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 37);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 3;
            button3.ImageList = imageList1;
            button3.Location = new Point(38, 368);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(13, 0, 0, 0);
            button3.Size = new Size(248, 56);
            button3.TabIndex = 39;
            button3.Text = "Students ▶";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Students_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.ImageIndex = 0;
            button11.ImageList = imageList1;
            button11.Location = new Point(38, 491);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Padding = new Padding(13, 0, 0, 0);
            button11.Size = new Size(248, 56);
            button11.TabIndex = 40;
            button11.Text = "  Attendence";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
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
            button1.Click += Dashboard_Click;
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
            button9.Click += button9_Click;
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
            button10.Size = new Size(248, 56);
            button10.TabIndex = 38;
            button10.Text = "Student Report";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(332, 354);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.MaximumSize = new Size(204, 81);
            panel2.MinimumSize = new Size(204, 37);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(13, 0, 0, 0);
            panel2.Size = new Size(204, 81);
            panel2.TabIndex = 47;
            panel2.Visible = false;
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
            button2.Text = "Add Student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddStudent_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(204, 37);
            button4.TabIndex = 10;
            button4.Text = "Student details";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Studentdetails_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(332, 544);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(13, 0, 0, 0);
            panel3.Size = new Size(206, 84);
            panel3.TabIndex = 48;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(0, 45);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(206, 37);
            button7.TabIndex = 12;
            button7.Text = "Add Teacher";
            button7.UseVisualStyleBackColor = false;
            button7.Click += AddTeacher_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(0, 0);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.MaximumSize = new Size(206, 84);
            button6.MinimumSize = new Size(206, 37);
            button6.Name = "button6";
            button6.Size = new Size(206, 37);
            button6.TabIndex = 15;
            button6.Text = "Teacher details";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Teacherdetails_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(193, 122);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 43;
            label2.Text = "Name *";
            // 
            // Enter_Name
            // 
            Enter_Name.Location = new Point(193, 164);
            Enter_Name.Margin = new Padding(3, 2, 3, 2);
            Enter_Name.Multiline = true;
            Enter_Name.Name = "Enter_Name";
            Enter_Name.Size = new Size(259, 33);
            Enter_Name.TabIndex = 44;
            Enter_Name.TextChanged += textBox1_TextChanged;
            Enter_Name.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(193, 464);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 45;
            label3.Text = "Email *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.Location = new Point(193, 207);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 47;
            label5.Text = "Gender *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label6.Location = new Point(199, 376);
            label6.Name = "label6";
            label6.Size = new Size(70, 30);
            label6.TabIndex = 48;
            label6.Text = "DOB*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label7.Location = new Point(546, 122);
            label7.Name = "label7";
            label7.Size = new Size(52, 30);
            label7.TabIndex = 49;
            label7.Text = "ID *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(546, 207);
            label4.Name = "label4";
            label4.Size = new Size(81, 30);
            label4.TabIndex = 50;
            label4.Text = "Class *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label9.Location = new Point(546, 296);
            label9.Name = "label9";
            label9.Size = new Size(113, 30);
            label9.TabIndex = 52;
            label9.Text = "Address *";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.Location = new Point(193, 292);
            label10.Name = "label10";
            label10.Size = new Size(106, 30);
            label10.TabIndex = 53;
            label10.Text = "Subject *";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label11.Location = new Point(546, 378);
            label11.Name = "label11";
            label11.Size = new Size(185, 30);
            label11.TabIndex = 54;
            label11.Text = "Phone Number *";
            // 
            // Enter_Phone_no
            // 
            Enter_Phone_no.Location = new Point(546, 421);
            Enter_Phone_no.Margin = new Padding(3, 2, 3, 2);
            Enter_Phone_no.Multiline = true;
            Enter_Phone_no.Name = "Enter_Phone_no";
            Enter_Phone_no.Size = new Size(259, 33);
            Enter_Phone_no.TabIndex = 55;
            Enter_Phone_no.KeyPress += textBox2_KeyPress;
            // 
            // Enter_Subject
            // 
            Enter_Subject.Location = new Point(193, 335);
            Enter_Subject.Margin = new Padding(3, 2, 3, 2);
            Enter_Subject.Multiline = true;
            Enter_Subject.Name = "Enter_Subject";
            Enter_Subject.Size = new Size(259, 33);
            Enter_Subject.TabIndex = 58;
            Enter_Subject.KeyPress += textBox6_KeyPress;
            // 
            // Enter_Class
            // 
            Enter_Class.Location = new Point(546, 250);
            Enter_Class.Margin = new Padding(3, 2, 3, 2);
            Enter_Class.Multiline = true;
            Enter_Class.Name = "Enter_Class";
            Enter_Class.Size = new Size(259, 33);
            Enter_Class.TabIndex = 60;
            Enter_Class.TextChanged += textBox8_TextChanged;
            Enter_Class.KeyPress += textBox8_KeyPress;
            // 
            // Enter_Id
            // 
            Enter_Id.Location = new Point(546, 164);
            Enter_Id.Margin = new Padding(3, 2, 3, 2);
            Enter_Id.Multiline = true;
            Enter_Id.Name = "Enter_Id";
            Enter_Id.Size = new Size(259, 33);
            Enter_Id.TabIndex = 61;
            Enter_Id.KeyPress += textBox9_KeyPress;
            // 
            // Enter_Address
            // 
            Enter_Address.Location = new Point(546, 338);
            Enter_Address.Margin = new Padding(3, 2, 3, 2);
            Enter_Address.Multiline = true;
            Enter_Address.Name = "Enter_Address";
            Enter_Address.Size = new Size(259, 31);
            Enter_Address.TabIndex = 62;
            Enter_Address.KeyPress += textBox10_KeyPress;
            // 
            // Enter_dob
            // 
            Enter_dob.Location = new Point(199, 419);
            Enter_dob.Margin = new Padding(3, 2, 3, 2);
            Enter_dob.Multiline = true;
            Enter_dob.Name = "Enter_dob";
            Enter_dob.Size = new Size(259, 33);
            Enter_dob.TabIndex = 63;
            Enter_dob.KeyPress += textBox11_KeyPress;
            // 
            // panel4
            // 
            panel4.Controls.Add(Fetch);
            panel4.Controls.Add(Edit);
            panel4.Controls.Add(Delete);
            panel4.Controls.Add(Enter_cnic);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(Enter_email);
            panel4.Controls.Add(Enter_Subject);
            panel4.Controls.Add(ADD);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(Enter_dob);
            panel4.Controls.Add(Enter_Address);
            panel4.Controls.Add(Enter_Id);
            panel4.Controls.Add(Enter_Class);
            panel4.Controls.Add(Enter_Phone_no);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Enter_Name);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(399, 65);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 673);
            panel4.TabIndex = 42;
            panel4.Paint += panel4_Paint;
            // 
            // Fetch
            // 
            Fetch.BackColor = Color.FromArgb(255, 224, 192);
            Fetch.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fetch.Location = new Point(663, 590);
            Fetch.Margin = new Padding(3, 2, 3, 2);
            Fetch.Name = "Fetch";
            Fetch.Size = new Size(150, 37);
            Fetch.TabIndex = 73;
            Fetch.Text = "Fetch";
            Fetch.UseVisualStyleBackColor = false;
            Fetch.Click += Fetch_Click;
            // 
            // Edit
            // 
            Edit.BackColor = Color.LightCoral;
            Edit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.Location = new Point(139, 590);
            Edit.Margin = new Padding(3, 2, 3, 2);
            Edit.Name = "Edit";
            Edit.Size = new Size(150, 37);
            Edit.TabIndex = 76;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(192, 255, 192);
            Delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(310, 590);
            Delete.Margin = new Padding(3, 2, 3, 2);
            Delete.Name = "Delete";
            Delete.Size = new Size(150, 37);
            Delete.TabIndex = 77;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Enter_cnic
            // 
            Enter_cnic.Location = new Point(546, 506);
            Enter_cnic.Margin = new Padding(3, 2, 3, 2);
            Enter_cnic.Multiline = true;
            Enter_cnic.Name = "Enter_cnic";
            Enter_cnic.Size = new Size(259, 33);
            Enter_cnic.TabIndex = 76;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(546, 464);
            label8.Name = "label8";
            label8.Size = new Size(81, 30);
            label8.TabIndex = 75;
            label8.Text = "CNIC *";
            // 
            // Enter_email
            // 
            Enter_email.Location = new Point(193, 506);
            Enter_email.Margin = new Padding(3, 2, 3, 2);
            Enter_email.Multiline = true;
            Enter_email.Name = "Enter_email";
            Enter_email.Size = new Size(259, 31);
            Enter_email.TabIndex = 65;
            Enter_email.Leave += textBox3_Leave_1;
            // 
            // ADD
            // 
            ADD.BackColor = Color.FromArgb(192, 255, 255);
            ADD.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADD.Location = new Point(478, 590);
            ADD.Margin = new Padding(3, 2, 3, 2);
            ADD.Name = "ADD";
            ADD.Size = new Size(150, 37);
            ADD.TabIndex = 72;
            ADD.Text = "Add";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_female);
            groupBox1.Controls.Add(radioButton_male);
            groupBox1.Location = new Point(193, 230);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(258, 52);
            groupBox1.TabIndex = 64;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 61);
            label1.Name = "label1";
            label1.Size = new Size(226, 47);
            label1.TabIndex = 0;
            label1.Text = "Add Teacher";
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 4;
            logout.ImageList = imageList2;
            logout.Location = new Point(922, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 49;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleRight;
            logout.UseVisualStyleBackColor = true;
            logout.Click += button8_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Settings icon.png");
            imageList2.Images.SetKeyName(1, "message icon.png");
            imageList2.Images.SetKeyName(2, "Profile logo.jpg");
            imageList2.Images.SetKeyName(3, "Drop down icon.png");
            imageList2.Images.SetKeyName(4, "logout.jpg");
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label12);
            panel5.Controls.Add(logout);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(310, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1060, 52);
            panel5.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 24F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(443, 10);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 0;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button3;
        private PictureBox pictureBox2;
        private Button button11;
        private Button button1;
        private Button button9;
        private Button button10;
        private Panel panel3;
        private Button button6;
        private Button button7;
        private ImageList imageList1;
        private Label label2;
        private TextBox Enter_Name;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox Enter_Phone_no;
        private TextBox Enter_Subject;
        private TextBox Enter_Class;
        private TextBox Enter_Id;
        private TextBox Enter_Address;
        private TextBox Enter_dob;
        private Panel panel2;
        private Button button2;
        private Button button4;
        private Panel panel4;
        private Label label1;
        private Button logout;
        private ImageList imageList2;
        private Panel panel5;
        private Label label12;
        private ColorDialog colorDialog1;
        private GroupBox groupBox1;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private TextBox Enter_email;
        private Button ADD;
        private TextBox Enter_cnic;
        private Label label8;
        private Button Fetch;
        private Button Edit;
        private Button Delete;
    }
}