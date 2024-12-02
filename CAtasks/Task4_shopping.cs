using System;
using System.ComponentModel.Design;

namespace CAtasks
{
    class Task4_shopping
    {
        static void Main(string[] args)
        {
            int cartValue = 0;
            productList: 
            Console.WriteLine($"This Is The Product List: ");
            Console.WriteLine($"1. Oneplus 11R - 35,000");
            Console.WriteLine($"2. IPhone 16 Plus - 65,000");
            Console.WriteLine($"3. Redmi 14 - 30,000");
            Console.WriteLine($"4. Vivo - 23,000");
            Console.WriteLine($"5. Oppo - 20,000");
            Selection:
            Console.WriteLine($"Select any product (1, 2, 3, 4, 5): ");
            int product = Convert.ToInt32(Console.ReadLine());
            switch (product)
            {
                case 1:
                    cartValue += 35000;
                    break;
                case 2:
                    cartValue += 65000;
                    break;
                case 3:
                    cartValue += 30000;
                    break;
                case 4:
                    cartValue += 23000;
                    break;
                case 5:
                    cartValue += 20000;
                    break;
                default:
                    Console.WriteLine($"Please Enter correct Product ID..!");
                    goto Selection;
            }
            Console.WriteLine($"Do you want to add more items to cart (Yes/no): ");
            string answer = Console.ReadLine();
            if (answer == "yes")
                goto productList;
            else
            {
                Console.WriteLine($"Thanks for shopping with us...!");
                Console.WriteLine($"Your Total cart Value is: {cartValue}");
            }
            Console.Read();
        }
    }
}

