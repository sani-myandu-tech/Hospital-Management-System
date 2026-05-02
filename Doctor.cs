using Assignment212.ist2ibDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment212
{
    // FIX: removed nested Session class — now lives in Session.cs
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void dOCTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // Load all doctor records from the database
            this.dOCTORTableAdapter.Fill(this.ist2ibDataSet.DOCTOR);
        }

        // Add doctor
        private void button1_Click(object sender, EventArgs e)
        {
            // FIX: use IsNullOrWhiteSpace instead of == " " to catch truly empty fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please complete all fields before continuing.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Auto-generate a new unique DoctorID (D002, D003, ...)
                string maxId = "D001";
                foreach (DataRow row in ist2ibDataSet.DOCTOR.Rows)
                {
                    string id = row["DoctorID"].ToString();
                    if (string.Compare(id, maxId) > 0)
                        maxId = id;
                }
                int num = int.Parse(maxId.Substring(1)) + 1;
                string newId = "D" + num.ToString("D3");

                dOCTORTableAdapter.Insert(newId, textBox3.Text, comboBox1.Text, textBox2.Text, textBox4.Text);
                dOCTORTableAdapter.Fill(ist2ibDataSet.DOCTOR);
                MessageBox.Show("Doctor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Delete doctor
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show(
                "Are you sure you want to delete this doctor record?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Confirmation == DialogResult.Yes)
            {
                string doctorID = ((DataRowView)dOCTORBindingSource.Current)["DoctorID"].ToString();
                dOCTORTableAdapter.DeleteQuery(doctorID);
                this.dOCTORTableAdapter.Fill(this.ist2ibDataSet.DOCTOR);
                MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete operation cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Update doctor
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dOCTORBindingSource.EndEdit();
                dOCTORTableAdapter.Update(ist2ibDataSet);
                MessageBox.Show("Changes saved successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dOCTORBindingSource.CancelEdit();
            }
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

        // Search by DoctorID
        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            try
            {
                this.dOCTORTableAdapter.FillBy(this.ist2ibDataSet.DOCTOR, textBox5.Text);
                if (ist2ibDataSet.DOCTOR.Rows.Count == 0)
                    MessageBox.Show("No record found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        // Live search as user types
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dOCTORTableAdapter.FillByName(ist2ibDataSet.DOCTOR, textBox5.Text);
        }
    }
}
