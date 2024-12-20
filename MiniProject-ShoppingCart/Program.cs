using System;
using System.Data;

namespace MiniProject_ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shopping Cart System!");

            // Example of user registration
            Console.WriteLine("Register a new user:");
            RegisterUser();

            // Example of user login
            Console.WriteLine("Login with username and password:");
            UserLogin();

            // Example of viewing products
            Console.WriteLine("Viewing available products:");
            ViewProducts();

            // Example of adding a product to the cart
            Console.WriteLine("Adding product to cart:");
            AddProductToCart();

            // Example of viewing the cart
            Console.WriteLine("Viewing cart:");
            ViewCart();
        }

        // Method to register a new user
        static void RegisterUser()
        {
            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine();
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter mobile number: ");
            string mobileNumber = Console.ReadLine();

            UserRepository userRepo = new UserRepository();
            userRepo.RegisterUser(fullName, username, password, mobileNumber);
            Console.WriteLine("User registered successfully!");
        }

        // Method to log in an existing user
        static void UserLogin()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            UserRepository userRepo = new UserRepository();
            bool isAuthenticated = userRepo.UserLogin(username, password);

            if (isAuthenticated)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        // Method to view available products
        static void ViewProducts()
        {
            ProductRepository productRepo = new ProductRepository();
            DataTable productList = productRepo.GetProductList();

            Console.WriteLine("Product List:");
            foreach (DataRow row in productList.Rows)
            {
                Console.WriteLine($"Product ID: {row["ProductId"]}, Name: {row["ProductName"]}, Price: {row["Price"]}");
            }
        }

        // Method to add a product to the cart
        static void AddProductToCart()
        {
            Console.Write("Enter product ID: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            ProductRepository productRepo = new ProductRepository();
            productRepo.AddToCart(productId, username, quantity);

            Console.WriteLine("Product added to cart successfully!");
        }

        // Method to view the cart for a user
        static void ViewCart()
        {
            Console.Write("Enter your username to view cart: ");
            string username = Console.ReadLine();

            CartRepository cartRepo = new CartRepository();
            DataTable cartDetails = cartRepo.ViewCart(username);

            Console.WriteLine("Your Cart:");
            foreach (DataRow row in cartDetails.Rows)
            {
                Console.WriteLine($"Product ID: {row["ProductId"]}, Name: {row["ProductName"]}, Quantity: {row["Quantity"]}, Total Price: {row["TotalPrice"]}");
            }
        }
    }
}
