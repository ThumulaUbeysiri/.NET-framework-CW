namespace EmployeeManagement
{
    partial class AddEmployee
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
            this.panelEmpData = new System.Windows.Forms.Panel();
            this.labelEmpData = new System.Windows.Forms.Label();
            this.dataGridViewEmpData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEmpDep = new System.Windows.Forms.TextBox();
            this.labelDep = new System.Windows.Forms.Label();
            this.pictureBoxEmp = new System.Windows.Forms.PictureBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonEmpAdd = new System.Windows.Forms.Button();
            this.comboBoxEmpPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpGender = new System.Windows.Forms.ComboBox();
            this.textBoxEmpContact = new System.Windows.Forms.TextBox();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.labelEmpPosition = new System.Windows.Forms.Label();
            this.labelempGender = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpContact = new System.Windows.Forms.Label();
            this.panelEmpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmpData
            // 
            this.panelEmpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panelEmpData.Controls.Add(this.labelEmpData);
            this.panelEmpData.Controls.Add(this.dataGridViewEmpData);
            this.panelEmpData.Location = new System.Drawing.Point(12, 12);
            this.panelEmpData.Name = "panelEmpData";
            this.panelEmpData.Size = new System.Drawing.Size(813, 227);
            this.panelEmpData.TabIndex = 0;
            // 
            // labelEmpData
            // 
            this.labelEmpData.AutoSize = true;
            this.labelEmpData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpData.Location = new System.Drawing.Point(24, 10);
            this.labelEmpData.Name = "labelEmpData";
            this.labelEmpData.Size = new System.Drawing.Size(160, 23);
            this.labelEmpData.TabIndex = 1;
            this.labelEmpData.Text = "Employee Data";
            this.labelEmpData.Click += new System.EventHandler(this.labelEmpData_Click);
            // 
            // dataGridViewEmpData
            // 
            this.dataGridViewEmpData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewEmpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewEmpData.Location = new System.Drawing.Point(17, 41);
            this.dataGridViewEmpData.Name = "dataGridViewEmpData";
            this.dataGridViewEmpData.RowHeadersWidth = 51;
            this.dataGridViewEmpData.RowTemplate.Height = 24;
            this.dataGridViewEmpData.Size = new System.Drawing.Size(778, 171);
            this.dataGridViewEmpData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.textBoxEmpDep);
            this.panel2.Controls.Add(this.labelDep);
            this.panel2.Controls.Add(this.pictureBoxEmp);
            this.panel2.Controls.Add(this.buttonClear);
            this.panel2.Controls.Add(this.buttonEmpAdd);
            this.panel2.Controls.Add(this.comboBoxEmpPosition);
            this.panel2.Controls.Add(this.comboBoxEmpGender);
            this.panel2.Controls.Add(this.textBoxEmpContact);
            this.panel2.Controls.Add(this.textBoxEmpName);
            this.panel2.Controls.Add(this.labelEmpPosition);
            this.panel2.Controls.Add(this.labelempGender);
            this.panel2.Controls.Add(this.labelEmpName);
            this.panel2.Controls.Add(this.labelEmpContact);
            this.panel2.Location = new System.Drawing.Point(12, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(813, 267);
            this.panel2.TabIndex = 1;
            // 
            // textBoxEmpDep
            // 
            this.textBoxEmpDep.Location = new System.Drawing.Point(156, 86);
            this.textBoxEmpDep.Name = "textBoxEmpDep";
            this.textBoxEmpDep.Size = new System.Drawing.Size(128, 22);
            this.textBoxEmpDep.TabIndex = 16;
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDep.Location = new System.Drawing.Point(25, 93);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(108, 17);
            this.labelDep.TabIndex = 15;
            this.labelDep.Text = "Department ID:";
            // 
            // pictureBoxEmp
            // 
            this.pictureBoxEmp.Image = global::EmployeeManagement.Properties.Resources.candidates__1_;
            this.pictureBoxEmp.Location = new System.Drawing.Point(618, 123);
            this.pictureBoxEmp.Name = "pictureBoxEmp";
            this.pictureBoxEmp.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxEmp.TabIndex = 14;
            this.pictureBoxEmp.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(106)))), ((int)(((byte)(93)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(187, 193);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(118, 47);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEmpAdd
            // 
            this.buttonEmpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(106)))), ((int)(((byte)(93)))));
            this.buttonEmpAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpAdd.Location = new System.Drawing.Point(28, 193);
            this.buttonEmpAdd.Name = "buttonEmpAdd";
            this.buttonEmpAdd.Size = new System.Drawing.Size(118, 47);
            this.buttonEmpAdd.TabIndex = 10;
            this.buttonEmpAdd.Text = "ADD";
            this.buttonEmpAdd.UseVisualStyleBackColor = false;
            this.buttonEmpAdd.Click += new System.EventHandler(this.buttonEmpAdd_Click);
            // 
            // comboBoxEmpPosition
            // 
            this.comboBoxEmpPosition.FormattingEnabled = true;
            this.comboBoxEmpPosition.Items.AddRange(new object[] {
            "Clerk",
            "Intern",
            "Receptionist",
            "Manager",
            "Supervisor",
            "HR",
            "Executives"});
            this.comboBoxEmpPosition.Location = new System.Drawing.Point(667, 23);
            this.comboBoxEmpPosition.Name = "comboBoxEmpPosition";
            this.comboBoxEmpPosition.Size = new System.Drawing.Size(128, 24);
            this.comboBoxEmpPosition.TabIndex = 9;
            // 
            // comboBoxEmpGender
            // 
            this.comboBoxEmpGender.FormattingEnabled = true;
            this.comboBoxEmpGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxEmpGender.Location = new System.Drawing.Point(422, 84);
            this.comboBoxEmpGender.Name = "comboBoxEmpGender";
            this.comboBoxEmpGender.Size = new System.Drawing.Size(130, 24);
            this.comboBoxEmpGender.TabIndex = 8;
            // 
            // textBoxEmpContact
            // 
            this.textBoxEmpContact.Location = new System.Drawing.Point(422, 23);
            this.textBoxEmpContact.Name = "textBoxEmpContact";
            this.textBoxEmpContact.Size = new System.Drawing.Size(128, 22);
            this.textBoxEmpContact.TabIndex = 7;
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(156, 28);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(128, 22);
            this.textBoxEmpName.TabIndex = 6;
            // 
            // labelEmpPosition
            // 
            this.labelEmpPosition.AutoSize = true;
            this.labelEmpPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpPosition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpPosition.Location = new System.Drawing.Point(574, 28);
            this.labelEmpPosition.Name = "labelEmpPosition";
            this.labelEmpPosition.Size = new System.Drawing.Size(68, 20);
            this.labelEmpPosition.TabIndex = 4;
            this.labelEmpPosition.Text = "Position:";
            // 
            // labelempGender
            // 
            this.labelempGender.AutoSize = true;
            this.labelempGender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelempGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelempGender.Location = new System.Drawing.Point(304, 86);
            this.labelempGender.Name = "labelempGender";
            this.labelempGender.Size = new System.Drawing.Size(70, 20);
            this.labelempGender.TabIndex = 3;
            this.labelempGender.Text = "Gender:";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpName.Location = new System.Drawing.Point(24, 28);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(83, 20);
            this.labelEmpName.TabIndex = 2;
            this.labelEmpName.Text = "Full Name:";
            // 
            // labelEmpContact
            // 
            this.labelEmpContact.AutoSize = true;
            this.labelEmpContact.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpContact.Location = new System.Drawing.Point(304, 28);
            this.labelEmpContact.Name = "labelEmpContact";
            this.labelEmpContact.Size = new System.Drawing.Size(99, 20);
            this.labelEmpContact.TabIndex = 1;
            this.labelEmpContact.Text = "Contact No:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelEmpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.panelEmpData.ResumeLayout(false);
            this.panelEmpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmpData;
        private System.Windows.Forms.DataGridView dataGridViewEmpData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEmpData;
        private System.Windows.Forms.TextBox textBoxEmpContact;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.Label labelEmpPosition;
        private System.Windows.Forms.Label labelempGender;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpContact;
        private System.Windows.Forms.ComboBox comboBoxEmpPosition;
        private System.Windows.Forms.ComboBox comboBoxEmpGender;
        private System.Windows.Forms.Button buttonEmpAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxEmp;
        private System.Windows.Forms.TextBox textBoxEmpDep;
        private System.Windows.Forms.Label labelDep;
    }
}