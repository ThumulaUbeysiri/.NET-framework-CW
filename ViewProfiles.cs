using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class ViewProfiles : Form
    {
        Employee emp = new Employee();
        public ViewProfiles()
        {
            InitializeComponent();
            this.dataGridViewEmpProfile.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewEmpProfile.DataSource = emp.getEmployeeData();
        }

        private void labelEmpID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEmpProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewEmpProfile.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewEmpProfile.CurrentRow.Selected = true;
                        textBoxEmpID.Text = dataGridViewEmpProfile.Rows[e.RowIndex].Cells["empID"].FormattedValue.ToString();
                        textBoxEmpDep.Text = dataGridViewEmpProfile.Rows[e.RowIndex].Cells["depID"].FormattedValue.ToString();
                        textBoxEmpName.Text = dataGridViewEmpProfile.Rows[e.RowIndex].Cells["fullName"].FormattedValue.ToString();
                        textBoxEmpPosition.Text = dataGridViewEmpProfile.Rows[e.RowIndex].Cells["position"].FormattedValue.ToString();
                        textBoxEmpSalary.Text = dataGridViewEmpProfile.Rows[e.RowIndex].Cells["salary"].FormattedValue.ToString();
                        textBoxEmpGender.Text = dataGridViewEmpProfile.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();
                        textBoxEmpContact.Text = dataGridViewEmpProfile.Rows[e.RowIndex].Cells["contactNo"].FormattedValue.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void buttonEmpClear_Click(object sender, EventArgs e)
        {
            emp.clearFields(this);
        }

        private void buttonEmpSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchEmpID = textBoxEmpID.Text;

                foreach (DataGridViewRow row in dataGridViewEmpProfile.Rows)
                {

                    if (row.Cells["empID"].Value != null && row.Cells["empID"].Value.ToString() == searchEmpID)
                    {
                        //Select the row in the DataGridView
                        row.Selected = true;
                        dataGridViewEmpProfile.CurrentCell = row.Cells["empID"]; // Ensure the cell is visible

                        //scroll to the selected row
                        dataGridViewEmpProfile.FirstDisplayedScrollingRowIndex = row.Index;


                        break;
                    }
                }       

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEmpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                string empID = textBoxEmpID.Text.Trim();

                emp.removeEmployee(empID);
                  
                dataGridViewEmpProfile.DataSource = emp.getEmployeeData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
