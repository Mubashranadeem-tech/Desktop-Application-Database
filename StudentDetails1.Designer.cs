namespace Database_Project
{
    partial class StudentDetails1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetails1));
            imageList2 = new ImageList(components);
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            Search = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            logout = new Button();
            label12 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            imageList3 = new ImageList(components);
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(Search);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(362, 88);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1208, 602);
            panel4.TabIndex = 63;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 120);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(814, 323);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Search
            // 
            Search.BackColor = Color.Turquoise;
            Search.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(625, 64);
            Search.Margin = new Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.Size = new Size(149, 45);
            Search.TabIndex = 41;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(435, 69);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search by Class";
            textBox2.Size = new Size(154, 32);
            textBox2.TabIndex = 4;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(56, 69);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search by Name";
            textBox1.Size = new Size(168, 32);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F);
            textBox5.Location = new Point(243, 69);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Search by ID";
            textBox5.Size = new Size(165, 32);
            textBox5.TabIndex = 2;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 0;
            label1.Text = "All Students Data";
            // 
            // panel3
            // 
            panel3.Controls.Add(logout);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(320, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1363, 52);
            panel3.TabIndex = 67;
            // 
            // logout
            // 
            logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.ImageIndex = 0;
            logout.ImageList = imageList2;
            logout.Location = new Point(1226, 0);
            logout.Margin = new Padding(3, 2, 3, 2);
            logout.Name = "logout";
            logout.Size = new Size(137, 52);
            logout.TabIndex = 68;
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
            label12.Location = new Point(404, 7);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 68;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 749);
            panel1.TabIndex = 97;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImageIndex = 4;
            button6.ImageList = imageList3;
            button6.Location = new Point(41, 422);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(248, 56);
            button6.TabIndex = 92;
            button6.Text = "Expense Details";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
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
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 5;
            button3.ImageList = imageList3;
            button3.Location = new Point(41, 495);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(248, 56);
            button3.TabIndex = 3;
            button3.Text = "   Attendance";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageIndex = 2;
            button1.ImageList = imageList3;
            button1.Location = new Point(41, 344);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(248, 56);
            button1.TabIndex = 1;
            button1.Text = "     Student Details";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // 
            // StudentDetails1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentDetails1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDetails1";
            WindowState = FormWindowState.Maximized;
            Load += StudentDetails1_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList2;
        private Panel panel4;
        private Button Search;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox5;
        private Label label1;
        private Panel panel3;
        private Label label12;
        private Button logout;
        private Panel panel1;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button3;
        private Button button1;
        private PictureBox pictureBox1;
        private ImageList imageList3;
        private DataGridView dataGridView1;
    }
}