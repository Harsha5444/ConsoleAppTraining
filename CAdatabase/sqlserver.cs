using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAdatabase
{
    class sqlserver
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("server = 10.10.1.219; integrated security = true; database = DataAnalytics_pro");
            string query = "delete from [dbo].[RefTerm] where TermId = 28";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine(rows);
            Console.Read();
        }
    }
}
