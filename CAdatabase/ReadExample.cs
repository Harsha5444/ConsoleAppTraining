using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAdatabase
{
    internal class ReadExample
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=.;integrated security=true;database=CompanyDB");
                string query = "select * from Employee";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Eno: {reader["Eno"]}, Ename: {reader["Ename"]}, Job: {reader["Job"]}, Salary: {reader["Salary"]}");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
