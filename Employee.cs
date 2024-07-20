using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    internal class Employee
    {
        private SqlConnection connection;
        private double empIDNumValue;
        


        public Employee()
        {
            DatabaseConn db = new DatabaseConn();
            connection = db.getDatabaseConn();
            generateEmpID();
            

        }

        public DataTable getEmployeeData()
        {
            SqlCommand cmd = new SqlCommand("select * from Employee", connection);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dataT = new DataTable();
            adapt.Fill(dataT);

            return dataT;

        }

        public DataTable getTasks()
        {
            SqlCommand cmd = new SqlCommand("select * from Task", connection);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dataT = new DataTable();
            adapt.Fill(dataT);

            return dataT;
        }

        public DataTable getEmpTasks()
        {
            SqlCommand cmd = new SqlCommand("select * from EmpTask", connection);

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dataT = new DataTable();
            adapt.Fill(dataT);

            return dataT;

        }

        public void generateEmpID()
        {
            string Value = null;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select top 1 empID from Employee order by empID DESC", connection);
            object LID = cmd.ExecuteScalar();
            connection.Close();

            if (LID != null && LID != DBNull.Value)
            {
                String temp = Convert.ToString(LID);
                Value = temp.Substring(1);
            }
            else
            {
                Value = "0";
            }

            empIDNumValue = Convert.ToDouble(Value);


        }

        public void addEmployee(string empId, int empCont, string empPos, string name, string depId, string gender)
        {
            connection.Open();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(empPos))
            {
                MessageBox.Show("Employee position cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Gender cannot be empty", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (empCont <= 0)
            {
                MessageBox.Show("Invalid employee contact number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            try
            {
                empIDNumValue++; // Increment the empIDNumValue for the next employee

                string empID = "E" + empIDNumValue.ToString("00000");

                decimal salary = 0;

                string sql = "INSERT INTO Employee(empID, fullName, position, salary, contactNo, gender, depID) " +
                             "VALUES(@empId, @name, @empPos, @salary, @empCont, @gender, @depId)";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@empId", empID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@empPos", empPos);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@empCont", empCont);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@depId", depId);

                //connection.Open();
                cmd.ExecuteNonQuery();
                //connection.Close();

                MessageBox.Show("Employee added successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }



        }

        public void addTaskstoEmp(string empID, string taskID)
        {
            DateTime date = DateTime.Today;

            connection.Open();

            try
            {
                

                string sql = "insert into EmpTask(empID, taskID, assignedDate) values('" + empID + "', '" + taskID + "', '" + date + "')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Task added to employee successfully");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }finally
            {
                connection.Close ();
            }

        }

        public void updateTask(string taskID, string empID)
        {
            connection.Open();

            try
            {
                
                string sql = "update EmpTask set taskID = '" + taskID + "'  where empID = '" + empID + "' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Task updated successfully!");

            }catch( Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }finally
            {
                connection.Close();
            }


        }

        public void deleteTask(string taskID, string empID)
        {
            connection.Open();

            try
            {

                string sql = "delete from EmpTask where empID = '" + empID + "' and taskID = '" + taskID + "' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Task removed successfully!");

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

        public void deleteEmplAllTask(string empID)
        {
            connection.Open();

            try
            {
                

                string sql = "delete from EmpTask where empID = '" + empID + "' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();


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

        public void updateSalary(string empID, decimal sal)
        {
            connection.Open();

            try
            {
                string sql = "update Employee set salary = '" + sal + "' where empID = '" + empID + "' ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Salary has been updated!");

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

        public void removeEmployee(string empID)
        {
            connection.Open();

            try
            {
                string sql = "delete from Employee where empID = '" + empID + "'  ";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee removed successfully!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }

        }

        public int countEmployees()
        {
            connection.Open();

            int count = 0;

            string sql = "select count(*) from Employee";

            using(SqlCommand cmd = new SqlCommand(sql,connection))
            {
                try
                {
                    count = (int)cmd.ExecuteScalar();

                }catch(Exception ex) 
                {
                    MessageBox.Show($"Error counting employees: {ex.Message}");

                }
                finally
                {
                    connection.Close();
                }
            }

            return count;
            

        }

       

        public void clearFields(Control control)
        {
            foreach(Control c in control.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";

                }else if(c is ComboBox) 
                {
                    ((ComboBox)c).SelectedItem = null;

                }else if(c.HasChildren)
                {
                    clearFields(c);

                }
            }
            
        }   

    }
}
