using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    internal class DatabaseConn
    {
        SqlConnection conn;

        public DatabaseConn()
        {
            conn = new SqlConnection(@"Data Source = THUMULAD;Initial Catalog = Cooperate; Integrated Security = true");
            //conn.Open();

        }

        public SqlConnection getDatabaseConn() 
        {
            return conn;
        }
    }
}
