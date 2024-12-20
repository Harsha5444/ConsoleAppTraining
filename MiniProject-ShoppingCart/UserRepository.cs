using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniProject_ShoppingCart
{
    public class UserRepository
    {
        private DatabaseHelper dbHelper;

        public UserRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        // Register a user
        public void RegisterUser(string fullName, string username, string password, string mobileNumber)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FullName", fullName),
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@MobileNumber", mobileNumber)
            };

            dbHelper.ExecuteNonQuery("RegisterUser", parameters);
        }

        // User login
        public bool UserLogin(string username, string password)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            DataTable result = dbHelper.ExecuteQuery("UserLogin", parameters);
            return result.Rows.Count > 0; // Login successful if any row is returned
        }
    }
}
