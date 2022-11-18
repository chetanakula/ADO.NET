using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    internal class program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=chetanVM;Initial Catalog=project;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Please Enter Employee Id : ");
            int EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease Enter Employee First Name : ");
            String EmpFName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Last Name  : ");
            String EmpLname = Console.ReadLine();

            Console.WriteLine("\nPlease Enter Employee Salary : ");
            int EmpSalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter Employee city : ");
            String city = Console.ReadLine();


            string insertQuery = "insert into Employees(EmpId, EmpFname, EmpLname, EmpSalary, city) Values('" + EmpId + "','" + EmpFName + "','" + EmpLname + "','" + EmpSalary + "','" + city + " ')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data Inserted");
            sqlConnection.Close();
        }
    }
}

