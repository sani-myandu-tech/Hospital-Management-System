namespace Assignment212
{
    partial class AppointmentDc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label appointmentIDLabel;
            System.Windows.Forms.Label patientIDLabel;
            System.Windows.Forms.Label doctorIDLabel;
            System.Windows.Forms.Label appointmentDateLabel;
            System.Windows.Forms.Label appointmentTimeLabel;
            System.Windows.Forms.Label statusLabel;
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ist2ibDataSet = new Assignment212.ist2ibDataSet();
            this.aPPOINTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPOINTMENTSTableAdapter = new Assignment212.ist2ibDataSetTableAdapters.APPOINTMENTSTableAdapter();
            this.tableAdapterManager = new Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager();
            this.aPPOINTMENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.patientIDTextBox = new System.Windows.Forms.TextBox();
            this.doctorIDTextBox = new System.Windows.Forms.TextBox();
            this.appointmentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            appointmentIDLabel = new System.Windows.Forms.Label();
            patientIDLabel = new System.Windows.Forms.Label();
            doctorIDLabel = new System.Windows.Forms.Label();
            appointmentDateLabel = new System.Windows.Forms.Label();
            appointmentTimeLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentIDLabel
            // 
            appointmentIDLabel.AutoSize = true;
            appointmentIDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentIDLabel.Location = new System.Drawing.Point(4, 63);
            appointmentIDLabel.Name = "appointmentIDLabel";
            appointmentIDLabel.Size = new System.Drawing.Size(112, 17);
            appointmentIDLabel.TabIndex = 48;
            appointmentIDLabel.Text = "Appointment ID:";
            appointmentIDLabel.Click += new System.EventHandler(this.appointmentIDLabel_Click);
            // 
            // patientIDLabel
            // 
            patientIDLabel.AutoSize = true;
            patientIDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patientIDLabel.Location = new System.Drawing.Point(122, 63);
            patientIDLabel.Name = "patientIDLabel";
            patientIDLabel.Size = new System.Drawing.Size(74, 17);
            patientIDLabel.TabIndex = 50;
            patientIDLabel.Text = "Patient ID:";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorIDLabel.Location = new System.Drawing.Point(213, 59);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new System.Drawing.Size(72, 17);
            doctorIDLabel.TabIndex = 52;
            doctorIDLabel.Text = "Doctor ID:";
            // 
            // appointmentDateLabel
            // 
            appointmentDateLabel.AutoSize = true;
            appointmentDateLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentDateLabel.Location = new System.Drawing.Point(302, 59);
            appointmentDateLabel.Name = "appointmentDateLabel";
            appointmentDateLabel.Size = new System.Drawing.Size(127, 17);
            appointmentDateLabel.TabIndex = 54;
            appointmentDateLabel.Text = "Appointment Date:";
            // 
            // appointmentTimeLabel
            // 
            appointmentTimeLabel.AutoSize = true;
            appointmentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appointmentTimeLabel.Location = new System.Drawing.Point(493, 59);
            appointmentTimeLabel.Name = "appointmentTimeLabel";
            appointmentTimeLabel.Size = new System.Drawing.Size(129, 17);
            appointmentTimeLabel.TabIndex = 56;
            appointmentTimeLabel.Text = "Appointment Time:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(639, 58);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(50, 17);
            statusLabel.TabIndex = 58;
            statusLabel.Text = "Status:";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(642, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 37);
            this.button4.TabIndex = 47;
            this.button4.Text = "Book Appointment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.01205F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.49398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(169, 267);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 43);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 37);
            this.button3.TabIndex = 26;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 37);
            this.button2.TabIndex = 25;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Appointments";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Assignment212.Properties.Resources.diagnostics;
            this.pictureBox5.Location = new System.Drawing.Point(7, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // ist2ibDataSet
            // 
            this.ist2ibDataSet.DataSetName = "ist2ibDataSet";
            this.ist2ibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTSBindingSource
            // 
            this.aPPOINTMENTSBindingSource.DataMember = "APPOINTMENTS";
            this.aPPOINTMENTSBindingSource.DataSource = this.ist2ibDataSet;
            // 
            // aPPOINTMENTSTableAdapter
            // 
            this.aPPOINTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPOINTMENTSTableAdapter = this.aPPOINTMENTSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentDoctorTableAdapter = null;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = null;
            this.tableAdapterManager.DOCTORTableAdapter = null;
            this.tableAdapterManager.LOGIN_USERSTableAdapter = null;
            this.tableAdapterManager.MEDICAL_RECORDSTableAdapter = null;
            this.tableAdapterManager.PATIENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aPPOINTMENTSDataGridView
            // 
            this.aPPOINTMENTSDataGridView.AutoGenerateColumns = false;
            this.aPPOINTMENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aPPOINTMENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.aPPOINTMENTSDataGridView.DataSource = this.aPPOINTMENTSBindingSource;
            this.aPPOINTMENTSDataGridView.Location = new System.Drawing.Point(25, 117);
            this.aPPOINTMENTSDataGridView.Name = "aPPOINTMENTSDataGridView";
            this.aPPOINTMENTSDataGridView.Size = new System.Drawing.Size(664, 132);
            this.aPPOINTMENTSDataGridView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AppointmentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DoctorID";
            this.dataGridViewTextBoxColumn3.HeaderText = "DoctorID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AppointmentDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "AppointmentDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AppointmentTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "AppointmentTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPOINTMENTSBindingSource, "AppointmentID", true));
            this.appointmentIDTextBox.Location = new System.Drawing.Point(7, 79);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.ReadOnly = true;
            this.appointmentIDTextBox.Size = new System.Drawing.Size(97, 20);
            this.appointmentIDTextBox.TabIndex = 49;
            // 
            // patientIDTextBox
            // 
            this.patientIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPOINTMENTSBindingSource, "PatientID", true));
            this.patientIDTextBox.Location = new System.Drawing.Point(122, 80);
            this.patientIDTextBox.Name = "patientIDTextBox";
            this.patientIDTextBox.Size = new System.Drawing.Size(79, 20);
            this.patientIDTextBox.TabIndex = 51;
            // 
            // doctorIDTextBox
            // 
            this.doctorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aPPOINTMENTSBindingSource, "DoctorID", true));
            this.doctorIDTextBox.Location = new System.Drawing.Point(208, 80);
            this.doctorIDTextBox.Name = "doctorIDTextBox";
            this.doctorIDTextBox.Size = new System.Drawing.Size(77, 20);
            this.doctorIDTextBox.TabIndex = 53;
            // 
            // appointmentDateDateTimePicker
            // 
            this.appointmentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aPPOINTMENTSBindingSource, "AppointmentDate", true));
            this.appointmentDateDateTimePicker.Location = new System.Drawing.Point(291, 80);
            this.appointmentDateDateTimePicker.Name = "appointmentDateDateTimePicker";
            this.appointmentDateDateTimePicker.Size = new System.Drawing.Size(190, 20);
            this.appointmentDateDateTimePicker.TabIndex = 55;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(496, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pending",
            "Cancelled",
            "Completed"});
            this.comboBox2.Location = new System.Drawing.Point(642, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 21);
            this.comboBox2.TabIndex = 60;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(754, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 22);
            this.button5.TabIndex = 61;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AppointmentDc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(appointmentIDLabel);
            this.Controls.Add(this.appointmentIDTextBox);
            this.Controls.Add(patientIDLabel);
            this.Controls.Add(this.patientIDTextBox);
            this.Controls.Add(doctorIDLabel);
            this.Controls.Add(this.doctorIDTextBox);
            this.Controls.Add(appointmentDateLabel);
            this.Controls.Add(this.appointmentDateDateTimePicker);
            this.Controls.Add(appointmentTimeLabel);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.aPPOINTMENTSDataGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Name = "AppointmentDc";
            this.Text = "AppointmentDc";
            this.Load += new System.EventHandler(this.AppointmentDc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ist2ibDataSet ist2ibDataSet;
        private System.Windows.Forms.BindingSource aPPOINTMENTSBindingSource;
        private ist2ibDataSetTableAdapters.APPOINTMENTSTableAdapter aPPOINTMENTSTableAdapter;
        private ist2ibDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView aPPOINTMENTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox appointmentIDTextBox;
        private System.Windows.Forms.TextBox patientIDTextBox;
        private System.Windows.Forms.TextBox doctorIDTextBox;
        private System.Windows.Forms.DateTimePicker appointmentDateDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
    }
}