using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void labelAdminLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxAdminUserN.Text == "Admin" && textBoxAdminPass.Text == "admin123")
                {
                    this.Hide();
                    AdminMainMenue adminMainMenue = new AdminMainMenue();
                    adminMainMenue.Show();

                }else
                {
                    MessageBox.Show("Invalid credentials please try again");
                    textBoxAdminUserN.Text = "";
                    textBoxAdminPass.Text = "";
                }

            }catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void labelCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxAdminShowPW_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAdminPass.PasswordChar = checkBoxAdminShowPW.Checked ? '\0' : '*'; 
        }

        private void labelNextLogin_Click(object sender, EventArgs e)
        {
            /*Form ManagerLogin = new Form();
            ManagerLogin.Show();
            this.Hide();*/

        }
    }
}
