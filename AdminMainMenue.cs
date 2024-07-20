using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AdminMainMenue : Form
    {
        Form activeForm;
        bool sidebarExapnd;
        public AdminMainMenue()
        {
            InitializeComponent();
        }

        private void AdminMainMenue_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSideBar_Tick(object sender, EventArgs e)
        {
            if(sidebarExapnd)
            {
                flowLayoutPanelSideBar.Width -= 10;

                if(flowLayoutPanelSideBar.Width == flowLayoutPanelSideBar.MinimumSize.Width)
                {
                    sidebarExapnd = false;
                    timerSideBar.Stop();
                }
            }else
            {
                flowLayoutPanelSideBar.Width += 10;

                if(flowLayoutPanelSideBar.Width == flowLayoutPanelSideBar.MaximumSize.Width)
                {
                    sidebarExapnd= true;
                    timerSideBar.Stop();
                }
            }

        }

        private void pictureBoxMenueicon_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
        }

        private void labelAdminMainExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }

        public void openSubForm (Form subForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            this.panelAdminSmallMM.Controls.Add(subForm);
            pictureBoxMM.Hide();
            subForm.Show();

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            openSubForm(new Dashboard());
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            openSubForm(new AddEmployee());
        }

        private void buttonViewProfile_Click(object sender, EventArgs e)
        {
            openSubForm(new ViewProfiles());
        }

        private void buttonSetTasks_Click(object sender, EventArgs e)
        {
            openSubForm(new SetTasks());
        }

        private void buttonSetSalary_Click(object sender, EventArgs e)
        {
            openSubForm(new SetSalary());
        }

        private void buttonManageDep_Click(object sender, EventArgs e)
        {
            openSubForm(new Department());
        }

        private void labelAdminMM_Click(object sender, EventArgs e)
        {
            pictureBoxMM.Show();
        }
    }
}
