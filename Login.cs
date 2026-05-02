using Assignment212.ist2ibDataSetTableAdapters;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment212
{
    // FIX: removed nested Session class — now lives in Session.cs (single shared source)
    public partial class Login : Form
    {
        bool isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lOGIN_USERSTableAdapter.Fill(this.ist2ibDataSet.LOGIN_USERS);
            textBox2.PasswordChar = '*';
            pictureBox1.Image = Properties.Resources.eye_closed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // FIX: also validate that username is not empty before trying login
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Please enter your username.";
                return;
            }

            label6.Text = " ";
            int uppercase = 0, lowercase = 0, number = 0, specialChar = 0;
            string passwordinput = textBox2.Text;
            string message = "";

            // Password validation
            if (passwordinput.Length < 8)
            {
                message += "Password should be at least 8 characters long" + Environment.NewLine;
            }
            else if (passwordinput.Length > 50)
            {
                message += "Password should be less than 50 characters" + Environment.NewLine;
            }
            else
            {
                foreach (char c in passwordinput)
                {
                    if (char.IsUpper(c)) uppercase++;
                    else if (char.IsLower(c)) lowercase++;
                    else if (char.IsDigit(c)) number++;
                    else if (char.IsPunctuation(c) || char.IsSymbol(c)) specialChar++;
                }
                if (uppercase == 0)    message += "Password should contain at least 1 uppercase letter" + Environment.NewLine;
                if (lowercase == 0)    message += "Password should contain at least 1 lowercase letter" + Environment.NewLine;
                if (number == 0)       message += "Password should contain at least 1 number" + Environment.NewLine;
                if (specialChar == 0)  message += "Password should contain at least 1 special character" + Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(message))
            {
                label6.ForeColor = Color.Red;
                label6.Text = message;
                return;
            }

            // Check login against database
            lOGIN_USERSTableAdapter.FillBy(ist2ibDataSet.LOGIN_USERS, textBox1.Text, textBox2.Text);

            if (ist2ibDataSet.LOGIN_USERS.Rows.Count > 0)
            {
                DataRow user = ist2ibDataSet.LOGIN_USERS.Rows[0];
                string role = user["Position"].ToString();

                // FIX: populate the shared Session so other forms can use it
                Session.Username   = textBox1.Text;
                Session.Position   = role;

                // Store doctor name if the user is a doctor
                if (user.Table.Columns.Contains("DoctorName"))
                    Session.DoctorName = user["DoctorName"].ToString();

                if (role == "Doctor")
                {
                    Doctor_Home doctor_Home = new Doctor_Home();
                    doctor_Home.ShowDialog();
                }
                else if (role == "Admin")
                {
                    HomePage main = new HomePage();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Position not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear button
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        // Exit button
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Sign up / new user button
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please SignUp to create a profile", "Sign Up Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            label3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        // Proceed button (radio button route)
        private void button6_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please indicate that you are an ADMINISTRATOR or DOCTOR", "CAUTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (radioButton1.Checked)
            {
                Patient patient = new Patient();
                patient.Show();
            }
            else
            {
                Doctor doctor = new Doctor();
                doctor.Show();
            }
        }

        // Check username button
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Focus();
                MessageBox.Show("Please fill in the Username and log in", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                textBox2.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.eye_closed;
                isPasswordVisible = false;
            }
            else
            {
                textBox2.PasswordChar = '\0';
                pictureBox1.Image = Properties.Resources.image_password;
                isPasswordVisible = true;
            }
        }
    }
}
