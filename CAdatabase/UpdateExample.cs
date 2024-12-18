using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAdatabase
{
    internal class UpdateExample
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=.;integrated security=true;database=CompanyDB");
                Console.WriteLine("Enter Eno to Update: ");
                int eno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter New Salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                string query = $"update Employee set Salary = {salary} where Eno = {eno}";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();

                Console.WriteLine(rowCount > 0 ? "Record Updated" : "No Record Found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
