using Assignment212.ist2ibDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void pATIENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pATIENTSBindingSource.EndEdit();
            this.pATIENTSTableAdapter.Update(this.ist2ibDataSet.PATIENTS);
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            this.pATIENTSTableAdapter.Fill(this.ist2ibDataSet.PATIENTS);
        }

        private void patientIDLabel_Click(object sender, EventArgs e) { }

        // Add patient
        private void button1_Click(object sender, EventArgs e)
        {
            // FIX: use IsNullOrWhiteSpace — catches empty strings, not just a single space
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(cellNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Please complete all fields before continuing.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Auto-generate PatientID: PRN101, PRN102, ...
                string maxId = "PRN100";
                foreach (DataRow row in ist2ibDataSet.PATIENTS.Rows)
                {
                    string id = row["PatientID"].ToString();
                    if (string.Compare(id, maxId) > 0)
                        maxId = id;
                }
                int num = int.Parse(maxId.Substring(3)) + 1;
                string newId = "PRN" + num.ToString("D3");

                pATIENTSTableAdapter.Insert(newId, nameTextBox.Text, cellNoTextBox.Text,
                    emailTextBox.Text, comboBox1.Text, addressTextBox.Text);
                pATIENTSTableAdapter.Fill(ist2ibDataSet.PATIENTS);
                MessageBox.Show("Patient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Delete patient
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show(
                "Are you sure you want to delete this patient record?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Confirmation == DialogResult.Yes)
            {
                string PatientID = ((DataRowView)pATIENTSBindingSource.Current)["PatientID"].ToString();
                pATIENTSTableAdapter.DeleteQuery(PatientID);
                this.pATIENTSTableAdapter.Fill(this.ist2ibDataSet.PATIENTS);
                MessageBox.Show("Patient deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Update patient
        private void button3_Click(object sender, EventArgs e)
        {
            // FIX: success message now correctly says "Patient" not "Department"
            pATIENTSTableAdapter.UpdateQuery1(patientIDTextBox.Text, nameTextBox.Text,
                cellNoTextBox.Text, emailTextBox.Text, comboBox1.Text, addressTextBox.Text);
            MessageBox.Show("Patient updated successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please login in order to book an appointment.");
            Login login = new Login();
            login.Show();
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
    }
}
