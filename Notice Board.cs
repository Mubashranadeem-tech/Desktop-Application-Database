using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitializeNoticeDisplay();
            RefreshNoticeDisplay();
        }

        private void InitializeNoticeDisplay()
        {
            Text_panel.AutoScroll = true;
        }
        private void RefreshNoticeDisplay()
        {
            // Clear existing notice controls
            var controlsToRemove = Text_panel.Controls.Cast<Control>()
                .Where(c => c.Tag != null && c.Tag.ToString() == "notice").ToList();

            foreach (Control control in controlsToRemove)
            {
                Text_panel.Controls.Remove(control);
            }

            var notices = NoticeManager.GetAllNotices();

            if (notices.Count == 0)
            {
                return;
            }

            int yPosition = 20;

            foreach (var notice in notices)
            {
                Panel noticePanel = CreateNoticePanel(notice, yPosition);
                Text_panel.Controls.Add(noticePanel);
                yPosition += noticePanel.Height + 15;
            }
        }
        private Panel CreateNoticePanel(Notice notice, int yPosition)
        {
            Panel panel = new Panel();
            panel.Location = new Point(20, yPosition);
            panel.Size = new Size(Text_panel.Width - 60, 120);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Tag = "notice";

            // Title
            Label titleLabel = new Label();
            titleLabel.Text = "📋 " + notice.Title;
            titleLabel.Font = new Font("Arial", 11, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;
            titleLabel.Location = new Point(8, 8);
            titleLabel.Size = new Size(panel.Width - 16, 25);
            panel.Controls.Add(titleLabel);

            // Details
            Label detailsLabel = new Label();
            detailsLabel.Text = "◊ " + notice.Details;
            detailsLabel.Location = new Point(8, 35);
            detailsLabel.Size = new Size(panel.Width - 16, 50);
            detailsLabel.Font = new Font("Arial", 9);
            detailsLabel.ForeColor = Color.Black;
            panel.Controls.Add(detailsLabel);

            // Posted by
            Label footerLabel = new Label();
            footerLabel.Text = $"👤 {notice.PostedBy}";
            footerLabel.Location = new Point(8, 90);
            footerLabel.Size = new Size(200, 20);
            footerLabel.Font = new Font("Arial", 8, FontStyle.Italic);
            footerLabel.ForeColor = Color.DarkGreen;
            panel.Controls.Add(footerLabel);

            // Date
            Label dateLabel = new Label();
            dateLabel.Text = notice.Date.ToString("MMM dd, yyyy");
            dateLabel.Location = new Point(panel.Width - 120, 90);
            dateLabel.Size = new Size(110, 20);
            dateLabel.Font = new Font("Arial", 8);
            dateLabel.ForeColor = Color.Gray;
            dateLabel.TextAlign = ContentAlignment.MiddleRight;
            panel.Controls.Add(dateLabel);

            return panel;
        }
        // t1-Title , t2-Detail , t3-Posted_by , t4 Date , B1, save 
        private void dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Show();
                    ((Form1)form).RefreshNotices(); // Refresh the notices
                    return;
                }
            }

            Form1 dashboard = new Form1();
            dashboard.Show();

        }

        private void noticeboard_Click(object sender, EventArgs e)
        {
            Form2 noticeBoard = new Form2();
            noticeBoard.Show();
            this.Hide();
        }

        private void student_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
        }

        private void teacherdetails_Click(object sender, EventArgs e)
        {
            Form3 studentDetails = new Form3();
            studentDetails.Show();
            this.Hide();
        }

        private void ADDteacher_Click(object sender, EventArgs e)
        {
            Add_Student A1 = new Add_Student();
            A1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 teacherDetails = new Form5();
            teacherDetails.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 addTeacher = new Form6();
            addTeacher.Show();
            this.Hide();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            MainDashboard F3 = new MainDashboard();
            F3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void studentreport_Click(object sender, EventArgs e)
        {
            StudentReportA studentReportA = new StudentReportA();
            studentReportA.Show();
            this.Hide();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            DailyAttendanceA dailyAttendanceA = new DailyAttendanceA();
            dailyAttendanceA.Show();
            this.Hide();
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {


        }

        private void Detail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string title = Title.Text.Trim();
            string details = Detail.Text.Trim();
            string postedBy = Posted_by.Text.Trim();
            DateTime selectedDate;

            // Validate inputs
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Title.Focus();
                return;
            }

            if (string.IsNullOrEmpty(details))
            {
                MessageBox.Show("Please enter details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Detail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(postedBy))
            {
                MessageBox.Show("Please enter who posted this notice.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Posted_by.Focus();
                return;
            }

            // Get date from textBox4 or use current date
            if (!DateTime.TryParse(Date.Text, out selectedDate))
            {
                selectedDate = DateTime.Now;
            }

            // Add notice
            NoticeManager.AddNotice(title, details, postedBy, selectedDate);

            // Clear form
            Title.Clear();
            Detail.Clear();
            Posted_by.Clear();
            Date.Clear();

            // Refresh displays
            RefreshNoticeDisplay();

            // Refresh Form1 notices
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    ((Form1)form).RefreshNotices();
                    break;
                }
            }
            RefreshPrincipalDashboard();

            // Refresh Teacher Dashboard
            RefreshTeacherDashboard();



        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all notices?",
     "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NoticeManager.ClearAllNotices();
                RefreshNoticeDisplay();

                // Refresh Form1 notices
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Form1)
                    {
                        ((Form1)form).RefreshNotices();
                        break;
                    }
                }
                RefreshPrincipalDashboard();
                // Refresh Teacher Dashboard
                RefreshTeacherDashboard();

            }
        }
        private void RefreshPrincipalDashboard()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is PrincipalDashboard principalForm)
                {
                    principalForm.RefreshNotices();
                    break;
                }
            }
        }

        private void RefreshTeacherDashboard()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is TeacherDashboard teacherForm)
                {
                    teacherForm.RefreshNotices();
                }
            }
        }

        private void Text_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

