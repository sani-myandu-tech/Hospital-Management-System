using Assignment212.ist2ibDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment212
{
    public partial class Medical_Records : Form
    {
        public Medical_Records()
        {
            InitializeComponent();
        }

        private void mEDICAL_RECORDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICAL_RECORDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);
        }

        private void mEDICAL_RECORDSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mEDICAL_RECORDSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet);
        }

        private void Medical_Records_Load(object sender, EventArgs e)
        {
            this.mEDICAL_RECORDSTableAdapter.Fill(this.ist2ibDataSet.MEDICAL_RECORDS);
        }

        private void recordIDTextBox_TextChanged(object sender, EventArgs e) { }

        // Add medical record
        private void button1_Click(object sender, EventArgs e)
        {
            // FIX: use IsNullOrWhiteSpace for all field checks
            if (string.IsNullOrWhiteSpace(patientIDTextBox.Text) ||
                string.IsNullOrWhiteSpace(doctorIDTextBox.Text))
            {
                MessageBox.Show("Please complete all fields before continuing.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // FIX: was reading "DoctorID" column to generate RecordID — now reads "RecordID"
                string maxId = "R001";
                foreach (DataRow row in ist2ibDataSet.MEDICAL_RECORDS.Rows)
                {
                    string id = row["RecordID"].ToString();   // <-- corrected column name
                    if (string.Compare(id, maxId) > 0)
                        maxId = id;
                }
                int num = int.Parse(maxId.Substring(1)) + 1;
                string newId = "R" + num.ToString("D3");

                mEDICAL_RECORDSTableAdapter.Insert(newId, patientIDTextBox.Text,
                    doctorIDTextBox.Text, dateRecordDateTimePicker.Value);
                mEDICAL_RECORDSTableAdapter.Fill(ist2ibDataSet.MEDICAL_RECORDS);
                MessageBox.Show("Medical record added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Delete medical record
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Confirmation == DialogResult.Yes)
            {
                mEDICAL_RECORDSBindingSource.RemoveCurrent();
                MessageBox.Show("Medical record deleted successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // FIX: moved MessageBox inside the if-block — it no longer shows when user clicks No
        }

        // Update medical record
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Changes?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mEDICAL_RECORDSTableAdapter.UpdateQuery(
                    recordIDTextBox.Text,
                    patientIDTextBox.Text,
                    doctorIDTextBox.Text,
                    dateRecordDateTimePicker.Value.ToString("yyyy-MM-dd"));
                // FIX: success message now correctly says "Medical record" not "Department"
                MessageBox.Show("Medical record updated successfully!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
