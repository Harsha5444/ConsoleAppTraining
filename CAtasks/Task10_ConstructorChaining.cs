using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAtasks
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }

        // Default constructor
        public BankAccount()
        {
            AccountNumber = "000000";
            Balance = 0;
            Console.WriteLine("Default constructor: Basic account initialized.");
        }

        // Constructor with account holder name
        public BankAccount(string accountHolder) : this() // Calls the default constructor
        {
            AccountHolder = accountHolder;
            Console.WriteLine($"Constructor with account holder: Account initialized for {AccountHolder}.");
        }

        // Constructor for a specific account type and initial balance
        public BankAccount(string accountHolder, string accountType, decimal initialBalance)
            : this(accountHolder) // Calls the constructor with account holder
        {
            AccountType = accountType;
            Balance = initialBalance;
            Console.WriteLine($"Constructor with account details: {AccountType} account initialized with balance {Balance:C}.");
        }

        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}, Type: {AccountType}, Balance: {Balance:C}";
        }
    }

    class Task10_ConstructorChaining
    {
        static void Main()
        {
            Console.WriteLine("Creating a basic account:");
            BankAccount account1 = new BankAccount();
            Console.WriteLine(account1);

            Console.WriteLine("\nCreating an account for a specific user:");
            BankAccount account2 = new BankAccount("Alice");
            Console.WriteLine(account2);

            Console.WriteLine("\nCreating a premium account with initial deposit:");
            BankAccount account3 = new BankAccount("Bob", "Premium", 1000.00m);
            Console.WriteLine(account3);
        }
    }
}




