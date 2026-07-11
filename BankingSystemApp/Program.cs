using System;
using System.Collections.Generic;
namespace BankingSystemApp {
        internal class Program {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
        bool exitApp = false;
        while (!exitApp)
        {
        Console.WriteLine("\n===== Welcome to Spark Bank =====");
        Console.WriteLine("1. Add New Account");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Show Balance");
        Console.WriteLine("5. Transfer Amount");
        Console.WriteLine("6. <your 1st custom service - choose a name>");
        Console.WriteLine("7. <your 2nd custom service - choose a name>");
        Console.WriteLine("8. Exit");
        Console.Write("Choose an option: ");
        int choice;
        try
        {
            choice = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
            continue; // skip the rest of this loop pass, show the menu again
        } 

        switch (choice){
        case 1:
        AddAccount();
        break;
        case 2:
        DepositMoney();
        break;
        case 3:
        WithdrawMoney();
        break;
        case 4:
        ShowBalance();
        break;
        case 5:
        TransferAmount();
        break;
        case 6:
        // TODO: call your first custom service function here
        DeleteAccount();
        break;
        case 7:
        // TODO: call your second custom service function here
        break;
        case 8:
        exitApp = true;
        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
        break;
        default:
        Console.WriteLine("Invalid option, please choose between 1 and 8.");
        break;
        } 
    }
}
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Error: Customer already exists.");
                return;
            }
            Console.WriteLine("Enter initial deposit amount: ");
            double initialAmount = double.Parse(Console.ReadLine());
            if (initialAmount < 0)
            {
                Console.WriteLine("Error: Initial deposit cannot be negative.");
                return;
            }
            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(initialAmount);
            Console.WriteLine("Account successfully created ");
        }

        static void DepositMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);
            if (index == -1)
            {
                Console.WriteLine("Error: Account number not found");
                return;
            }
            Console.WriteLine("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());
            if (depositAmount < 0)
            {
                Console.WriteLine("Error: Deposit amount cannot be negative.");
                return;
            }
            balances[index] += depositAmount;
            Console.WriteLine("Deposit successfully.");
            Console.WriteLine("New account balance is: " + balances[index]);
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);
            if (index == -1)
            {
                Console.WriteLine("Error: Account number not found");
                return;
            }
            Console.WriteLine("Enter withdraw amount: ");
            double withdrawAmount = double.Parse(Console.ReadLine());
            if ( withdrawAmount < 0)
            {
                Console.WriteLine("Error: withdraw amount cannot be negative");
                return;
            }

            if (withdrawAmount > balances[index])
            {
                Console.WriteLine("Error: Insufficient balance");
                return;
            }
            balances[index] -= withdrawAmount;
            Console.WriteLine("Withdraw successfully.");
            Console.WriteLine("New account balance is: " + balances[index]);
        }

        static void ShowBalance()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);
            if (index == -1)
            {
                Console.WriteLine("Error: Account number not found");
                return;
            }
            Console.WriteLine("Customer name: " + customerNames[index]);
            Console.WriteLine("Customer account number: " + accountNumbers[index]);
            Console.WriteLine("Balance: " + balances[index]);
        }

        static void TransferAmount()
        {
            Console.WriteLine("Enter sender's account number: ");
            string senderAccountNumber = Console.ReadLine();
            int senderIndex = accountNumbers.IndexOf(senderAccountNumber);
            
            Console.WriteLine("Enter receiver's account number: ");
            string receiverAccountNumber = Console.ReadLine();
            int receiverIndex = accountNumbers.IndexOf(receiverAccountNumber);

            if (receiverIndex == -1 || senderIndex == -1)
            {
                Console.WriteLine("Error: Account number not found");
                return;
            }
            Console.WriteLine("Enter transfer amount: " );
            double transferAmount = double.Parse(Console.ReadLine());
            if (transferAmount < 0)
            {
                Console.WriteLine("Error: Transfer amount cannot be negative");
                return;
            }

            if (transferAmount > balances[senderIndex])
            {
                Console.WriteLine("Error: Insufficient balance");
                return;
            }
            balances[senderIndex] -= transferAmount;
            balances[receiverIndex] += transferAmount;
            Console.WriteLine("Transfer successfully.");
            Console.WriteLine("Sender account is: " + accountNumbers[senderIndex]+" New balance:"+ balances[senderIndex]);
            Console.WriteLine("Sender account is: " + accountNumbers[receiverIndex]+" New balance:"+ balances[receiverIndex]);

        }
        // your own custom services (option 6 and option 7)
        
        static void DeleteAccount()
        {
            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("No accounts in the system");
                return;
            }
            
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);
            if (index == -1)
            {
                Console.WriteLine("Error: Account number not found");
                return;
            }
            Console.WriteLine("Are you sure to delete account number " +accountNumbers[index] +"(yes/no): ");
            string confirm = Console.ReadLine().ToLower();
            if (confirm == "yes")
            {
                customerNames.RemoveAt(index);
                accountNumbers.RemoveAt(index);
                balances.RemoveAt(index);
                Console.WriteLine("Account successfully deleted.");
            }
            
        }
    }
}