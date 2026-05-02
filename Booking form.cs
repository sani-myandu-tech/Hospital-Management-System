using Assignment212.ist2ibDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Assignment212
{
    public partial class Booking_form : Form
    {
        public Booking_form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;  // prevent null reference
            string selectedProvince = comboBox1.SelectedItem.ToString();

            if (comboBox1.SelectedItem.ToString() == "KWAZULU-NATAL")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Pietermaritzburg");
                comboBox2.Items.Add("Durban");
                comboBox2.Items.Add("Ladysmith");
                comboBox2.Items.Add("Newcastle");
                comboBox2.Items.Add("Estcourt");
            }
            else if (comboBox1.SelectedItem.ToString() == "GAUTENG")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Johannesburg");
                comboBox2.Items.Add("Pretoria");
                comboBox2.Items.Add("Sandton");
                comboBox2.Items.Add("Soweto");
                comboBox2.Items.Add("Randburg");
            }
            else if (comboBox1.SelectedItem.ToString() == "MPUMALANGA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ermelo");
                comboBox2.Items.Add("Volkrust");
                comboBox2.Items.Add("Secunda");
                comboBox2.Items.Add("Mbombela");
                comboBox2.Items.Add("Emalahleni");
            }
            else if (comboBox1.SelectedItem.ToString() == "NORTH WEST")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mahikeng");
                comboBox2.Items.Add("Rustenburg");
                comboBox2.Items.Add("Potchefstroom");
                comboBox2.Items.Add("Klerksdorp");
                comboBox2.Items.Add("Vryburg");
            }
            else if (comboBox1.SelectedItem.ToString() == "FREE STATE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bloemfontein");
                comboBox2.Items.Add("Welkom");
                comboBox2.Items.Add("Sasolburg");
                comboBox2.Items.Add("Kroonstad");
                comboBox2.Items.Add("Bethlehem");
            }
            else if (comboBox1.SelectedItem.ToString() == "LIMPOPO")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Polokwane");
                comboBox2.Items.Add("Tzaneen");
                comboBox2.Items.Add("Bela-Bela");
                comboBox2.Items.Add("Thohoyandou");
                comboBox2.Items.Add("Mokopane");
            }
            else if (comboBox1.SelectedItem.ToString() == "NORTHERN CAPE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Upington");
                comboBox2.Items.Add("Kimberley");
                comboBox2.Items.Add("Springbok");
                comboBox2.Items.Add("Richmond");
                comboBox2.Items.Add("Vanderkloof");
            }
            else if (comboBox1.SelectedItem.ToString() == "WESTERN CAPE")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Cape Town");
                comboBox2.Items.Add("George");
                comboBox2.Items.Add("Stellenbosch");
                comboBox2.Items.Add("Plettenberg Bay");
                comboBox2.Items.Add("Paarl");
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Gqeberha");
                comboBox2.Items.Add("East London");
                comboBox2.Items.Add("Bisho");
                comboBox2.Items.Add("Port Alfred");
                comboBox2.Items.Add("Port Elizabeth");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if any field is empty
            if (textBox1.Text == ""|| maskedTextBox1.Text=="" || comboBox1.Text=="" || comboBox2.Text=="" || comboBox3.Text=="" || textBox3.Text=="")
            {
                MessageBox.Show("Please complete all fields before capturing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Check if details were already captured
            if (listBox1.Items.Count > 0)
            {
                MessageBox.Show("Details have already been captured.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //  Add details only once
            listBox1.Items.Add("Full Names: " + textBox1.Text);
            listBox1.Items.Add("ID Number: " + maskedTextBox1.Text);
            listBox1.Items.Add("Date of Birth:" + maskedTextBox2.Text);
            listBox1.Items.Add("Gender: " + textBox4.Text);
            listBox1.Items.Add("Age: " + textBox5.Text);
            listBox1.Items.Add("Province: " + comboBox1.Text);
            listBox1.Items.Add("City: " + comboBox2.Text);

           

            listBox1.Items.Add("Preferred Date: " + dateTimePicker1.Value.ToShortDateString());
            listBox1.Items.Add("Preferred Doctor: " + comboBox3.Text);
            listBox1.Items.Add("Symptoms: " + textBox3.Text);

            MessageBox.Show("Information captured successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        


        private void button3_Click(object sender, EventArgs e)
        {
           Appointment appointment = new Appointment();
            appointment.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == " " || comboBox1.Text == " " || comboBox2.Text == " " ||
                     dateTimePicker1.Value.ToString() == " " || comboBox3.Text == "")
            {
                // Display a warning message if validation fails
                MessageBox.Show("Please complete all fields before submitting.", "Missing Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }
            else
            {
                // Display a success message when appointment booking is successful
                MessageBox.Show("Appointment booked successfully!",  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
             
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                comboBox3.Text = "";

                listBox1.Items.Clear();


                textBox1.Clear();
               
                textBox3.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                // Reset the DateTimePicker to today's date
                dateTimePicker1.Value = DateTime.Today;
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //maskedTextBox2.Visible = true;
            //label6.Visible= true;
            //radioButton1.Visible = true;
            //radioButton2.Visible= true;
            //radioButton3.Visible= true;
            //button4.Visible= false;

            //string IDnumber = maskedTextBox1.Text;
            //string DOB = IDnumber.Substring(0, 6);
            //maskedTextBox2.Text = DOB.Substring(4, 2) + DOB.Substring(2, 2);

            //int Year = int.Parse(DOB.Substring(0, 2));
            //if ((Year >= 0) && (Year <= 23))
            //{
            //    maskedTextBox2.Text += "200" + Year;
            //}
            //else
            //{
            //    maskedTextBox2.Text += "19" + Year;
            //}

            //int GenderCode = int.Parse(IDnumber[6].ToString());
            //if (GenderCode >= 5)
            //{
            //    radioButton1.Checked = true;

            //}
            //else
            //{
            //    radioButton2.Checked = true;
           // }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Booking_form_Load(object sender, EventArgs e)
        {
       
            // Show both date and time in one DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy      hh:mm tt";

            // Restrict selectable dates (cannot pick past days)
            dateTimePicker1.MinDate = DateTime.Today;   // today is the earliest date
            dateTimePicker1.MaxDate = DateTime.Today.AddMonths(3); // optional: up to 3 months ahead

            // Optional: set default time (e.g., 08:00 AM today)
            dateTimePicker1.Value = DateTime.Today.AddHours(8);
        }

        private void button6_Click(object sender, EventArgs e)
        { // Ask the user where to save
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Appointment Details";
                saveFileDialog.FileName = "AppointmentDetails";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Write ListBox items to file
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            writer.WriteLine("Appointment Details");
                            writer.WriteLine("====================");
                            foreach (var item in listBox1.Items)
                            {
                                writer.WriteLine(item.ToString());
                            }
                        }

                        MessageBox.Show("File saved successfully at: " + saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message);
                    }
                }
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 100; // start position on page
            float leftMargin = e.MarginBounds.Left;
            Font printFont = new Font("Arial", 12);

            // Loop through all items in listBox1
            foreach (var item in listBox1.Items)
            {
                string line = item.ToString();
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos);
                yPos += 25; // move down for next line
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Show a message box asking the user if they really want to exit
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            bool Valid = false;
            int MyYear = 0, MyMonth = 0, MyDate = 0;
            string ThisID = maskedTextBox1.Text.Trim();

            if (ThisID.Length == 13 && long.TryParse(ThisID, out _))
            {
                MyMonth = int.Parse(ThisID.Substring(2, 2));
                if (MyMonth >= 1 && MyMonth <= 12)
                {
                    MyDate = int.Parse(ThisID.Substring(4, 2));
                    if (MyDate >= 1 && MyDate <= 31)
                        Valid = ValidateID(ThisID);
                }
            }

            if (!Valid)
            {
                MessageBox.Show("ID number is not valid", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                maskedTextBox1.Clear();
                maskedTextBox1.Focus();
            }
            else
            {
                // Extract year
                MyYear = int.Parse(ThisID.Substring(0, 2));

                // Determine century (19xx vs 20xx)
                int currentYearTwoDigits = DateTime.Now.Year % 100;
                int fullYear;
                if (MyYear <= currentYearTwoDigits) // e.g. 01-25 = 2001-2025
                    fullYear = 2000 + MyYear;
                else
                    fullYear = 1900 + MyYear;

                // Build DOB
                DateTime dob;
                try
                {
                    dob = new DateTime(fullYear, MyMonth, MyDate);
                }
                catch
                {
                    MessageBox.Show("Invalid date in ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Age calculation
                int Age = DateTime.Today.Year - dob.Year;
                if (DateTime.Today < dob.AddYears(Age)) Age--;

                textBox5.Text = Age.ToString();
                maskedTextBox2.Text = dob.ToString("dd/MM/yyyy");

                // Gender (7th digit)
                textBox4.Text = (int.Parse(ThisID.Substring(6, 1)) >= 5) ? "Male" : "Female";
            }
        }

        private bool ValidateID(string MyId)
        {
            int a = 0;
            string b1 = "", c1;
            int b2 = 0, c2 = 0, d = 0;
            int FinalBit = 0;

            // Sum of odd-position digits (1,3,5,7,9,11)
            for (int J = 0; J <= MyId.Length - 2; J += 2)
                a += int.Parse(MyId.Substring(J, 1));

            // Combine even-position digits (2,4,6,8,10,12)
            for (int J = 1; J <= MyId.Length - 2; J += 2)
                b1 += MyId.Substring(J, 1);

            // Multiply by 2
            b2 = int.Parse(b1) * 2;

            // Sum digits of result
            c1 = b2.ToString();
            for (int J = 0; J < c1.Length; J++)
                c2 += int.Parse(c1.Substring(J, 1));

            // Add odd + even sums
            d = a + c2;

            // Calculate check digit
            FinalBit = (10 - (d % 10)) % 10;  // fix: ensures 0 instead of 10

            // Validate against last digit
            return FinalBit == int.Parse(MyId.Substring(MyId.Length - 1, 1));
        }





        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void inen(object sender, EventArgs e)
        {

        }
    }
}
