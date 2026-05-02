using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class AppointmentDc : Form
    {
        public string FullName { get; }
        public string CellNo { get; }
        public string Doctor { get; }
        public DateTime PrefDate { get; }
        public DateTime PrefTime { get; }
        public string Symptoms { get; }
        public string Gender { get; }
        public AppointmentDc()
        {
            InitializeComponent();
        }
        public AppointmentDc(string fullName, string cellNo, string doctor, DateTime prefDate, DateTime prefTime, string symptoms, string gender)
        {
            FullName = fullName;
            CellNo = cellNo;
            Doctor = doctor;
            PrefDate = prefDate;
            PrefTime = prefTime;
            Symptoms = symptoms;
            Gender = gender;
        }
        private void aPPOINTMENTSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aPPOINTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aPPOINTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);

        }

        private void AppointmentDc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ist2ibDataSet.APPOINTMENTS' table. You can move, or remove it, as needed.
            this.aPPOINTMENTSTableAdapter.Fill(this.ist2ibDataSet.APPOINTMENTS);
            comboBox1.Items.Clear();

            // Add time slots from 8:00 AM to 4:00 PM in 30-minute intervals
            for (DateTime time = DateTime.Today.AddHours(8); time <= DateTime.Today.AddHours(16); time = time.AddMinutes(30))
            {
                comboBox1.Items.Add(time.ToString("hh:mm tt"));
            }
            comboBox1.SelectedIndex = 0;

            int appointmentID = int.Parse(appointmentIDTextBox.Text);
            string patientID = patientIDTextBox.Text;
            string doctorID = doctorIDTextBox.Text;
            DateTime appointmentDate = appointmentDateDateTimePicker.Value.Date;
            TimeSpan appointmentTime = DateTime.Parse(comboBox1.SelectedItem.ToString()).TimeOfDay;
            string status = comboBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (appointmentIDTextBox.Text == " " || patientIDTextBox.Text == " " || doctorIDTextBox.Text == " " || appointmentDateDateTimePicker.Text == " " || comboBox1.Text == " " || comboBox2.Text == " ")
            {
                MessageBox.Show("Please complete all fields before continuing.",
                     "Missing Information", MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
            else
            {
                aPPOINTMENTSBindingSource.MoveLast();
                int currentID = 1;
                if (int.TryParse(appointmentIDTextBox.Text, out int lastID))
                {
                    currentID = lastID + 1;
                }
                // Add new record
                aPPOINTMENTSBindingSource.AddNew();
                // Set the new Appointment ID
                appointmentIDTextBox.Text = currentID.ToString();

                MessageBox.Show("Appointment added successfully!",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Are you sure you want to delete this information?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (Confirmation == DialogResult.Yes)
            {
                int appId = Convert.ToInt32(((DataRowView)aPPOINTMENTSBindingSource.Current)["AppointmentID"]);
                aPPOINTMENTSTableAdapter.DeleteQuery(appId);
                this.aPPOINTMENTSTableAdapter.Fill(this.ist2ibDataSet.APPOINTMENTS);
                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimeSpan appointmentTime;
            try
            {
                DateTime dt = DateTime.Parse(comboBox1.Text); // converts "08:30 AM" correctly
                appointmentTime = dt.TimeOfDay;
            }
            catch
            {
                MessageBox.Show("Invalid time selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // stop if time is invalid
            }

            aPPOINTMENTSBindingSource.EndEdit();
            // Now call UpdateQuery with proper types
            aPPOINTMENTSTableAdapter.UpdateQuery(patientIDTextBox.Text, doctorIDTextBox.Text, appointmentDateDateTimePicker.Value.Date.ToString(), appointmentTime.ToString(), comboBox2.Text, int.Parse(appointmentIDTextBox.Text));

            MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void appointmentIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          Booking_form booking_Form = new Booking_form();   
            booking_Form.ShowDialog();

        }
    }
}
