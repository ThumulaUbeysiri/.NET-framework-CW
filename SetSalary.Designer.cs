namespace EmployeeManagement
{
    partial class SetSalary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewEmpSalary = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxEmpSal = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonGetSalReport = new System.Windows.Forms.Button();
            this.buttonSetSalSearch = new System.Windows.Forms.Button();
            this.buttonClearSal = new System.Windows.Forms.Button();
            this.buttonUpdateSal = new System.Windows.Forms.Button();
            this.textBoxEmpSal = new System.Windows.Forms.TextBox();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.textBoxEmpContact = new System.Windows.Forms.TextBox();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.labelEmpSal = new System.Windows.Forms.Label();
            this.labelEmpContact = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpSalary)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpSal)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewEmpSalary);
            this.panel1.Location = new System.Drawing.Point(423, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 251);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewEmpSalary
            // 
            this.dataGridViewEmpSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpSalary.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmpSalary.Name = "dataGridViewEmpSalary";
            this.dataGridViewEmpSalary.RowHeadersWidth = 51;
            this.dataGridViewEmpSalary.RowTemplate.Height = 24;
            this.dataGridViewEmpSalary.Size = new System.Drawing.Size(396, 245);
            this.dataGridViewEmpSalary.TabIndex = 0;
            this.dataGridViewEmpSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpSalary_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.pictureBoxEmpSal);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 251);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxEmpSal
            // 
            this.pictureBoxEmpSal.Image = global::EmployeeManagement.Properties.Resources.employee_benefit;
            this.pictureBoxEmpSal.Location = new System.Drawing.Point(74, 4);
            this.pictureBoxEmpSal.Name = "pictureBoxEmpSal";
            this.pictureBoxEmpSal.Size = new System.Drawing.Size(252, 245);
            this.pictureBoxEmpSal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmpSal.TabIndex = 0;
            this.pictureBoxEmpSal.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.buttonGetSalReport);
            this.panel3.Controls.Add(this.buttonSetSalSearch);
            this.panel3.Controls.Add(this.buttonClearSal);
            this.panel3.Controls.Add(this.buttonUpdateSal);
            this.panel3.Controls.Add(this.textBoxEmpSal);
            this.panel3.Controls.Add(this.textBoxEmpName);
            this.panel3.Controls.Add(this.textBoxEmpContact);
            this.panel3.Controls.Add(this.textBoxEmpID);
            this.panel3.Controls.Add(this.labelEmpSal);
            this.panel3.Controls.Add(this.labelEmpContact);
            this.panel3.Controls.Add(this.labelEmpName);
            this.panel3.Controls.Add(this.labelEmpID);
            this.panel3.Location = new System.Drawing.Point(12, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 243);
            this.panel3.TabIndex = 2;
            // 
            // buttonGetSalReport
            // 
            this.buttonGetSalReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.buttonGetSalReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetSalReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetSalReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGetSalReport.Location = new System.Drawing.Point(34, 176);
            this.buttonGetSalReport.Name = "buttonGetSalReport";
            this.buttonGetSalReport.Size = new System.Drawing.Size(118, 47);
            this.buttonGetSalReport.TabIndex = 20;
            this.buttonGetSalReport.Text = "REPORT";
            this.buttonGetSalReport.UseVisualStyleBackColor = false;
            this.buttonGetSalReport.Click += new System.EventHandler(this.buttonGetSalReport_Click);
            // 
            // buttonSetSalSearch
            // 
            this.buttonSetSalSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.buttonSetSalSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetSalSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetSalSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSetSalSearch.Location = new System.Drawing.Point(280, 24);
            this.buttonSetSalSearch.Name = "buttonSetSalSearch";
            this.buttonSetSalSearch.Size = new System.Drawing.Size(104, 36);
            this.buttonSetSalSearch.TabIndex = 19;
            this.buttonSetSalSearch.Text = "SEARCH";
            this.buttonSetSalSearch.UseVisualStyleBackColor = false;
            this.buttonSetSalSearch.Click += new System.EventHandler(this.buttonSetSalSearch_Click);
            // 
            // buttonClearSal
            // 
            this.buttonClearSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.buttonClearSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearSal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearSal.Location = new System.Drawing.Point(651, 176);
            this.buttonClearSal.Name = "buttonClearSal";
            this.buttonClearSal.Size = new System.Drawing.Size(118, 47);
            this.buttonClearSal.TabIndex = 10;
            this.buttonClearSal.Text = "CLEAR";
            this.buttonClearSal.UseVisualStyleBackColor = false;
            this.buttonClearSal.Click += new System.EventHandler(this.buttonClearSal_Click);
            // 
            // buttonUpdateSal
            // 
            this.buttonUpdateSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(77)))), ((int)(((byte)(46)))));
            this.buttonUpdateSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateSal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateSal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateSal.Location = new System.Drawing.Point(494, 176);
            this.buttonUpdateSal.Name = "buttonUpdateSal";
            this.buttonUpdateSal.Size = new System.Drawing.Size(118, 47);
            this.buttonUpdateSal.TabIndex = 9;
            this.buttonUpdateSal.Text = "UPDATE";
            this.buttonUpdateSal.UseVisualStyleBackColor = false;
            this.buttonUpdateSal.Click += new System.EventHandler(this.buttonUpdateSal_Click);
            // 
            // textBoxEmpSal
            // 
            this.textBoxEmpSal.Location = new System.Drawing.Point(494, 103);
            this.textBoxEmpSal.Name = "textBoxEmpSal";
            this.textBoxEmpSal.Size = new System.Drawing.Size(215, 22);
            this.textBoxEmpSal.TabIndex = 7;
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(494, 31);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(215, 22);
            this.textBoxEmpName.TabIndex = 6;
            // 
            // textBoxEmpContact
            // 
            this.textBoxEmpContact.Location = new System.Drawing.Point(134, 99);
            this.textBoxEmpContact.Name = "textBoxEmpContact";
            this.textBoxEmpContact.Size = new System.Drawing.Size(215, 22);
            this.textBoxEmpContact.TabIndex = 5;
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(134, 31);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(133, 22);
            this.textBoxEmpID.TabIndex = 4;
            // 
            // labelEmpSal
            // 
            this.labelEmpSal.AutoSize = true;
            this.labelEmpSal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpSal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpSal.Location = new System.Drawing.Point(411, 103);
            this.labelEmpSal.Name = "labelEmpSal";
            this.labelEmpSal.Size = new System.Drawing.Size(52, 18);
            this.labelEmpSal.TabIndex = 3;
            this.labelEmpSal.Text = "Salary:";
            // 
            // labelEmpContact
            // 
            this.labelEmpContact.AutoSize = true;
            this.labelEmpContact.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpContact.Location = new System.Drawing.Point(31, 103);
            this.labelEmpContact.Name = "labelEmpContact";
            this.labelEmpContact.Size = new System.Drawing.Size(86, 18);
            this.labelEmpContact.TabIndex = 2;
            this.labelEmpContact.Text = "Contact No:";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpName.Location = new System.Drawing.Point(411, 31);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(77, 18);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "Full Name:";
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpID.Location = new System.Drawing.Point(31, 31);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(97, 18);
            this.labelEmpID.TabIndex = 0;
            this.labelEmpID.Text = "Employee ID:";
            // 
            // SetSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetSalary";
            this.Text = "SetSalary";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpSalary)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpSal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewEmpSalary;
        private System.Windows.Forms.PictureBox pictureBoxEmpSal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelEmpSal;
        private System.Windows.Forms.Label labelEmpContact;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.TextBox textBoxEmpSal;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.TextBox textBoxEmpContact;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Button buttonClearSal;
        private System.Windows.Forms.Button buttonUpdateSal;
        private System.Windows.Forms.Button buttonSetSalSearch;
        private System.Windows.Forms.Button buttonGetSalReport;
    }
}