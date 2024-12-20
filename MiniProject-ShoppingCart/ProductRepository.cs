using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniProject_ShoppingCart
{
    public class ProductRepository
    {
        private DatabaseHelper dbHelper;

        public ProductRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        // Get list of products
        public DataTable GetProductList()
        {
            return dbHelper.ExecuteQuery("GetProductList", null);
        }

        // Add a product to the cart
        public void AddToCart(int productId, string username, int quantity)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductId", productId),
                new SqlParameter("@Username", username),
                new SqlParameter("@Quantity", quantity)
            };

            dbHelper.ExecuteNonQuery("AddToCart", parameters);
        }
    }
}
