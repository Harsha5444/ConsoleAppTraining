using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CAtasks
{
    class Task16_DataBase
    {
        private SqlConnection conn;

        static void Main(string[] args)
        {
            Task16_DataBase db = new Task16_DataBase();
            db.RunApplication();
            Console.ReadLine();
        }

        public void RunApplication()
        {
            Console.WriteLine("Enter Database Name:");
            string dbName = Console.ReadLine();

            if (EstablishConnection(dbName))
            {
                Console.WriteLine("Connection established successfully!");

                while (true)
                {
                    Console.WriteLine("Choose an operation: 1-Insert, 2-Update, 3-Delete, 4-Exit");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                        PerformInsert();
                    else if (choice == "2")
                        PerformUpdate();
                    else if (choice == "3")
                        PerformDelete();
                    else if (choice == "4")
                    {
                        Console.WriteLine("Exiting application.");
                        break;
                    }
                    else
                        Console.WriteLine("Invalid choice. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Database does not exist.");
            }

            CloseConnection();
        }

        public bool EstablishConnection(string dbName)
        {
            if (dbName == "CompanyDB")
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString;
                conn = new SqlConnection(connectionString);
                conn.Open();
                return true;
            }
            return false;
        }

        public void PerformInsert()
        {
            Console.WriteLine("Enter Employee Details for Insertion:");
            Console.Write("Employee Number: ");
            int eno = int.Parse(Console.ReadLine());
            Console.Write("Employee Name: ");
            string ename = Console.ReadLine();
            Console.Write("Job: ");
            string job = Console.ReadLine();
            Console.Write("Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.Write("Department: ");
            string dept = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("usp_insert_employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@job", job);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@dept", dept);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowsAffected > 0 ? "Employee inserted successfully." : "Insertion failed.");
        }

        public void PerformUpdate()
        {
            Console.WriteLine("Enter Employee Details for Update:");
            Console.Write("Employee Number: ");
            int eno = int.Parse(Console.ReadLine());
            Console.Write("Employee Name: ");
            string ename = Console.ReadLine();
            Console.Write("Job: ");
            string job = Console.ReadLine();
            Console.Write("Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.Write("Department: ");
            string dept = Console.ReadLine();

            SqlCommand cmd = new SqlCommand("usp_update_employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", eno);
            cmd.Parameters.AddWithValue("@ename", ename);
            cmd.Parameters.AddWithValue("@job", job);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@dept", dept);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowsAffected > 0 ? "Employee updated successfully." : "Update failed.");
        }

        public void PerformDelete()
        {
            Console.WriteLine("Enter Employee Number to Delete:");
            Console.Write("Employee Number: ");
            int eno = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("usp_delete_employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", eno);

            int rowsAffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowsAffected > 0 ? "Employee deleted successfully." : "Deletion failed.");
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
