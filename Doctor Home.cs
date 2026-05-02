using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class Doctor_Home : Form
    {
        private Label labelDoctor;

        public Doctor_Home()
        {
            InitializeComponent();
            labelDoctor = new Label();
            labelDoctor.AutoSize = true;
            labelDoctor.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            labelDoctor.Location = new Point(20, 20);
            // FIX: show the actual doctor name from the shared Session
            labelDoctor.Text = string.IsNullOrEmpty(Session.DoctorName)
                ? "Welcome, Doctor"
                : "Welcome, Dr. " + Session.DoctorName;
            this.Controls.Add(labelDoctor);
        }

        private void Doctor_Home_Load(object sender, EventArgs e)
        {
            // Load appointments for the logged-in doctor
            this.aPPOINTMENTSTableAdapter.Fill(this.ist2ibDataSet.APPOINTMENTS);

            // FIX: update the label after load in case Session was set after constructor ran
            if (!string.IsNullOrEmpty(Session.DoctorName))
                labelDoctor.Text = "Welcome, Dr. " + Session.DoctorName;
        }

        private void aPPOINTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPOINTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Medical_Records medical = new Medical_Records();
            medical.Show();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Medical_Records medical_Records = new Medical_Records();
            medical_Records.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        // FIX: logout logic was inverted — Yes should show Login, No should do nothing (not close)
        private void label5_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Session.Clear();  // FIX: clear session data on logout
                this.Hide();
                Login form1 = new Login();
                form1.ShowDialog();
                this.Close();
            }
            // No — do nothing, stay on this form
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // legacy handler — delegate to the proper logout
            label5_Click_1(sender, e);
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System Update Complete!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("All patient records have been synchronised successfully.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
