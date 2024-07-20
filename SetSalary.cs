using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EmployeeManagement
{
    public partial class SetSalary : Form
    {
        Employee emp = new Employee();
        public SetSalary()
        {
            InitializeComponent();
            this.dataGridViewEmpSalary.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewEmpSalary.DataSource = emp.getEmployeeData();
        }

        private void buttonUpdateSal_Click(object sender, EventArgs e)
        {
            try 
            {
                string empID = textBoxEmpID.Text.Trim();

                decimal sal;

                if (decimal.TryParse(textBoxEmpSal.Text.Trim(), out sal))
                {
                    emp.updateSalary(empID, sal);
                    dataGridViewEmpSalary.DataSource = emp.getEmployeeData();

                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid decimal number.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClearSal_Click(object sender, EventArgs e)
        {
            emp.clearFields(this);
        }

        private void dataGridViewEmpSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridViewEmpSalary.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewEmpSalary.CurrentRow.Selected = true;
                    textBoxEmpID.Text = dataGridViewEmpSalary.Rows[e.RowIndex].Cells["empID"].FormattedValue.ToString();
                    textBoxEmpName.Text = dataGridViewEmpSalary.Rows[e.RowIndex].Cells["fullName"].FormattedValue.ToString();
                    textBoxEmpContact.Text = dataGridViewEmpSalary.Rows[e.RowIndex].Cells["contactNo"].FormattedValue.ToString();
                    textBoxEmpSal.Text = dataGridViewEmpSalary.Rows[e.RowIndex].Cells["salary"].FormattedValue.ToString();
                    
                }
            }
        }

        private void buttonSetSalSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchEmpID = textBoxEmpID.Text;

                foreach (DataGridViewRow row in dataGridViewEmpSalary.Rows)
                {

                    if (row.Cells["empID"].Value != null && row.Cells["empID"].Value.ToString() == searchEmpID )
                    {
                        //Select the row in the DataGridView
                        row.Selected = true;
                        dataGridViewEmpSalary.CurrentCell = row.Cells["empID"]; // Ensure the cell is visible

                        //scroll to the selected row
                        dataGridViewEmpSalary.FirstDisplayedScrollingRowIndex = row.Index;


                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetSalReport_Click(object sender, EventArgs e)
        {
            try
            {
               
                string empId = textBoxEmpID.Text.Trim();
                string fullName = textBoxEmpName.Text.Trim();
                string contactNo = textBoxEmpContact.Text.Trim();
                string salary = textBoxEmpSal.Text.Trim();

                DateTime currDateTime = DateTime.Now;

                string date = currDateTime.ToString("yyyy-MM-dd   HH:mm:ss");

                // Create a new Word application
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;

                // Create a new document
                Word.Document doc = wordApp.Documents.Add();

                
                Word.Paragraph titlePara = doc.Paragraphs.Add();             
                titlePara.Range.Font.Bold = 1;
                titlePara.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                titlePara.Range.Font.Size = 24;
                titlePara.Range.Font.Name = "Times New Roman";
                titlePara.Range.Text = $"SALARY REPORT";
                titlePara.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;               
                titlePara.Range.InsertParagraphAfter();

                foreach (Word.Section section in doc.Sections)
                {
                    Word.Borders borders = section.Borders;
                    borders.Enable = 1; // Enable borders

                    foreach (Word.Border border in borders)
                    {
                        border.LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                        border.Color = Word.WdColor.wdColorBlack;
                        border.LineWidth = Word.WdLineWidth.wdLineWidth075pt; // Set border width (0.75 pt)
                    }
                }

         
                Word.Paragraph bodyPara = doc.Paragraphs.Add();
                bodyPara.Range.Font.Bold = 0;
                bodyPara.Range.Font.Size = 14;
                bodyPara.Range.Font.Name = "Times New Roman";
                bodyPara.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                bodyPara.Range.Text = $"\nThis is to confirm that the salary amounting to {salary} has been disbursed to the employee {fullName} (Employee ID: {empId}) for the current pay period. We acknowledge the receipt of this amount on {date}.\n";
                bodyPara.Range.InsertParagraphAfter();
    
                Word.Paragraph empDetailsPara = doc.Paragraphs.Add();    
                empDetailsPara.Range.Font.Bold = 0;
                empDetailsPara.Range.Font.Size = 12;
                empDetailsPara.Range.Font.Name = "Times New Roman";
                empDetailsPara.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                empDetailsPara.Range.Text = $"Employee ID: {empId}\nFull Name: {fullName}\nContact No: {contactNo}\nSalary: {salary}\nDate and Time: {date}";
                empDetailsPara.Range.InsertParagraphAfter();


                // Save the document
                object filename = @"C:\Users\User\source\repos\EmployeeManagement\Salary_Report.docx";
                doc.SaveAs2(ref filename);
                doc.Close();
                wordApp.Quit();

                MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
