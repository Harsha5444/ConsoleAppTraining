using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CAtasks
{
    class Task18_DataAdapter
    {
        static void Main(string[] args)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString))
                {
                    string empQuery = "SELECT * FROM employee";
                    string deptQuery = "SELECT * FROM department";

                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataSet ds = new DataSet();

                    adapter.SelectCommand = new SqlCommand(empQuery, conn);
                    adapter.Fill(ds, "Emp");

                    adapter.SelectCommand = new SqlCommand(deptQuery, conn);
                    adapter.Fill(ds, "Dept");

                    Console.WriteLine("Employee Table:");
                    foreach (DataRow row in ds.Tables["Emp"].Rows)
                    {
                        Console.WriteLine($"ID: {row["Eno"]}, Name: {row["eName"]}");
                    }

                    Console.WriteLine("\nDepartment Table:");
                    foreach (DataRow row in ds.Tables["Dept"].Rows)
                    {
                        Console.WriteLine($"Dept No: {row["deptno"]}, Dept Name: {row["dept"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }
}
