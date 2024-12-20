using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CAtasks
{
    internal class Task16_UpdateUsingStringinterpolation
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString);
                SqlCommand cmd = new SqlCommand("[dbo].[usp_insert_employee]", con);
                cmd.CommandType = CommandType.StoredProcedure;

                var emp = GetEmployee();

                cmd.Parameters.AddWithValue("@eno", emp.Eno);
                cmd.Parameters.AddWithValue("@ename", emp.Ename);
                cmd.Parameters.AddWithValue("@job", emp.Job);
                cmd.Parameters.AddWithValue("@salary", emp.Salary);
                cmd.Parameters.AddWithValue("@dept", emp.Dept);

                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine($"{i} Record(s) affected");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.Read();
        }

        static (int Eno, string Ename, string Job, decimal Salary, string Dept) GetEmployee()
        {
            return (107, "Clark kent", "Superman", 65000.00m, "WorldSaving");
        }
    }
}
