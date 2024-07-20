namespace EmployeeManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDepSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDeleteDep = new System.Windows.Forms.Button();
            this.buttonUpdateDep = new System.Windows.Forms.Button();
            this.buttonAddDep = new System.Windows.Forms.Button();
            this.textBoxDepLocation = new System.Windows.Forms.TextBox();
            this.labelDepLocation = new System.Windows.Forms.Label();
            this.textBoxDepName = new System.Windows.Forms.TextBox();
            this.labelDepName = new System.Windows.Forms.Label();
            this.textBoxDepID = new System.Windows.Forms.TextBox();
            this.labelDepID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(200)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonDepSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonDeleteDep);
            this.panel1.Controls.Add(this.buttonUpdateDep);
            this.panel1.Controls.Add(this.buttonAddDep);
            this.panel1.Controls.Add(this.textBoxDepLocation);
            this.panel1.Controls.Add(this.labelDepLocation);
            this.panel1.Controls.Add(this.textBoxDepName);
            this.panel1.Controls.Add(this.labelDepName);
            this.panel1.Controls.Add(this.textBoxDepID);
            this.panel1.Controls.Add(this.labelDepID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 500);
            this.panel1.TabIndex = 0;
            // 
            // buttonDepSearch
            // 
            this.buttonDepSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(59)))), ((int)(((byte)(207)))));
            this.buttonDepSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDepSearch.Location = new System.Drawing.Point(257, 89);
            this.buttonDepSearch.Name = "buttonDepSearch";
            this.buttonDepSearch.Size = new System.Drawing.Size(104, 36);
            this.buttonDepSearch.TabIndex = 18;
            this.buttonDepSearch.Text = "SEARCH";
            this.buttonDepSearch.UseVisualStyleBackColor = false;
            this.buttonDepSearch.Click += new System.EventHandler(this.buttonDepSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Departments";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(59)))), ((int)(((byte)(207)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(219, 427);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(118, 47);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDeleteDep
            // 
            this.buttonDeleteDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonDeleteDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteDep.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteDep.Location = new System.Drawing.Point(31, 427);
            this.buttonDeleteDep.Name = "buttonDeleteDep";
            this.buttonDeleteDep.Size = new System.Drawing.Size(118, 47);
            this.buttonDeleteDep.TabIndex = 8;
            this.buttonDeleteDep.Text = "DELETE";
            this.buttonDeleteDep.UseVisualStyleBackColor = false;
            this.buttonDeleteDep.Click += new System.EventHandler(this.buttonDeleteDep_Click);
            // 
            // buttonUpdateDep
            // 
            this.buttonUpdateDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(59)))), ((int)(((byte)(207)))));
            this.buttonUpdateDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateDep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateDep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateDep.Location = new System.Drawing.Point(219, 345);
            this.buttonUpdateDep.Name = "buttonUpdateDep";
            this.buttonUpdateDep.Size = new System.Drawing.Size(118, 47);
            this.buttonUpdateDep.TabIndex = 7;
            this.buttonUpdateDep.Text = "UPDATE";
            this.buttonUpdateDep.UseVisualStyleBackColor = false;
            this.buttonUpdateDep.Click += new System.EventHandler(this.buttonUpdateDep_Click);
            // 
            // buttonAddDep
            // 
            this.buttonAddDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(59)))), ((int)(((byte)(207)))));
            this.buttonAddDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddDep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddDep.Location = new System.Drawing.Point(31, 345);
            this.buttonAddDep.Name = "buttonAddDep";
            this.buttonAddDep.Size = new System.Drawing.Size(118, 47);
            this.buttonAddDep.TabIndex = 6;
            this.buttonAddDep.Text = "ADD";
            this.buttonAddDep.UseVisualStyleBackColor = false;
            this.buttonAddDep.Click += new System.EventHandler(this.buttonAddDep_Click);
            // 
            // textBoxDepLocation
            // 
            this.textBoxDepLocation.Location = new System.Drawing.Point(18, 231);
            this.textBoxDepLocation.Name = "textBoxDepLocation";
            this.textBoxDepLocation.Size = new System.Drawing.Size(305, 22);
            this.textBoxDepLocation.TabIndex = 5;
            // 
            // labelDepLocation
            // 
            this.labelDepLocation.AutoSize = true;
            this.labelDepLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDepLocation.Location = new System.Drawing.Point(14, 205);
            this.labelDepLocation.Name = "labelDepLocation";
            this.labelDepLocation.Size = new System.Drawing.Size(169, 20);
            this.labelDepLocation.TabIndex = 4;
            this.labelDepLocation.Text = "Department Location:";
            // 
            // textBoxDepName
            // 
            this.textBoxDepName.Location = new System.Drawing.Point(18, 165);
            this.textBoxDepName.Name = "textBoxDepName";
            this.textBoxDepName.Size = new System.Drawing.Size(305, 22);
            this.textBoxDepName.TabIndex = 3;
            // 
            // labelDepName
            // 
            this.labelDepName.AutoSize = true;
            this.labelDepName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDepName.Location = new System.Drawing.Point(14, 139);
            this.labelDepName.Name = "labelDepName";
            this.labelDepName.Size = new System.Drawing.Size(149, 20);
            this.labelDepName.TabIndex = 2;
            this.labelDepName.Text = "Department Name:";
            // 
            // textBoxDepID
            // 
            this.textBoxDepID.Location = new System.Drawing.Point(18, 98);
            this.textBoxDepID.Name = "textBoxDepID";
            this.textBoxDepID.Size = new System.Drawing.Size(223, 22);
            this.textBoxDepID.TabIndex = 1;
            // 
            // labelDepID
            // 
            this.labelDepID.AutoSize = true;
            this.labelDepID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDepID.Location = new System.Drawing.Point(14, 72);
            this.labelDepID.Name = "labelDepID";
            this.labelDepID.Size = new System.Drawing.Size(121, 20);
            this.labelDepID.TabIndex = 0;
            this.labelDepID.Text = "Department ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewDepartment);
            this.panel2.Location = new System.Drawing.Point(424, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 243);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartment.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.RowHeadersWidth = 51;
            this.dataGridViewDepartment.RowTemplate.Height = 24;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(395, 237);
            this.dataGridViewDepartment.TabIndex = 0;
            this.dataGridViewDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartment_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(424, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 251);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagement.Properties.Resources.corporate;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDepLocation;
        private System.Windows.Forms.Label labelDepLocation;
        private System.Windows.Forms.TextBox textBoxDepName;
        private System.Windows.Forms.Label labelDepName;
        private System.Windows.Forms.TextBox textBoxDepID;
        private System.Windows.Forms.Label labelDepID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonAddDep;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDeleteDep;
        private System.Windows.Forms.Button buttonUpdateDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDepSearch;
    }
}