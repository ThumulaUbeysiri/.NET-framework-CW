namespace EmployeeManagement
{
    partial class AdminLogin
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
            this.panelAdminLogin = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelAdminLogin = new System.Windows.Forms.Label();
            this.panelAdminLoginPIC = new System.Windows.Forms.Panel();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelAdminUserN = new System.Windows.Forms.Label();
            this.textBoxAdminUserN = new System.Windows.Forms.TextBox();
            this.textBoxAdminPass = new System.Windows.Forms.TextBox();
            this.labelAdminPassW = new System.Windows.Forms.Label();
            this.checkBoxAdminShowPW = new System.Windows.Forms.CheckBox();
            this.buttonAdminLogin = new System.Windows.Forms.Button();
            this.pictureBoxCompanyLogo = new System.Windows.Forms.PictureBox();
            this.panelAdminLogin.SuspendLayout();
            this.panelAdminLoginPIC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdminLogin
            // 
            this.panelAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panelAdminLogin.Controls.Add(this.labelExit);
            this.panelAdminLogin.Controls.Add(this.labelAdminLogin);
            this.panelAdminLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminLogin.Location = new System.Drawing.Point(0, 0);
            this.panelAdminLogin.Name = "panelAdminLogin";
            this.panelAdminLogin.Size = new System.Drawing.Size(653, 114);
            this.panelAdminLogin.TabIndex = 0;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.White;
            this.labelExit.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(625, 9);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(16, 16);
            this.labelExit.TabIndex = 1;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelAdminLogin
            // 
            this.labelAdminLogin.AutoSize = true;
            this.labelAdminLogin.BackColor = System.Drawing.Color.White;
            this.labelAdminLogin.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminLogin.Location = new System.Drawing.Point(213, 32);
            this.labelAdminLogin.Name = "labelAdminLogin";
            this.labelAdminLogin.Size = new System.Drawing.Size(221, 40);
            this.labelAdminLogin.TabIndex = 0;
            this.labelAdminLogin.Text = "Admin Login";
            this.labelAdminLogin.Click += new System.EventHandler(this.labelAdminLogin_Click);
            // 
            // panelAdminLoginPIC
            // 
            this.panelAdminLoginPIC.BackColor = System.Drawing.Color.Silver;
            this.panelAdminLoginPIC.Controls.Add(this.labelCompanyName);
            this.panelAdminLoginPIC.Controls.Add(this.pictureBoxCompanyLogo);
            this.panelAdminLoginPIC.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminLoginPIC.Location = new System.Drawing.Point(0, 114);
            this.panelAdminLoginPIC.Name = "panelAdminLoginPIC";
            this.panelAdminLoginPIC.Size = new System.Drawing.Size(261, 472);
            this.panelAdminLoginPIC.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(7, 291);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(214, 23);
            this.labelCompanyName.TabIndex = 1;
            this.labelCompanyName.Text = "CO-OPERATE Pvt. Ltd.";
            this.labelCompanyName.Click += new System.EventHandler(this.labelCompanyName_Click);
            // 
            // labelAdminUserN
            // 
            this.labelAdminUserN.AutoSize = true;
            this.labelAdminUserN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminUserN.Location = new System.Drawing.Point(298, 173);
            this.labelAdminUserN.Name = "labelAdminUserN";
            this.labelAdminUserN.Size = new System.Drawing.Size(91, 21);
            this.labelAdminUserN.TabIndex = 2;
            this.labelAdminUserN.Text = "Username:";
            // 
            // textBoxAdminUserN
            // 
            this.textBoxAdminUserN.Location = new System.Drawing.Point(302, 208);
            this.textBoxAdminUserN.Multiline = true;
            this.textBoxAdminUserN.Name = "textBoxAdminUserN";
            this.textBoxAdminUserN.Size = new System.Drawing.Size(288, 22);
            this.textBoxAdminUserN.TabIndex = 3;
            // 
            // textBoxAdminPass
            // 
            this.textBoxAdminPass.Location = new System.Drawing.Point(302, 295);
            this.textBoxAdminPass.Multiline = true;
            this.textBoxAdminPass.Name = "textBoxAdminPass";
            this.textBoxAdminPass.PasswordChar = '*';
            this.textBoxAdminPass.Size = new System.Drawing.Size(288, 22);
            this.textBoxAdminPass.TabIndex = 5;
            // 
            // labelAdminPassW
            // 
            this.labelAdminPassW.AutoSize = true;
            this.labelAdminPassW.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminPassW.Location = new System.Drawing.Point(298, 260);
            this.labelAdminPassW.Name = "labelAdminPassW";
            this.labelAdminPassW.Size = new System.Drawing.Size(87, 21);
            this.labelAdminPassW.TabIndex = 4;
            this.labelAdminPassW.Text = "Password:";
            // 
            // checkBoxAdminShowPW
            // 
            this.checkBoxAdminShowPW.AutoSize = true;
            this.checkBoxAdminShowPW.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdminShowPW.Location = new System.Drawing.Point(470, 323);
            this.checkBoxAdminShowPW.Name = "checkBoxAdminShowPW";
            this.checkBoxAdminShowPW.Size = new System.Drawing.Size(120, 20);
            this.checkBoxAdminShowPW.TabIndex = 6;
            this.checkBoxAdminShowPW.Text = "Show Password";
            this.checkBoxAdminShowPW.UseVisualStyleBackColor = true;
            this.checkBoxAdminShowPW.CheckedChanged += new System.EventHandler(this.checkBoxAdminShowPW_CheckedChanged);
            // 
            // buttonAdminLogin
            // 
            this.buttonAdminLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.buttonAdminLogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdminLogin.Location = new System.Drawing.Point(341, 476);
            this.buttonAdminLogin.Name = "buttonAdminLogin";
            this.buttonAdminLogin.Size = new System.Drawing.Size(210, 40);
            this.buttonAdminLogin.TabIndex = 7;
            this.buttonAdminLogin.Text = "LOGIN";
            this.buttonAdminLogin.UseVisualStyleBackColor = false;
            this.buttonAdminLogin.Click += new System.EventHandler(this.buttonAdminLogin_Click);
            // 
            // pictureBoxCompanyLogo
            // 
            this.pictureBoxCompanyLogo.Image = global::EmployeeManagement.Properties.Resources.images1;
            this.pictureBoxCompanyLogo.Location = new System.Drawing.Point(36, 59);
            this.pictureBoxCompanyLogo.Name = "pictureBoxCompanyLogo";
            this.pictureBoxCompanyLogo.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCompanyLogo.TabIndex = 0;
            this.pictureBoxCompanyLogo.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(653, 586);
            this.Controls.Add(this.buttonAdminLogin);
            this.Controls.Add(this.checkBoxAdminShowPW);
            this.Controls.Add(this.textBoxAdminPass);
            this.Controls.Add(this.labelAdminPassW);
            this.Controls.Add(this.textBoxAdminUserN);
            this.Controls.Add(this.labelAdminUserN);
            this.Controls.Add(this.panelAdminLoginPIC);
            this.Controls.Add(this.panelAdminLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.panelAdminLogin.ResumeLayout(false);
            this.panelAdminLogin.PerformLayout();
            this.panelAdminLoginPIC.ResumeLayout(false);
            this.panelAdminLoginPIC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompanyLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdminLogin;
        private System.Windows.Forms.Label labelAdminLogin;
        private System.Windows.Forms.Panel panelAdminLoginPIC;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelAdminUserN;
        private System.Windows.Forms.TextBox textBoxAdminUserN;
        private System.Windows.Forms.TextBox textBoxAdminPass;
        private System.Windows.Forms.Label labelAdminPassW;
        private System.Windows.Forms.CheckBox checkBoxAdminShowPW;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button buttonAdminLogin;
        private System.Windows.Forms.PictureBox pictureBoxCompanyLogo;
    }
}