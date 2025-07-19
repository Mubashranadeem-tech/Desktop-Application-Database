namespace Database_Project
{
    partial class DailyAttendanceP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyAttendanceP));
            logout = new Button();
            panel2 = new Panel();
            button3 = new Button();
            imageList2 = new ImageList(components);
            label12 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            imageList3 = new ImageList(components);
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button2 = new Button();
            Studentdetails = new Button();
            pictureBox1 = new PictureBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.Location = new Point(2332, 0);
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
            panel2.Location = new Point(320, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1363, 52);
            panel2.TabIndex = 17;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 0;
            button3.ImageList = imageList2;
            button3.Location = new Point(1226, 0);
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
            panel3.Controls.Add(panel1);
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
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Studentdetails);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 749);
            panel1.TabIndex = 97;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 4;
            button1.ImageList = imageList3;
            button1.Location = new Point(41, 422);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(248, 56);
            button1.TabIndex = 92;
            button1.Text = "Expense Details";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "exam.png");
            imageList3.Images.SetKeyName(1, "Dashboard-icon.png");
            imageList3.Images.SetKeyName(2, "student icon 1.png");
            imageList3.Images.SetKeyName(3, "teacher logo.png");
            imageList3.Images.SetKeyName(4, "expense details icon.png");
            imageList3.Images.SetKeyName(5, "attendance icon.jpg");
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImageIndex = 3;
            button8.ImageList = imageList3;
            button8.Location = new Point(41, 644);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(248, 56);
            button8.TabIndex = 6;
            button8.Text = "   Teacher Details";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.ImageIndex = 0;
            button7.ImageList = imageList3;
            button7.Location = new Point(41, 571);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(248, 56);
            button7.TabIndex = 5;
            button7.Text = "   Exam Result";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.ImageIndex = 1;
            button5.ImageList = imageList3;
            button5.Location = new Point(41, 268);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(248, 56);
            button5.TabIndex = 4;
            button5.Text = "  Dashboard";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageIndex = 5;
            button2.ImageList = imageList3;
            button2.Location = new Point(41, 495);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(248, 56);
            button2.TabIndex = 3;
            button2.Text = "   Attendance";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Studentdetails
            // 
            Studentdetails.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Studentdetails.ImageAlign = ContentAlignment.MiddleLeft;
            Studentdetails.ImageIndex = 2;
            Studentdetails.ImageList = imageList3;
            Studentdetails.Location = new Point(41, 344);
            Studentdetails.Margin = new Padding(3, 2, 3, 2);
            Studentdetails.Name = "Studentdetails";
            Studentdetails.Size = new Size(248, 56);
            Studentdetails.TabIndex = 1;
            Studentdetails.Text = "     Student Details";
            Studentdetails.UseVisualStyleBackColor = true;
            Studentdetails.Click += Studentdetails_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Profile_icon;
            pictureBox1.Location = new Point(55, 52);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Enter_ID
            // 
            Enter_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter_ID.Location = new Point(401, 166);
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
            label3.Location = new Point(401, 129);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 50;
            label3.Text = "Enter ID*";
            // 
            // Enter_CLASS_ID
            // 
            Enter_CLASS_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Enter_CLASS_ID.Location = new Point(630, 166);
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
            dataGridView1.Location = new Point(416, 226);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 357);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(857, 177);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(630, 117);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 4;
            label5.Text = "Select Class*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(857, 129);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Select Date*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(378, 67);
            label1.Name = "label1";
            label1.Size = new Size(249, 37);
            label1.TabIndex = 0;
            label1.Text = "Daily Attendance*";
            // 
            // DailyAttendanceP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DailyAttendanceP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarkAttendance";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Button button1;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button2;
        private Button Studentdetails;
        private PictureBox pictureBox1;
        private ImageList imageList2;
        private ImageList imageList3;
    }
}