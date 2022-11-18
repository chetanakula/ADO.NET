using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace projectupdate
{
    internal class update
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=chetanVM;Initial Catalog=project;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("please enter the updated employee id :");
            int EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the updated employee firstname  :");
            string EmpFname = Console.ReadLine();
            Console.WriteLine("please enter the updated employee lastname :");
            string EmpLname = Console.ReadLine();

            string UpdateQuery = "Update Employees set EmpID='"+1+"',EmpFname = '"+EmpFname+"',EmpLname='"+EmpLname+"' WHERE EmpID=" + EmpID +"";
            SqlCommand updateCommand = new SqlCommand(UpdateQuery, sqlConnection);
            updateCommand.ExecuteNonQuery();
            Console.WriteLine("\n Data updated");
            Console.ReadLine();
            sqlConnection.Close();




        }
    }
}
