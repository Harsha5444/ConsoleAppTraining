using System;
namespace CApractice
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        // Constructor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class ShoppingCart
    {
        private Product[] cart;
        private int itemCount;
        private double totalCost;

        // Constructor
        public ShoppingCart()
        {
            cart = new Product[10]; // Fixed size for simplicity
            itemCount = 0;
            totalCost = 0;
        }

        // Add product to cart
        public void AddProduct(Product product, int quantity)
        {
            if (itemCount >= cart.Length)
            {
                Console.WriteLine("Cart is full!");
                return;
            }

            cart[itemCount] = product;
            itemCount++;
            totalCost += product.Price * quantity;
            Console.WriteLine($"Added {quantity} x {product.Name} to the cart.\n");
        }

        // Display cart contents
        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart Contents:");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"- {cart[i].Name}: ${cart[i].Price}");
            }
            Console.WriteLine($"Total Cost: ${totalCost}\n");
        }

        // Remove product by name
        public void RemoveProduct(string productName)
        {
            bool found = false;

            for (int i = 0; i < itemCount; i++)
            {
                if (cart[i].Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    totalCost -= cart[i].Price;
                    found = true;

                    // Shift remaining items
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        cart[j] = cart[j + 1];
                    }

                    itemCount--;
                    cart[itemCount] = null;
                    Console.WriteLine($"Removed {productName} from the cart.\n");
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Product {productName} not found in the cart.\n");
            }
        }
    }

    class Shopping
    {
        static void Main(string[] args)
        {
            // Predefined products
            Product[] products = new Product[]
            {
            new Product("Apple", 1.5),
            new Product("Banana", 0.8),
            new Product("Orange", 1.2),
            new Product("Milk", 2.5),
            new Product("Bread", 1.8)
            };

            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("Welcome to the Store! Choose an option:");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Add Product to Cart");
                Console.WriteLine("3. Remove Product from Cart");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Available Products:");
                        for (int i = 0; i < products.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {products[i].Name} - ${products[i].Price}");
                        }
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.Write("Enter the product number to add: ");
                        int productNumber = int.Parse(Console.ReadLine()) - 1;

                        if (productNumber < 0 || productNumber >= products.Length)
                        {
                            Console.WriteLine("Invalid product number!\n");
                            break;
                        }

                        Console.Write("Enter quantity: ");
                        int quantity = int.Parse(Console.ReadLine());

                        cart.AddProduct(products[productNumber], quantity);
                        break;

                    case "3":
                        Console.Write("Enter the product name to remove: ");
                        string productName = Console.ReadLine();
                        cart.RemoveProduct(productName);
                        break;

                    case "4":
                        cart.DisplayCart();
                        break;

                    case "5":
                        Console.WriteLine("Thank you for shopping with us! Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            }
        }
    }

}
