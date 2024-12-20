using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniProject_ShoppingCart
{
    public class CartRepository
    {
        private DatabaseHelper dbHelper;

        public CartRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        // View cart details for a specific user
        public DataTable ViewCart(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            return dbHelper.ExecuteQuery("ViewCart", parameters);
        }

        // Place an order
        public void PlaceOrder(string username)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username)
            };

            dbHelper.ExecuteNonQuery("PlaceOrder", parameters);
        }
    }
}
