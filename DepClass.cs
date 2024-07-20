using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace EmployeeManagement
{
    internal class DepClass
    {
        private SqlConnection connection;

        public DepClass()
        {
            DatabaseConn db = new DatabaseConn();
            connection = db.getDatabaseConn();

        }

        public DataTable getDepartmentData()
        {
            SqlCommand cmd = new SqlCommand("select * from Department", connection);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dataT = new DataTable();
            adapt.Fill(dataT);

            return dataT;
        }

        public void addDepartment(string depID, string depName, string depLocation)
        {
            connection.Open();

            if (string.IsNullOrWhiteSpace(depID))
            {
                MessageBox.Show("Department ID cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(depName))
            {
                MessageBox.Show("Department name cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(depLocation))
            {
                MessageBox.Show("Department location cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string sql = "insert into Department(depID, depName, depLocation) values('" + depID + "', '" + depName + "', '" + depLocation + "')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Department added successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }

        }

        public void updateDepartment(string depID, string depName, string depLocation)
        {
            connection.Open();

            try
            {

                string sql = "update Department set depName = '" + depName + "',  depLocation = '" + depLocation + "'   where depID = '" + depID + "' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Department information updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }finally
            {
                connection.Close();
            }
        }

        public void removeDepartment(string depID)
        {
            connection.Open();

            try
            {
                
                string sql = "delete from Department where depID = '" + depID + "' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Department removed successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }

        }

        public void clearFields(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";

                }
                else if (c.HasChildren)
                {
                    clearFields(c);

                }
            }

        }

        
    }
}
