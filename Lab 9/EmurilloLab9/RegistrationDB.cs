using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmurilloLab9
{
    
    class RegistrationDB
    {
        //Registration
        public static List<Registration> GetCustomer()
        {
            List<Registration> registrations = new List<Registration>();
            SqlConnection connection = TechSupportDBcs.GetConnection();
            string selectStatement = "SELECT customerID, productCode, registrationDate "
                                   + "FROM Registrations "
                                   ;
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Registration s = new Registration();
                    s.customerID = (int)reader["customerID"];
                    s.productCode = reader["productCode"].ToString();
                    s.registrationDate = (DateTime)reader["registrationDate"];
                    registrations.Add(s);
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
            return registrations;
        }

        public static bool AddRegistration(Registration registration, Customer customerID, Product productCode)
        {
            bool success = false;
            SqlConnection connection = TechSupportDBcs.GetConnection();
            string insertStatement =
                "INSERT Registrations " +
                "(customerID, productCode, registrationDate) " +
                "VALUES (@customerID, @productCode, @registrationDate)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@customerID", customerID.customerID);
            insertCommand.Parameters.AddWithValue(
                "@productCode", productCode.productCode);
            insertCommand.Parameters.AddWithValue(
                "@registrationDate", registration.registrationDate);
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                success = true;
            }
            catch (SqlException)
            {
                
            //    MessageBox.Show("Duplicate Entry", "Error");
                // success = false;
            }
            finally
            {
                connection.Close();
            }
            if (success)
            {
                MessageBox.Show("Added to Database", "Success");

            }
            else
            {
                MessageBox.Show("Duplicate Entry", "Error");

            }

            return success;

        }


    }



}

