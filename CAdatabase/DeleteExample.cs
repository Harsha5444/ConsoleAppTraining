using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAdatabase
{
    internal class DeleteExample
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=.;integrated security=true;database=CompanyDB");
                Console.WriteLine("Enter Eno to Delete: ");
                int eno = Convert.ToInt32(Console.ReadLine());

                string query = $"delete from Employee where Eno = {eno}";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                con.Close();

                Console.WriteLine(rowCount > 0 ? "Record Deleted" : "No Record Found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
