using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniProject_ShoppingCart
{
    public class OrderRepository
    {
        private DatabaseHelper dbHelper;

        public OrderRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        // Get orders for a user
        public DataTable GetOrders(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            return dbHelper.ExecuteQuery("GetOrders", parameters);
        }
    }
}
