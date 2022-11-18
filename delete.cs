using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class delete
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=chetanVM;Initial Catalog=project;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("enter the EmpID which you want to delete:");
            int EmpID = Convert.ToInt32(Console.ReadLine());
            string deletequery = "Delete from Employees where EmpID=" + EmpID + "\n";
            SqlCommand deletecommand = new SqlCommand(deletequery, sqlConnection);
            deletecommand.ExecuteNonQuery();

            Console.WriteLine("data is deleted successfully");
            Console.ReadLine();

            sqlConnection.Close();


        }
    }
}
