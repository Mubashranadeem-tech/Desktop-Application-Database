namespace Admin_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button9 = new Button();
            button3 = new Button();
            button5 = new Button();
            button11 = new Button();
            button10 = new Button();
            TeachersCount = new Label();
            StudentsCount = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            imageList2 = new ImageList(components);
            panel2 = new Panel();
            button4 = new Button();
            button6 = new Button();
            panel5 = new Panel();
            logout = new Button();
            label12 = new Label();
            panel3 = new Panel();
            ADDteacher = new Button();
            teacherdetails = new Button();
            pictureBox11 = new PictureBox();
            pictureBox2 = new PictureBox();
            insta_label = new Label();
            linkedin = new Panel();
            linkedinTextLabel = new Label();
            label6 = new Label();
            facebook = new Panel();
            facebooktextLabel = new Label();
            facebookIconLabel = new Label();
            twitter = new Panel();
            twittertext = new Label();
            twittericon = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            linkedin.SuspendLayout();
            facebook.SuspendLayout();
            twitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)twittericon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            button1.TabIndex = 6;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Dashboard_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 749);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Database_Project.Properties.Resources.Profile_icon;
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
            button3.ImageIndex = 3;
            button3.ImageList = imageList1;
            button3.Location = new Point(38, 368);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(13, 0, 0, 0);
            button3.Size = new Size(248, 55);
            button3.TabIndex = 8;
            button3.Text = "Students ▶";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Students_Click;
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
            button5.Click += Teachers_Click;
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
            button11.TabIndex = 19;
            button11.Text = "  Attendence";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
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
            button10.TabIndex = 18;
            button10.Text = "Student Report";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // TeachersCount
            // 
            TeachersCount.AutoSize = true;
            TeachersCount.BackColor = Color.White;
            TeachersCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeachersCount.Location = new Point(849, 124);
            TeachersCount.Name = "TeachersCount";
            TeachersCount.Size = new Size(54, 45);
            TeachersCount.TabIndex = 13;
            TeachersCount.Text = "11";
            // 
            // StudentsCount
            // 
            StudentsCount.AutoSize = true;
            StudentsCount.BackColor = Color.White;
            StudentsCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentsCount.Location = new Point(536, 124);
            StudentsCount.Name = "StudentsCount";
            StudentsCount.Size = new Size(71, 45);
            StudentsCount.TabIndex = 14;
            StudentsCount.Text = "180";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumTurquoise;
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(981, 73);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 437);
            panel4.TabIndex = 15;
            panel4.Paint += panel4_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(22, 90);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(303, 154);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 264);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(313, 159);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(107, 4);
            label3.Name = "label3";
            label3.Size = new Size(218, 45);
            label3.TabIndex = 0;
            label3.Text = "Notice Board";
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "logout icon.png");
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(311, 355);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.MaximumSize = new Size(204, 81);
            panel2.MinimumSize = new Size(204, 37);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(13, 0, 0, 0);
            panel2.Size = new Size(204, 81);
            panel2.TabIndex = 52;
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
            // panel5
            // 
            panel5.Controls.Add(logout);
            panel5.Controls.Add(label12);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(310, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1060, 52);
            panel5.TabIndex = 54;
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
            logout.TabIndex = 55;
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
            label12.Location = new Point(442, 8);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 1;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // panel3
            // 
            panel3.Controls.Add(ADDteacher);
            panel3.Controls.Add(teacherdetails);
            panel3.Location = new Point(310, 440);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.MaximumSize = new Size(204, 81);
            panel3.MinimumSize = new Size(204, 37);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(13, 0, 0, 0);
            panel3.Size = new Size(204, 81);
            panel3.TabIndex = 55;
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
            // pictureBox11
            // 
            pictureBox11.Image = Database_Project.Properties.Resources.accountant_student_icon;
            pictureBox11.Location = new Point(342, 73);
            pictureBox11.Margin = new Padding(3, 2, 3, 2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(289, 100);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 65;
            pictureBox11.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(637, 73);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 66;
            pictureBox2.TabStop = false;
            // 
            // insta_label
            // 
            insta_label.AutoSize = true;
            insta_label.BackColor = Color.FromArgb(197, 45, 85);
            insta_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insta_label.ForeColor = Color.White;
            insta_label.Location = new Point(380, 605);
            insta_label.Name = "insta_label";
            insta_label.Size = new Size(207, 25);
            insta_label.TabIndex = 71;
            insta_label.Text = "Follow us on Instagram";
            insta_label.Click += insta_label_Click;
            // 
            // linkedin
            // 
            linkedin.BackColor = Color.FromArgb(21, 100, 192);
            linkedin.Controls.Add(linkedinTextLabel);
            linkedin.Controls.Add(label6);
            linkedin.ImeMode = ImeMode.Disable;
            linkedin.Location = new Point(593, 527);
            linkedin.Margin = new Padding(3, 2, 3, 2);
            linkedin.Name = "linkedin";
            linkedin.Size = new Size(232, 134);
            linkedin.TabIndex = 71;
            linkedin.Click += linkedin_Click;
            // 
            // linkedinTextLabel
            // 
            linkedinTextLabel.AutoSize = true;
            linkedinTextLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkedinTextLabel.ForeColor = Color.White;
            linkedinTextLabel.Location = new Point(38, 57);
            linkedinTextLabel.Name = "linkedinTextLabel";
            linkedinTextLabel.Size = new Size(190, 25);
            linkedinTextLabel.TabIndex = 71;
            linkedinTextLabel.Text = "Follow us on linkedin";
            linkedinTextLabel.Click += linkedinTextLabel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 44);
            label6.Name = "label6";
            label6.Size = new Size(53, 41);
            label6.TabIndex = 69;
            label6.Text = "in ";
            label6.Click += label6_Click;
            // 
            // facebook
            // 
            facebook.BackColor = Color.FromArgb(165, 175, 228);
            facebook.Controls.Add(facebooktextLabel);
            facebook.Controls.Add(facebookIconLabel);
            facebook.ImeMode = ImeMode.Disable;
            facebook.Location = new Point(831, 527);
            facebook.Margin = new Padding(3, 2, 3, 2);
            facebook.Name = "facebook";
            facebook.Size = new Size(246, 134);
            facebook.TabIndex = 72;
            facebook.Click += facebook_Click;
            facebook.Paint += facebook_Paint;
            // 
            // facebooktextLabel
            // 
            facebooktextLabel.AutoSize = true;
            facebooktextLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            facebooktextLabel.ForeColor = Color.White;
            facebooktextLabel.Location = new Point(60, 49);
            facebooktextLabel.Name = "facebooktextLabel";
            facebooktextLabel.Size = new Size(178, 25);
            facebooktextLabel.TabIndex = 71;
            facebooktextLabel.Text = "Like us on facebook";
            facebooktextLabel.Click += facebooktextLabel_Click;
            // 
            // facebookIconLabel
            // 
            facebookIconLabel.AutoSize = true;
            facebookIconLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            facebookIconLabel.ForeColor = Color.White;
            facebookIconLabel.Location = new Point(15, 49);
            facebookIconLabel.Name = "facebookIconLabel";
            facebookIconLabel.Size = new Size(38, 41);
            facebookIconLabel.TabIndex = 69;
            facebookIconLabel.Text = "f ";
            facebookIconLabel.Click += facebookIconLabel_Click;
            // 
            // twitter
            // 
            twitter.BackColor = Color.FromArgb(71, 169, 232);
            twitter.Controls.Add(twittertext);
            twitter.ImeMode = ImeMode.Disable;
            twitter.Location = new Point(1088, 527);
            twitter.Margin = new Padding(3, 2, 3, 2);
            twitter.Name = "twitter";
            twitter.Size = new Size(203, 134);
            twitter.TabIndex = 73;
            twitter.Click += twitter_Click;
            // 
            // twittertext
            // 
            twittertext.AutoSize = true;
            twittertext.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            twittertext.ForeColor = Color.White;
            twittertext.Location = new Point(21, 49);
            twittertext.Name = "twittertext";
            twittertext.Size = new Size(182, 25);
            twittertext.TabIndex = 71;
            twittertext.Text = "Follow us on twitter ";
            twittertext.Click += twittertext_Click;
            // 
            // twittericon
            // 
            twittericon.Image = (Image)resources.GetObject("twittericon.Image");
            twittericon.Location = new Point(316, 605);
            twittericon.Margin = new Padding(3, 2, 3, 2);
            twittericon.Name = "twittericon";
            twittericon.Size = new Size(55, 40);
            twittericon.SizeMode = PictureBoxSizeMode.StretchImage;
            twittericon.TabIndex = 74;
            twittericon.TabStop = false;
            twittericon.Click += twittericon_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(615, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 75;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(197, 45, 85);
            pictureBox3.Location = new Point(310, 527);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(277, 134);
            pictureBox3.TabIndex = 76;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(insta_label);
            Controls.Add(twittericon);
            Controls.Add(dateTimePicker1);
            Controls.Add(twitter);
            Controls.Add(facebook);
            Controls.Add(linkedin);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(panel4);
            Controls.Add(StudentsCount);
            Controls.Add(TeachersCount);
            Controls.Add(panel1);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admindashboard";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            linkedin.ResumeLayout(false);
            linkedin.PerformLayout();
            facebook.ResumeLayout(false);
            facebook.PerformLayout();
            twitter.ResumeLayout(false);
            twitter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)twittericon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Button button3;
        private Button button5;
        private Button button9;
        private Button button11;
        private Button button10;
        private Label TeachersCount;
        private Label StudentsCount;
        private Panel panel4;
        private Label label3;
        private TextBox textBox3;
        private ImageList imageList1;
        private ImageList imageList2;
        private Panel panel2;
        private Button button4;
        private Button button6;
        private Panel panel5;
        private Label label12;
        private Button logout;
        private Panel panel3;
        private Button ADDteacher;
        private Button teacherdetails;
        private PictureBox pictureBox1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel google;
        private Label insta_label;
        private Panel linkedin;
        private Label linkedinTextLabel;
        private Label label6;
        private Panel facebook;
        private Label facebooktextLabel;
        private Label facebookIconLabel;
        private Panel twitter;
        private Label twittertext;
        private PictureBox twittericon;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox3;
        private TextBox textBox1;
    }
}
