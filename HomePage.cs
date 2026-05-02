using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class HomePage : Form
    {
        PictureBox[] slideBoxes;
        int currentIndex = 0;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Slideshow setup
            slideBoxes = new PictureBox[]
                { pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13 };

            for (int i = 0; i < slideBoxes.Length; i++)
                slideBoxes[i].Visible = (i == 0);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            slideBoxes[currentIndex].Visible = false;
            currentIndex = (currentIndex + 1) % slideBoxes.Length;
            slideBoxes[currentIndex].Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            AppointmentDc appointment = new AppointmentDc();
            appointment.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Medical_Records medical_Records = new Medical_Records();
            medical_Records.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        // FIX: logout logic was inverted — Yes must show Login+close HomePage, No must do nothing
        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.Clear();   // FIX: clear session on logout
                this.Hide();
                Login form1 = new Login();
                form1.ShowDialog();
                this.Close();
            }
            // No — do nothing, stay on this form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void pictureBox5_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox13_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}
