namespace Database_Project
{
    partial class ExamResultP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamResultP));
            sectionwiseresult = new Button();
            imageList1 = new ImageList(components);
            exampanel = new Panel();
            button2 = new Button();
            markleave = new Button();
            button1 = new Button();
            markattendance = new Button();
            pnlDropdown = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            label12 = new Label();
            panel3 = new Panel();
            Search_id = new TextBox();
            search = new Button();
            label3 = new Label();
            select_exam = new ComboBox();
            label7 = new Label();
            select_subject = new ComboBox();
            select_class = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            imageList3 = new ImageList(components);
            panel1 = new Panel();
            button4 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            pictureBox2 = new PictureBox();
            button10 = new Button();
            exampanel.SuspendLayout();
            pnlDropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logout icon.png");
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(335, 241);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(714, 418);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(351, 70);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 37;
            label1.Text = "Exam Result";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1668, 52);
            panel2.TabIndex = 52;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.ImageIndex = 0;
            button3.ImageList = imageList1;
            button3.Location = new Point(1530, 0);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(137, 52);
            button3.TabIndex = 60;
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
            label12.Location = new Point(767, 7);
            label12.Name = "label12";
            label12.Size = new Size(412, 37);
            label12.TabIndex = 53;
            label12.Text = "Al Hamd Knowledge House";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button10);
            panel3.Controls.Add(Search_id);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(search);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(select_exam);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(select_subject);
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
            Search_id.Location = new Point(351, 188);
            Search_id.Margin = new Padding(3, 2, 3, 2);
            Search_id.Multiline = true;
            Search_id.Name = "Search_id";
            Search_id.PlaceholderText = "Search by Student ID..";
            Search_id.Size = new Size(191, 34);
            Search_id.TabIndex = 102;
            // 
            // search
            // 
            search.BackColor = Color.FromArgb(255, 192, 192);
            search.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.Location = new Point(1427, 158);
            search.Margin = new Padding(3, 2, 3, 2);
            search.Name = "search";
            search.Size = new Size(138, 45);
            search.TabIndex = 107;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(389, 155);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 101;
            label3.Text = "Enter ID*";
            // 
            // select_exam
            // 
            select_exam.FormattingEnabled = true;
            select_exam.Location = new Point(716, 199);
            select_exam.Margin = new Padding(3, 2, 3, 2);
            select_exam.Name = "select_exam";
            select_exam.Size = new Size(117, 23);
            select_exam.TabIndex = 109;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(716, 155);
            label7.Name = "label7";
            label7.Size = new Size(126, 25);
            label7.TabIndex = 106;
            label7.Text = "Select Exam*";
            // 
            // select_subject
            // 
            select_subject.FormattingEnabled = true;
            select_subject.Location = new Point(853, 199);
            select_subject.Margin = new Padding(3, 2, 3, 2);
            select_subject.Name = "select_subject";
            select_subject.Size = new Size(117, 23);
            select_subject.TabIndex = 108;
            // 
            // select_class
            // 
            select_class.FormattingEnabled = true;
            select_class.Location = new Point(576, 199);
            select_class.Margin = new Padding(3, 2, 3, 2);
            select_class.Name = "select_class";
            select_class.Size = new Size(117, 23);
            select_class.TabIndex = 104;
            select_class.SelectedIndexChanged += select_class_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(853, 155);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 105;
            label6.Text = "Select Subject*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(572, 155);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 103;
            label5.Text = "Select Class*";
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
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 749);
            panel1.TabIndex = 100;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.ImageIndex = 4;
            button4.ImageList = imageList3;
            button4.Location = new Point(24, 405);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(225, 56);
            button4.TabIndex = 92;
            button4.Text = "Expense Details";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.ImageIndex = 3;
            button8.ImageList = imageList3;
            button8.Location = new Point(24, 594);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(225, 56);
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
            button7.Location = new Point(24, 525);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(225, 56);
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
            button5.Location = new Point(24, 274);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(225, 56);
            button5.TabIndex = 4;
            button5.Text = "  Dashboard";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.ImageIndex = 5;
            button6.ImageList = imageList3;
            button6.Location = new Point(24, 465);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(225, 56);
            button6.TabIndex = 3;
            button6.Text = "   Attendance";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.ImageIndex = 2;
            button9.ImageList = imageList3;
            button9.Location = new Point(24, 334);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(225, 56);
            button9.TabIndex = 1;
            button9.Text = "     Student Details";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Profile_icon;
            pictureBox2.Location = new Point(24, 56);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 192, 192);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(1022, 165);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(138, 45);
            button10.TabIndex = 110;
            button10.Text = "Search";
            button10.UseVisualStyleBackColor = false;
            // 
            // ExamResultP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(exampanel);
            Controls.Add(pnlDropdown);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExamResultP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamResultP";
            WindowState = FormWindowState.Maximized;
            exampanel.ResumeLayout(false);
            pnlDropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button sectionwiseresult;
        private ImageList imageList1;
        private Panel exampanel;
        private Button button2;
        private Button markleave;
        private Button button1;
        private Button markattendance;
        private Panel pnlDropdown;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label12;
        private Button button3;
        private ImageList imageList3;
        private Panel panel1;
        private Button button4;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button6;
        private Button button9;
        private PictureBox pictureBox2;
        private TextBox Search_id;
        private Button search;
        private Label label3;
        private ComboBox select_exam;
        private Label label7;
        private ComboBox select_subject;
        private ComboBox select_class;
        private Label label6;
        private Label label5;
        private Button button10;
    }
}