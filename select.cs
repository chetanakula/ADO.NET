using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace projectselect
{
    internal class select
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=chetanVM;Initial Catalog=project;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string selectQuery = "select * from Employees";
            SqlCommand display = new SqlCommand(selectQuery, sqlConnection);
            SqlDataReader dataReader = display.ExecuteReader(); 

            while(dataReader.Read())
            {
                Console.WriteLine("user - " + dataReader.GetString(1).ToString());

            }
            dataReader.Close();
            Console.WriteLine("data inserted");
            sqlConnection.Close();
        }
    }
}
