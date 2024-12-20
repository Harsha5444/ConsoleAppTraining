using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MiniProject_ShoppingCart
{
    public class DatabaseHelper
    {
        private string connectionString;

        // Constructor to initialize the connection string
        public DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MiniProjectDB"].ConnectionString;
        }

        // Execute a stored procedure without returning data (for insert, update, delete)
        public void ExecuteNonQuery(string procedureName, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(procedureName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        // Execute a stored procedure and return data (for select queries)
        public DataTable ExecuteQuery(string procedureName, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(procedureName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            if (parameters != null)
                cmd.Parameters.AddRange(parameters);

            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            connection.Close();
            return dt;
        }
    }
}
