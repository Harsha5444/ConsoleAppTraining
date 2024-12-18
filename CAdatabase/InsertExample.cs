using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAdatabase
{
    internal class InsertExample
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=.;integrated security=true;database=CompanyDB");
                Console.WriteLine("Enter Eno: ");
                int eno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Ename: ");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter Job: ");
                string job = Console.ReadLine();
                Console.WriteLine("Enter Salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                string query = $"insert into Employee values({eno}, '{ename}', '{job}', {salary})";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();

                Console.WriteLine(rowCount > 0 ? "Record Inserted" : "Insertion Failed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
