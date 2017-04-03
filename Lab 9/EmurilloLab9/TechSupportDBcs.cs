using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmurilloLab9
{
    class TechSupportDBcs
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=sql.neit.edu;Initial Catalog=TechSupport;User ID=SE256_Murillo;Password=ERNIE0322";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}