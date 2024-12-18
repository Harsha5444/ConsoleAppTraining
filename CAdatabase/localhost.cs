using System;
using System.Data.SqlClient;

namespace CAdatabase
{
    class localhost
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("server = .; integrated security = true; database = CSDB");
            string query = "delete from [dbo].[emp] where empno = 7369";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine(rows);
            Console.Read();
        }
    }
}
