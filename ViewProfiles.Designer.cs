namespace EmployeeManagement
{
    partial class ViewProfiles
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
            this.dataGridViewEmpProfile = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEmpSearch = new System.Windows.Forms.Button();
            this.textBoxEmpDep = new System.Windows.Forms.TextBox();
            this.labelEmpDep = new System.Windows.Forms.Label();
            this.buttonEmpClear = new System.Windows.Forms.Button();
            this.buttonEmpDelete = new System.Windows.Forms.Button();
            this.textBoxEmpSalary = new System.Windows.Forms.TextBox();
            this.textBoxEmpPosition = new System.Windows.Forms.TextBox();
            this.textBoxEmpGender = new System.Windows.Forms.TextBox();
            this.textBoxEmpContact = new System.Windows.Forms.TextBox();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.labelEmpPosition = new System.Windows.Forms.Label();
            this.labelEmpGender = new System.Windows.Forms.Label();
            this.labelEmpSalary = new System.Windows.Forms.Label();
            this.labelEmpContact = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelEmpPro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpProfile)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewEmpProfile);
            this.panel1.Location = new System.Drawing.Point(12, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 154);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewEmpProfile
            // 
            this.dataGridViewEmpProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpProfile.Location = new System.Drawing.Point(7, 4);
            this.dataGridViewEmpProfile.Name = "dataGridViewEmpProfile";
            this.dataGridViewEmpProfile.RowHeadersWidth = 51;
            this.dataGridViewEmpProfile.RowTemplate.Height = 24;
            this.dataGridViewEmpProfile.Size = new System.Drawing.Size(803, 150);
            this.dataGridViewEmpProfile.TabIndex = 0;
            this.dataGridViewEmpProfile.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpProfile_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.buttonEmpSearch);
            this.panel2.Controls.Add(this.textBoxEmpDep);
            this.panel2.Controls.Add(this.labelEmpDep);
            this.panel2.Controls.Add(this.buttonEmpClear);
            this.panel2.Controls.Add(this.buttonEmpDelete);
            this.panel2.Controls.Add(this.textBoxEmpSalary);
            this.panel2.Controls.Add(this.textBoxEmpPosition);
            this.panel2.Controls.Add(this.textBoxEmpGender);
            this.panel2.Controls.Add(this.textBoxEmpContact);
            this.panel2.Controls.Add(this.textBoxEmpName);
            this.panel2.Controls.Add(this.labelEmpPosition);
            this.panel2.Controls.Add(this.labelEmpGender);
            this.panel2.Controls.Add(this.labelEmpSalary);
            this.panel2.Controls.Add(this.labelEmpContact);
            this.panel2.Controls.Add(this.labelEmpName);
            this.panel2.Location = new System.Drawing.Point(265, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 340);
            this.panel2.TabIndex = 1;
            // 
            // buttonEmpSearch
            // 
            this.buttonEmpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(129)))));
            this.buttonEmpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEmpSearch.Location = new System.Drawing.Point(36, 267);
            this.buttonEmpSearch.Name = "buttonEmpSearch";
            this.buttonEmpSearch.Size = new System.Drawing.Size(104, 36);
            this.buttonEmpSearch.TabIndex = 17;
            this.buttonEmpSearch.Text = "SEARCH";
            this.buttonEmpSearch.UseVisualStyleBackColor = false;
            this.buttonEmpSearch.Click += new System.EventHandler(this.buttonEmpSearch_Click);
            // 
            // textBoxEmpDep
            // 
            this.textBoxEmpDep.Location = new System.Drawing.Point(237, 29);
            this.textBoxEmpDep.Name = "textBoxEmpDep";
            this.textBoxEmpDep.Size = new System.Drawing.Size(186, 22);
            this.textBoxEmpDep.TabIndex = 9;
            // 
            // labelEmpDep
            // 
            this.labelEmpDep.AutoSize = true;
            this.labelEmpDep.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpDep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpDep.Location = new System.Drawing.Point(126, 29);
            this.labelEmpDep.Name = "labelEmpDep";
            this.labelEmpDep.Size = new System.Drawing.Size(101, 20);
            this.labelEmpDep.TabIndex = 9;
            this.labelEmpDep.Text = "Department:";
            // 
            // buttonEmpClear
            // 
            this.buttonEmpClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(129)))));
            this.buttonEmpClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEmpClear.Location = new System.Drawing.Point(413, 267);
            this.buttonEmpClear.Name = "buttonEmpClear";
            this.buttonEmpClear.Size = new System.Drawing.Size(104, 36);
            this.buttonEmpClear.TabIndex = 16;
            this.buttonEmpClear.Text = "CLEAR";
            this.buttonEmpClear.UseVisualStyleBackColor = false;
            this.buttonEmpClear.Click += new System.EventHandler(this.buttonEmpClear_Click);
            // 
            // buttonEmpDelete
            // 
            this.buttonEmpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonEmpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpDelete.Location = new System.Drawing.Point(271, 267);
            this.buttonEmpDelete.Name = "buttonEmpDelete";
            this.buttonEmpDelete.Size = new System.Drawing.Size(104, 36);
            this.buttonEmpDelete.TabIndex = 15;
            this.buttonEmpDelete.Text = "DELETE";
            this.buttonEmpDelete.UseVisualStyleBackColor = false;
            this.buttonEmpDelete.Click += new System.EventHandler(this.buttonEmpDelete_Click);
            // 
            // textBoxEmpSalary
            // 
            this.textBoxEmpSalary.Location = new System.Drawing.Point(255, 184);
            this.textBoxEmpSalary.Name = "textBoxEmpSalary";
            this.textBoxEmpSalary.Size = new System.Drawing.Size(137, 22);
            this.textBoxEmpSalary.TabIndex = 13;
            // 
            // textBoxEmpPosition
            // 
            this.textBoxEmpPosition.Location = new System.Drawing.Point(380, 79);
            this.textBoxEmpPosition.Name = "textBoxEmpPosition";
            this.textBoxEmpPosition.Size = new System.Drawing.Size(137, 22);
            this.textBoxEmpPosition.TabIndex = 12;
            // 
            // textBoxEmpGender
            // 
            this.textBoxEmpGender.Location = new System.Drawing.Point(380, 128);
            this.textBoxEmpGender.Name = "textBoxEmpGender";
            this.textBoxEmpGender.Size = new System.Drawing.Size(137, 22);
            this.textBoxEmpGender.TabIndex = 11;
            // 
            // textBoxEmpContact
            // 
            this.textBoxEmpContact.Location = new System.Drawing.Point(130, 126);
            this.textBoxEmpContact.Name = "textBoxEmpContact";
            this.textBoxEmpContact.Size = new System.Drawing.Size(137, 22);
            this.textBoxEmpContact.TabIndex = 10;
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(130, 77);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(137, 22);
            this.textBoxEmpName.TabIndex = 9;
            // 
            // labelEmpPosition
            // 
            this.labelEmpPosition.AutoSize = true;
            this.labelEmpPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpPosition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpPosition.Location = new System.Drawing.Point(293, 79);
            this.labelEmpPosition.Name = "labelEmpPosition";
            this.labelEmpPosition.Size = new System.Drawing.Size(68, 20);
            this.labelEmpPosition.TabIndex = 7;
            this.labelEmpPosition.Text = "Position:";
            // 
            // labelEmpGender
            // 
            this.labelEmpGender.AutoSize = true;
            this.labelEmpGender.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpGender.Location = new System.Drawing.Point(293, 130);
            this.labelEmpGender.Name = "labelEmpGender";
            this.labelEmpGender.Size = new System.Drawing.Size(70, 20);
            this.labelEmpGender.TabIndex = 6;
            this.labelEmpGender.Text = "Gender:";
            // 
            // labelEmpSalary
            // 
            this.labelEmpSalary.AutoSize = true;
            this.labelEmpSalary.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpSalary.Location = new System.Drawing.Point(182, 184);
            this.labelEmpSalary.Name = "labelEmpSalary";
            this.labelEmpSalary.Size = new System.Drawing.Size(56, 20);
            this.labelEmpSalary.TabIndex = 5;
            this.labelEmpSalary.Text = "Salary:";
            // 
            // labelEmpContact
            // 
            this.labelEmpContact.AutoSize = true;
            this.labelEmpContact.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpContact.Location = new System.Drawing.Point(32, 128);
            this.labelEmpContact.Name = "labelEmpContact";
            this.labelEmpContact.Size = new System.Drawing.Size(74, 20);
            this.labelEmpContact.TabIndex = 3;
            this.labelEmpContact.Text = "Contact:";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpName.Location = new System.Drawing.Point(32, 77);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(83, 20);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "Full Name:";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(35, 295);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(186, 22);
            this.textBoxEmpID.TabIndex = 8;
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpID.Location = new System.Drawing.Point(72, 267);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(105, 20);
            this.labelEmpID.TabIndex = 0;
            this.labelEmpID.Text = "Employee ID:";
            this.labelEmpID.Click += new System.EventHandler(this.labelEmpID_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.labelEmpPro);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBoxEmpID);
            this.panel3.Controls.Add(this.labelEmpID);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 340);
            this.panel3.TabIndex = 2;
            // 
            // labelEmpPro
            // 
            this.labelEmpPro.AutoSize = true;
            this.labelEmpPro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpPro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpPro.Location = new System.Drawing.Point(48, 214);
            this.labelEmpPro.Name = "labelEmpPro";
            this.labelEmpPro.Size = new System.Drawing.Size(173, 23);
            this.labelEmpPro.TabIndex = 4;
            this.labelEmpPro.Text = "Employee Profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagement.Properties.Resources.bussiness_man;
            this.pictureBox1.Location = new System.Drawing.Point(49, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ViewProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProfiles";
            this.Text = "ViewProfiles";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpProfile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewEmpProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Label labelEmpPosition;
        private System.Windows.Forms.Label labelEmpGender;
        private System.Windows.Forms.Label labelEmpSalary;
        private System.Windows.Forms.Label labelEmpContact;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.TextBox textBoxEmpSalary;
        private System.Windows.Forms.TextBox textBoxEmpPosition;
        private System.Windows.Forms.TextBox textBoxEmpGender;
        private System.Windows.Forms.TextBox textBoxEmpContact;
        private System.Windows.Forms.Button buttonEmpClear;
        private System.Windows.Forms.Button buttonEmpDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEmpPro;
        private System.Windows.Forms.TextBox textBoxEmpDep;
        private System.Windows.Forms.Label labelEmpDep;
        private System.Windows.Forms.Button buttonEmpSearch;
    }
}