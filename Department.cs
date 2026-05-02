using Assignment212.ist2ibDataSetTableAdapters;
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
    public partial class Department : Form
    {
      
        public Department()
        {
            InitializeComponent();
        }

     
        private void dEPARTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();                         
            this.dEPARTMENTSBindingSource.EndEdit();   
            this.tableAdapterManager.UpdateAll(this.ist2ibDataSet); 
        }

     
        private void Department_Load(object sender, EventArgs e)
        {
            // Load data from the DEPARTMENTS table into the dataset when the form loads
            this.dEPARTMENTSTableAdapter.Fill(this.ist2ibDataSet.DEPARTMENTS);
        }

       
        private void departmentNameLabel_Click(object sender, EventArgs e)
        {
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Auto-generate a new DepartmentID (e.g., DP01, DP02, etc.)
                string maxId = "DP01";
                foreach (DataRow row in ist2ibDataSet.DEPARTMENTS.Rows)
                {
                    string id = row["DepartmentID"].ToString();
                    if (string.Compare(id, maxId) > 0)
                        maxId = id;
                }

                // Increment and format the new DepartmentID
                int num = int.Parse(maxId.Substring(2)) + 1;
                string newId = "DP" + num.ToString("D2");

                // Insert a new department record using the TableAdapter
                dEPARTMENTSTableAdapter.Insert(
                    newId,
                    departmentNameTextBox.Text,
                    departmentHeadTextBox.Text,
                    doctorIDTextBox.Text
                );

                // Refresh the dataset to display the new department in the table
                dEPARTMENTSTableAdapter.Fill(ist2ibDataSet.DEPARTMENTS);

                // Inform the user of success
                MessageBox.Show("Department inserted successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show(
                "Are you sure you want to delete this information?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (Confirmation == DialogResult.Yes)
            {
                // Retrieve the selected DepartmentID
                string deptId = ((DataRowView)dEPARTMENTSBindingSource.Current)["DepartmentID"].ToString();

                // Delete the selected record
                dEPARTMENTSTableAdapter.DeleteQuery(deptId);

                // Refresh table to reflect changes
                this.dEPARTMENTSTableAdapter.Fill(this.ist2ibDataSet.DEPARTMENTS);

                MessageBox.Show("Department deleted successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete operation cancelled.",
                                "Cancelled",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            // Update department details using data entered in textboxes
            dEPARTMENTSTableAdapter.UpdateQuery(
                departmentIDTextBox.Text,
                departmentNameTextBox.Text,
                departmentHeadTextBox.Text,
                doctorIDTextBox.Text
            );

            // Notify the user of success
            MessageBox.Show("Department updated successfully!",
                            "Update",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            // Ask user to confirm before exiting
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Close the form if user selects 'Yes'
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
