using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Car_Dealership.Data
{    //Клас за връзка с базата данни от SQL Server Management Studio
    public static class Database
    {
        private static string connectionString = "Server=DESKTOP-5Q2Q51E\\GOSUANGEL; Database=CarDatebase; Integrated Security=true";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    
    }
}
