using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class AddEmployee : Form
    {
        Employee emp = new Employee();

        public AddEmployee()
        {
            InitializeComponent();
            this.dataGridViewEmpData.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewEmpData.DataSource = emp.getEmployeeData();
        }

        private void labelEmpData_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmpAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(textBoxEmpName.Text))
                {
                    MessageBox.Show("Employee name cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxEmpPosition.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxEmpPosition.SelectedItem.ToString()))
                {
                    MessageBox.Show("Please select an employee position", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxEmpDep.Text))
                {
                    MessageBox.Show("Department ID cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBoxEmpGender.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxEmpGender.SelectedItem.ToString()))
                {
                    MessageBox.Show("Please select a gender", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textBoxEmpContact.Text.Length != 10 || !textBoxEmpContact.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Contact Number must be exactly 10 digits and contain only digits (0-9).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int empCont = int.Parse(textBoxEmpContact.Text.Trim());
                string empPosition = comboBoxEmpPosition.SelectedItem.ToString();
                string empName = textBoxEmpName.Text.Trim().ToString();
                string depId = textBoxEmpDep.Text.Trim();
                string gender = comboBoxEmpGender.SelectedItem.ToString();

                // Call addEmployee method
                emp.addEmployee("", empCont, empPosition, empName, depId, gender);

                
                dataGridViewEmpData.DataSource = emp.getEmployeeData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid Contact Number. Please enter a valid numeric value.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex);
            }


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            emp.clearFields(this);
        }
    }
}
