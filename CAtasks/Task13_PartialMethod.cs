using System;

namespace CAtasks
{
    // Partial class (Part 1)
    partial class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        // Declaration of a partial method
        partial void OnPriceUpdated();

        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;

            // Call the partial method
            OnPriceUpdated();
        }
    }

    // Partial class (Part 2)
    partial class Product
    {
        // Implementation of the partial method
        partial void OnPriceUpdated()
        {
            Console.WriteLine($"The price of {ProductName} has been updated to: ${Price}");
        }
    }

    // Program
    class Task13_PartialMethod
    {
        static void Main(string[] args)
        {
            Product product = new Product { ProductName = "Laptop", Price = 1000 };

            // Update the price
            product.UpdatePrice(1200);
        }
    }
}
