using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmurilloLab9
{
    class ProductDB
    {
        //Product
        public static List<Product> GetProduct()
        {
            List<Product> products = new List<Product>();
            SqlConnection connection = TechSupportDBcs.GetConnection();
            string selectStatement = "SELECT name, productCode "
                                   + "FROM Products "
                                   ;
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Product s = new Product();
                    s.name = reader["name"].ToString();
                    s.productCode = reader["productCode"].ToString();
                    products.Add(s);
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
            return products;
        }
    }




}

