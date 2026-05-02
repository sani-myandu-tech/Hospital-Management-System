using Assignment212.ist2ibDataSetTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment212
{
    // NOTE: Session class has been moved to Session.cs — no duplicate here.
    public partial class Appointment : Form
    {
        public string FullName { get; }
        public string CellNo   { get; }
        public string Doctor   { get; }
        public DateTime PrefDate { get; }
        public DateTime PrefTime { get; }
        public string Symptoms { get; }
        public string Gender   { get; }

        public Appointment()
        {
            InitializeComponent();
        }

        public Appointment(string fullName, string cellNo, string doctor,
            DateTime prefDate, DateTime prefTime, string symptoms, string gender)
        {
            FullName   = fullName;
            CellNo     = cellNo;
            Doctor     = doctor;
            PrefDate   = prefDate;
            PrefTime   = prefTime;
            Symptoms   = symptoms;
            Gender     = gender;
        }

        private void aPPOINTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPOINTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // Load appointments from the database
            this.aPPOINTMENTSTableAdapter.Fill(this.ist2ibDataSet.APPOINTMENTS);

            comboBox1.Items.Clear();
            // Add time slots from 8:00 AM to 4:00 PM in 30-minute intervals
            for (DateTime time = DateTime.Today.AddHours(8); time <= DateTime.Today.AddHours(16); time = time.AddMinutes(30))
            {
                comboBox1.Items.Add(time.ToString("hh:mm tt"));
            }
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;

            // FIX: removed the int.Parse(appointmentIDTextBox.Text) lines that crashed at load
            // because the textbox is empty when the form first opens.
        }

        // Add appointment
        private void button1_Click(object sender, EventArgs e)
        {
            // FIX: use IsNullOrWhiteSpace — catches empty strings, not just a single space
            if (string.IsNullOrWhiteSpace(patientIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(doctorIDTextBox.Text)  ||
                string.IsNullOrWhiteSpace(comboBox1.Text)        ||
                string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Please complete all fields before continuing.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                aPPOINTMENTSBindingSource.MoveLast();
                int currentID = 1;
                if (int.TryParse(appointmentIDTextBox.Text, out int lastID))
                    currentID = lastID + 1;

                aPPOINTMENTSBindingSource.AddNew();
                appointmentIDTextBox.Text = currentID.ToString();

                MessageBox.Show("Appointment added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding appointment: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete appointment
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Confirmation == DialogResult.Yes)
            {
                try
                {
                    int appId = Convert.ToInt32(((DataRowView)aPPOINTMENTSBindingSource.Current)["AppointmentID"]);
                    aPPOINTMENTSTableAdapter.DeleteQuery(appId);
                    this.aPPOINTMENTSTableAdapter.Fill(this.ist2ibDataSet.APPOINTMENTS);
                    MessageBox.Show("Appointment deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Update appointment
        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan appointmentTime;
            try
            {
                DateTime dt = DateTime.Parse(comboBox1.Text);
                appointmentTime = dt.TimeOfDay;
            }
            catch
            {
                MessageBox.Show("Invalid time selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                aPPOINTMENTSBindingSource.EndEdit();
                aPPOINTMENTSTableAdapter.UpdateQuery(
                    patientIDTextBox.Text,
                    doctorIDTextBox.Text,
                    appointmentDateDateTimePicker.Value.Date.ToString(),
                    appointmentTime.ToString(),
                    comboBox2.Text,
                    int.Parse(appointmentIDTextBox.Text));

                MessageBox.Show("Appointment updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Open booking form
        private void button4_Click(object sender, EventArgs e)
        {
            Booking_form booking_Form = new Booking_form();
            booking_Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void appointmentDateDateTimePicker_ValueChanged(object sender, EventArgs e) { }
    }
}
