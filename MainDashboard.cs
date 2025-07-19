using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin_UI;

//using SchoolManagementSystem;


namespace Database_Project
{
    public partial class MainDashboard : Form
    {
        private string selectedRole = ""; // Store the selected role
        private int currentImageIndex = 0; // To track the current image in the slider
        private readonly Image[] images; // Array to store images for the slider

        public MainDashboard()
        {
            InitializeComponent();

            // Initialize the images array with the images from resources
            images = new Image[]
            {
                Properties.Resources.slider_picture_1, // Replace with the exact image name from resources
                Properties.Resources.slider_pic_2    // Replace with the exact image name from resources
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginPage F3 = new LoginPage("accountant"); // Pass "accountant"
            F3.Show();
            this.Hide();
        }



        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // Set the initial image in the PictureBox (pictureBox2)
            pictureBox2.Image = images[currentImageIndex];

            // Ensure the timer is enabled
            timer1.Enabled = true;
            timer1.Interval = 2000; // Set interval to 2 seconds
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginPage F3 = new LoginPage("admin"); // Pass "admin"
            F3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the image index
            currentImageIndex++;
            if (currentImageIndex >= images.Length)
            {
                currentImageIndex = 0; // Loop back to the first image
            }

            // Update the PictureBox with the new image
            pictureBox2.Image = images[currentImageIndex];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage F3 = new LoginPage("teacher"); // Pass "teacher"
            F3.Show();
            this.Hide();
        }

        private void principal_Click(object sender, EventArgs e)
        {
            LoginPage F3 = new LoginPage("principal"); // Pass "principal"
            F3.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
