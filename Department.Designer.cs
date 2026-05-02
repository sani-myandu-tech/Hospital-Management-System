namespace Assignment212
{
    partial class Department
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
            System.Windows.Forms.Label departmentIDLabel;
            System.Windows.Forms.Label departmentNameLabel;
            System.Windows.Forms.Label departmentHeadLabel;
            System.Windows.Forms.Label doctorIDLabel;
            this.label4 = new System.Windows.Forms.Label();
            this.ist2ibDataSet = new Assignment212.ist2ibDataSet();
            this.dEPARTMENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTSTableAdapter = new Assignment212.ist2ibDataSetTableAdapters.DEPARTMENTSTableAdapter();
            this.tableAdapterManager = new Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager();
            this.departmentIDTextBox = new System.Windows.Forms.TextBox();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentHeadTextBox = new System.Windows.Forms.TextBox();
            this.doctorIDTextBox = new System.Windows.Forms.TextBox();
            this.dEPARTMENTSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            departmentIDLabel = new System.Windows.Forms.Label();
            departmentNameLabel = new System.Windows.Forms.Label();
            departmentHeadLabel = new System.Windows.Forms.Label();
            doctorIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentIDLabel
            // 
            departmentIDLabel.AutoSize = true;
            departmentIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentIDLabel.Location = new System.Drawing.Point(8, 96);
            departmentIDLabel.Name = "departmentIDLabel";
            departmentIDLabel.Size = new System.Drawing.Size(127, 21);
            departmentIDLabel.TabIndex = 10;
            departmentIDLabel.Text = "Department ID:";
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentNameLabel.Location = new System.Drawing.Point(160, 96);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new System.Drawing.Size(156, 21);
            departmentNameLabel.TabIndex = 12;
            departmentNameLabel.Text = "Department Name:";
            departmentNameLabel.Click += new System.EventHandler(this.departmentNameLabel_Click);
            // 
            // departmentHeadLabel
            // 
            departmentHeadLabel.AutoSize = true;
            departmentHeadLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentHeadLabel.Location = new System.Drawing.Point(331, 96);
            departmentHeadLabel.Name = "departmentHeadLabel";
            departmentHeadLabel.Size = new System.Drawing.Size(150, 21);
            departmentHeadLabel.TabIndex = 14;
            departmentHeadLabel.Text = "Department Head:";
            // 
            // doctorIDLabel
            // 
            doctorIDLabel.AutoSize = true;
            doctorIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctorIDLabel.Location = new System.Drawing.Point(501, 96);
            doctorIDLabel.Name = "doctorIDLabel";
            doctorIDLabel.Size = new System.Drawing.Size(87, 21);
            doctorIDLabel.TabIndex = 16;
            doctorIDLabel.Text = "Doctor ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Departments";
            // 
            // ist2ibDataSet
            // 
            this.ist2ibDataSet.DataSetName = "ist2ibDataSet";
            this.ist2ibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPARTMENTSBindingSource
            // 
            this.dEPARTMENTSBindingSource.DataMember = "DEPARTMENTS";
            this.dEPARTMENTSBindingSource.DataSource = this.ist2ibDataSet;
            // 
            // dEPARTMENTSTableAdapter
            // 
            this.dEPARTMENTSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.APPOINTMENTSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentDoctorTableAdapter = null;
            this.tableAdapterManager.DEPARTMENTSTableAdapter = this.dEPARTMENTSTableAdapter;
            this.tableAdapterManager.DOCTORTableAdapter = null;
            this.tableAdapterManager.LOGIN_USERSTableAdapter = null;
            this.tableAdapterManager.MEDICAL_RECORDSTableAdapter = null;
            this.tableAdapterManager.PATIENTSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Assignment212.ist2ibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departmentIDTextBox
            // 
            this.departmentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "DepartmentID", true));
            this.departmentIDTextBox.Location = new System.Drawing.Point(12, 123);
            this.departmentIDTextBox.Name = "departmentIDTextBox";
            this.departmentIDTextBox.ReadOnly = true;
            this.departmentIDTextBox.Size = new System.Drawing.Size(124, 20);
            this.departmentIDTextBox.TabIndex = 11;
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "DepartmentName", true));
            this.departmentNameTextBox.Location = new System.Drawing.Point(167, 123);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.departmentNameTextBox.TabIndex = 13;
            // 
            // departmentHeadTextBox
            // 
            this.departmentHeadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "DepartmentHead", true));
            this.departmentHeadTextBox.Location = new System.Drawing.Point(335, 123);
            this.departmentHeadTextBox.Name = "departmentHeadTextBox";
            this.departmentHeadTextBox.Size = new System.Drawing.Size(146, 20);
            this.departmentHeadTextBox.TabIndex = 15;
            // 
            // doctorIDTextBox
            // 
            this.doctorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dEPARTMENTSBindingSource, "DoctorID", true));
            this.doctorIDTextBox.Location = new System.Drawing.Point(505, 123);
            this.doctorIDTextBox.Name = "doctorIDTextBox";
            this.doctorIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorIDTextBox.TabIndex = 17;
            // 
            // dEPARTMENTSDataGridView
            // 
            this.dEPARTMENTSDataGridView.AutoGenerateColumns = false;
            this.dEPARTMENTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dEPARTMENTSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dEPARTMENTSDataGridView.DataSource = this.dEPARTMENTSBindingSource;
            this.dEPARTMENTSDataGridView.Location = new System.Drawing.Point(66, 167);
            this.dEPARTMENTSDataGridView.Name = "dEPARTMENTSDataGridView";
            this.dEPARTMENTSDataGridView.Size = new System.Drawing.Size(522, 146);
            this.dEPARTMENTSDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DepartmentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DepartmentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DepartmentName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepartmentHead";
            this.dataGridViewTextBoxColumn3.HeaderText = "DepartmentHead";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoctorID";
            this.dataGridViewTextBoxColumn4.HeaderText = "DoctorID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(110, 333);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 43);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 37);
            this.button3.TabIndex = 26;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 3);
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
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Assignment212.Properties.Resources.ministry_of_health;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(677, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 22);
            this.button4.TabIndex = 29;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 394);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dEPARTMENTSDataGridView);
            this.Controls.Add(departmentIDLabel);
            this.Controls.Add(this.departmentIDTextBox);
            this.Controls.Add(departmentNameLabel);
            this.Controls.Add(this.departmentNameTextBox);
            this.Controls.Add(departmentHeadLabel);
            this.Controls.Add(this.departmentHeadTextBox);
            this.Controls.Add(doctorIDLabel);
            this.Controls.Add(this.doctorIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ist2ibDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTSDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private ist2ibDataSet ist2ibDataSet;
        private System.Windows.Forms.BindingSource dEPARTMENTSBindingSource;
        private ist2ibDataSetTableAdapters.DEPARTMENTSTableAdapter dEPARTMENTSTableAdapter;
        private ist2ibDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox departmentIDTextBox;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.TextBox departmentHeadTextBox;
        private System.Windows.Forms.TextBox doctorIDTextBox;
        private System.Windows.Forms.DataGridView dEPARTMENTSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}