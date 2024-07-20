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
    public partial class SetTasks : Form
    {
        Employee emp = new Employee();
        public SetTasks()
        {
            InitializeComponent();
            this.dataGridViewEmpTask.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridViewTasks.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewTasks.DataSource = emp.getTasks();
            dataGridViewEmpTask.DataSource = emp.getEmpTasks();
        }

        private void buttonClearTask_Click(object sender, EventArgs e)
        {
            emp.clearFields(this);

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmpID.Text != "")
                {
                    string empID = textBoxEmpID.Text.Trim();
                    string taskID = comboBoxTasks.SelectedItem.ToString();

                    emp.addTaskstoEmp(empID, taskID);
                    dataGridViewEmpTask.DataSource = emp.getEmpTasks();

                }else
                {
                    MessageBox.Show("Employee ID can't be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
        }

        private void dataGridViewEmpTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewEmpTask.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewEmpTask.CurrentRow.Selected = true;
                        textBoxEmpID.Text = dataGridViewEmpTask.Rows[e.RowIndex].Cells["empID"].FormattedValue.ToString();
                        comboBoxTasks.Text = dataGridViewEmpTask.Rows[e.RowIndex].Cells["taskID"].FormattedValue.ToString();

                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void buttonSetTaskSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchEmpID = textBoxEmpID.Text;

                foreach (DataGridViewRow row in dataGridViewEmpTask.Rows)
                {
                    
                    if (row.Cells["empID"].Value != null && row.Cells["empID"].Value.ToString() == searchEmpID)
                    {
                        //Select the row in the DataGridView
                        row.Selected = true;
                        dataGridViewEmpTask.CurrentCell = row.Cells["empID"]; // Ensure the cell is visible

                        //scroll to the selected row
                        dataGridViewEmpTask.FirstDisplayedScrollingRowIndex = row.Index;

                        
                        break;
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonUpdateTask_Click(object sender, EventArgs e)
        {
            try
            {
                string empID = textBoxEmpID.Text.Trim();
                string taskID = comboBoxTasks.Text.Trim();

                emp.updateTask(taskID, empID);
                dataGridViewEmpTask.DataSource = emp.getEmpTasks();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                string empID = textBoxEmpID.Text.Trim();
                string taskID = comboBoxTasks.Text.Trim();

                emp.deleteTask(taskID, empID);
                dataGridViewEmpTask.DataSource = emp.getEmpTasks();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
