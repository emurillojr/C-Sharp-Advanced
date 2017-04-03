using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmurilloLab9
{
    class CustomerDB
    {
        //Customer
        public static List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>();
            SqlConnection connection = TechSupportDBcs.GetConnection();
            string selectStatement = "SELECT customerID, name "
                                   + "FROM Customers "
                                   ;
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Customer s = new Customer();
                    s.customerID = (int)reader["customerID"];
                    s.name = reader["name"].ToString();
                    customers.Add(s);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return customers;
        }

       


    }



}

