namespace EmployeeManagement
{
    partial class SetTasks
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
            this.comboBoxTasks = new System.Windows.Forms.ComboBox();
            this.labelTaskID = new System.Windows.Forms.Label();
            this.buttonSetTaskSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClearTask = new System.Windows.Forms.Button();
            this.buttonDeleteTask = new System.Windows.Forms.Button();
            this.buttonUpdateTask = new System.Windows.Forms.Button();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTasks = new System.Windows.Forms.Label();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.labelTasksAssig = new System.Windows.Forms.Label();
            this.dataGridViewEmpTask = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpTask)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.comboBoxTasks);
            this.panel1.Controls.Add(this.labelTaskID);
            this.panel1.Controls.Add(this.buttonSetTaskSearch);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonClearTask);
            this.panel1.Controls.Add(this.buttonDeleteTask);
            this.panel1.Controls.Add(this.buttonUpdateTask);
            this.panel1.Controls.Add(this.buttonAddTask);
            this.panel1.Controls.Add(this.textBoxEmpID);
            this.panel1.Controls.Add(this.labelEmpID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 500);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxTasks
            // 
            this.comboBoxTasks.FormattingEnabled = true;
            this.comboBoxTasks.Items.AddRange(new object[] {
            "A001 ",
            "C001 ",
            "S001 ",
            "OP001 ",
            "F001  ",
            "HR001",
            "L001 "});
            this.comboBoxTasks.Location = new System.Drawing.Point(37, 221);
            this.comboBoxTasks.Name = "comboBoxTasks";
            this.comboBoxTasks.Size = new System.Drawing.Size(292, 24);
            this.comboBoxTasks.TabIndex = 23;
            // 
            // labelTaskID
            // 
            this.labelTaskID.AutoSize = true;
            this.labelTaskID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTaskID.Location = new System.Drawing.Point(36, 198);
            this.labelTaskID.Name = "labelTaskID";
            this.labelTaskID.Size = new System.Drawing.Size(62, 20);
            this.labelTaskID.TabIndex = 22;
            this.labelTaskID.Text = "Task ID:";
            // 
            // buttonSetTaskSearch
            // 
            this.buttonSetTaskSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.buttonSetTaskSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetTaskSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetTaskSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSetTaskSearch.Location = new System.Drawing.Point(268, 116);
            this.buttonSetTaskSearch.Name = "buttonSetTaskSearch";
            this.buttonSetTaskSearch.Size = new System.Drawing.Size(104, 36);
            this.buttonSetTaskSearch.TabIndex = 20;
            this.buttonSetTaskSearch.Text = "SEARCH";
            this.buttonSetTaskSearch.UseVisualStyleBackColor = false;
            this.buttonSetTaskSearch.Click += new System.EventHandler(this.buttonSetTaskSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeManagement.Properties.Resources.clipboard__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(89, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagement.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(40, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClearTask
            // 
            this.buttonClearTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.buttonClearTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClearTask.Location = new System.Drawing.Point(211, 438);
            this.buttonClearTask.Name = "buttonClearTask";
            this.buttonClearTask.Size = new System.Drawing.Size(118, 47);
            this.buttonClearTask.TabIndex = 11;
            this.buttonClearTask.Text = "CLEAR";
            this.buttonClearTask.UseVisualStyleBackColor = false;
            this.buttonClearTask.Click += new System.EventHandler(this.buttonClearTask_Click);
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDeleteTask.Location = new System.Drawing.Point(37, 438);
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(118, 47);
            this.buttonDeleteTask.TabIndex = 10;
            this.buttonDeleteTask.Text = "DELETE";
            this.buttonDeleteTask.UseVisualStyleBackColor = false;
            this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
            // 
            // buttonUpdateTask
            // 
            this.buttonUpdateTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.buttonUpdateTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUpdateTask.Location = new System.Drawing.Point(212, 360);
            this.buttonUpdateTask.Name = "buttonUpdateTask";
            this.buttonUpdateTask.Size = new System.Drawing.Size(118, 47);
            this.buttonUpdateTask.TabIndex = 9;
            this.buttonUpdateTask.Text = "UPDATE";
            this.buttonUpdateTask.UseVisualStyleBackColor = false;
            this.buttonUpdateTask.Click += new System.EventHandler(this.buttonUpdateTask_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.buttonAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddTask.Location = new System.Drawing.Point(37, 360);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(118, 47);
            this.buttonAddTask.TabIndex = 8;
            this.buttonAddTask.Text = "ADD";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Location = new System.Drawing.Point(37, 125);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.Size = new System.Drawing.Size(216, 22);
            this.textBoxEmpID.TabIndex = 4;
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpID.Location = new System.Drawing.Point(34, 102);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(105, 20);
            this.labelEmpID.TabIndex = 0;
            this.labelEmpID.Text = "Employee ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.labelTasks);
            this.panel2.Controls.Add(this.dataGridViewTasks);
            this.panel2.Controls.Add(this.labelTasksAssig);
            this.panel2.Controls.Add(this.dataGridViewEmpTask);
            this.panel2.Location = new System.Drawing.Point(459, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 500);
            this.panel2.TabIndex = 1;
            // 
            // labelTasks
            // 
            this.labelTasks.AutoSize = true;
            this.labelTasks.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTasks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTasks.Location = new System.Drawing.Point(15, 262);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(53, 19);
            this.labelTasks.TabIndex = 3;
            this.labelTasks.Text = "Tasks";
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewTasks.Location = new System.Drawing.Point(3, 290);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(360, 197);
            this.dataGridViewTasks.TabIndex = 2;
            // 
            // labelTasksAssig
            // 
            this.labelTasksAssig.AutoSize = true;
            this.labelTasksAssig.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTasksAssig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTasksAssig.Location = new System.Drawing.Point(14, 18);
            this.labelTasksAssig.Name = "labelTasksAssig";
            this.labelTasksAssig.Size = new System.Drawing.Size(142, 19);
            this.labelTasksAssig.TabIndex = 1;
            this.labelTasksAssig.Text = "Employee - task";
            // 
            // dataGridViewEmpTask
            // 
            this.dataGridViewEmpTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpTask.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewEmpTask.Location = new System.Drawing.Point(3, 48);
            this.dataGridViewEmpTask.Name = "dataGridViewEmpTask";
            this.dataGridViewEmpTask.RowHeadersWidth = 51;
            this.dataGridViewEmpTask.RowTemplate.Height = 24;
            this.dataGridViewEmpTask.Size = new System.Drawing.Size(360, 197);
            this.dataGridViewEmpTask.TabIndex = 0;
            this.dataGridViewEmpTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpTask_CellClick);
            // 
            // SetTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetTasks";
            this.Text = "SetTasks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewEmpTask;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelTasksAssig;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonClearTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonUpdateTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSetTaskSearch;
        private System.Windows.Forms.Label labelTaskID;
        private System.Windows.Forms.ComboBox comboBoxTasks;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
    }
}