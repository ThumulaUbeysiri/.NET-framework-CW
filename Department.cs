using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Department : Form
    {
        DepClass dep = new DepClass();

        public Department()
        {
            InitializeComponent();
            this.dataGridViewDepartment.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewDepartment.DataSource = dep.getDepartmentData();
        }

        private void buttonAddDep_Click(object sender, EventArgs e)
        {
            try
            {
                string depID = textBoxDepID.Text.Trim();
                string depName = textBoxDepName.Text.Trim();
                string depLoc = textBoxDepLocation.Text.Trim();

                
                dep.addDepartment(depID, depName, depLoc);

                dataGridViewDepartment.DataSource = dep.getDepartmentData();
        

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }

        }

        private void buttonUpdateDep_Click(object sender, EventArgs e)
        {
            try
            {
                string depID = textBoxDepID.Text.Trim();
                string depName = textBoxDepName.Text.Trim();
                string depLoc = textBoxDepLocation.Text.Trim();


                dep.updateDepartment(depID, depName, depLoc);

                dataGridViewDepartment.DataSource = dep.getDepartmentData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dep.clearFields(this);
        }

        private void buttonDeleteDep_Click(object sender, EventArgs e)
        {
            try
            {
                string depID = textBoxDepID.Text.Trim();

                dep.removeDepartment(depID);
                dataGridViewDepartment.DataSource = dep.getDepartmentData();

            }catch(Exception ex) 
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);


            }
        }

        private void dataGridViewDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewDepartment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewDepartment.CurrentRow.Selected = true;
                        textBoxDepID.Text = dataGridViewDepartment.Rows[e.RowIndex].Cells["depID"].FormattedValue.ToString();
                        textBoxDepName.Text = dataGridViewDepartment.Rows[e.RowIndex].Cells["depName"].FormattedValue.ToString();
                        textBoxDepLocation.Text = dataGridViewDepartment.Rows[e.RowIndex].Cells["depLocation"].FormattedValue.ToString();

                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);

            }
            

        }

        private void buttonDepSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchDepID = textBoxDepID.Text;

                foreach (DataGridViewRow row in dataGridViewDepartment.Rows)
                {

                    if (row.Cells["depID"].Value != null && row.Cells["depID"].Value.ToString() == searchDepID)
                    {
                        //Select the row in the DataGridView
                        row.Selected = true;
                        dataGridViewDepartment.CurrentCell = row.Cells["depID"]; // Ensure the cell is visible

                        //scroll to the selected row
                        dataGridViewDepartment.FirstDisplayedScrollingRowIndex = row.Index;


                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
