namespace Sprint2Task1;

class Program
{
    static BankAccount account1 = new BankAccount();
    static BankAccount account2 = new BankAccount();
    static Student student1 = new Student();
    static Student student2 = new Student();
    static Product product1 = new Product();
    static Product product2 = new Product();
    
    
    static void Main(string[] args)
    {
        account1.AccountNumber = 1163;
        account1.HolderName = "karim";
        account1.Balance = 120;
        
        account2.AccountNumber = 15203;
        account2.HolderName = "Ali";
        account2.Balance = 63;
        
        student1.Name = "Ali";
        student1.Address = "Muscat";
        student1.Grade = 65;
        
        student2.Name = "Ahmed";
        student2.Address = "Muscat";
        student2.Grade = 70;

        product1.ProductName = "Wireless Mouse";
        product1.Price = 5.500;
        product1.StockQuantity = 50;
        
        product2.ProductName = "Mechanical Keyboard";
        product2.Price = 15.750;
        product2.StockQuantity = 20;
        
        bool exitApp = false;
        while (exitApp == false)
        {
            Console.WriteLine(" 1. View Account Details");
            Console.WriteLine(" 2. Update Student Address");
            Console.WriteLine(" 3. Make a Deposit");
            Console.WriteLine(" 4. Make a Withdrawal");
            Console.WriteLine(" 5. View Product Details");
            Console.WriteLine(" 6. Register a Student");
            Console.WriteLine(" 7. Compare Two Account Balances");
            Console.WriteLine(" 8. Restock Product & Stock Level Check");
            Console.WriteLine(" 9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade (Validated)");
            Console.WriteLine("11. Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale With Revenue Calculation");
            Console.WriteLine("14. Scholarship Eligibility Check");
            Console.WriteLine("15. Full Balance Top-Up Flow");
            Console.WriteLine("16. Quick Account Opening ");
            Console.WriteLine("17. Total Students Counter ");
            Console.WriteLine("18. Overdrawn Account Check ");
            Console.WriteLine("19. Set Student Security PIN )");
            Console.WriteLine("20. Exit");
            Console.Write("Choose an option: ");
            
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Enter a number from 1 to 20.");
                continue;
            }
        }

    }

    static BankAccount SelectAccount()
    {
        Console.WriteLine("Select an account:");
        Console.WriteLine("1)Account: 1163, karim");
        Console.WriteLine("2)Account: 15203, Ali");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            return account1;
        }
        else
        {
            return account2;
        }
    }
    static Student SelectStudent()
    {
        Console.WriteLine("Select a student:");
        Console.WriteLine("1)Student: Ali");
        Console.WriteLine("2)Student: Ahmed");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            return student1;
        }
        else
        {
            return student2;
        }
    }
    static Product SelectProduct()
    {
        Console.WriteLine("Select a student:");
        Console.WriteLine("1)ProductName: Wireless Mouse");
        Console.WriteLine("2)ProductName: Mechanical Keyboard");
        Console.Write("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            return product1;
        }
        else
        {
            return product2;
        }
    }
    
    //Case1- View Account Details
    static void ViewAccountDetails()
    {
        BankAccount acc = SelectAccount();
        if (acc != null)
        {
            acc.CheckBalance();
        }
    }
    
    //Case2- Update Student Address
    static void UpdateStudentAddress()
    {
        Student student = SelectStudent();
        if (student != null)
        {
            Console.Write("Enter new address: ");
            string newAddress = Console.ReadLine();
            student.Address = newAddress;
            Console.WriteLine("Address updated successfully. New address: " + student.Address);
        }
    }
    
    //Case3- Make a Deposit
    static void MakeDeposit()
    {
        BankAccount acc = SelectAccount();
        if (acc != null)
        {
            Console.Write("Enter amount to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount > 0)
            {
                acc.Deposit(amount);
                Console.WriteLine("Deposit successful. " + acc.HolderName + "'s new balance is: " + acc.Balance);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }
    }
    
    //Case4- Make a Withdrawal
    static void MakeWithdrawal()
    {
        BankAccount acc = SelectAccount();
        if (acc != null)
        {
            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            if (amount > 0)
            {
                acc.Withdraw(amount);
                Console.WriteLine("Withdrawal successful. New balance: " + acc.Balance);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }
    }


}

public class BankAccount
{
    public int AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }
    
    public void Deposit(double amount)
    {
        Balance += amount;
        SendEmail();
    }
    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        SendEmail();
    }
    public double CheckBalance()
    {
        PrintInformation();
        return Balance;
    }
    private void PrintInformation()
    {
        Console.WriteLine("Name : " + HolderName);
        Console.WriteLine("Balance: " + Balance);
    }
    private void SendEmail(){}
}

public class Student
{
    public int Grade { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    private string email { get; set; }
    int age { get; set; }
    
    public void Register(string Email)
    {
        email = Email;
        SendEmail();
    }
    private void SendEmail(){}
}

public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int StockQuantity { get; set; }
    
    public void Sell(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
        }
        else
        {
            Console.WriteLine("No enough stock available");
        }
        LogTransaction();
    }
    public void Restock(int quantity)
    {
        StockQuantity += quantity;
        LogTransaction();
    }
    public double GetInventoryValue()
    {
        PrintDetails();
        return Price * StockQuantity;
    }
    private void PrintDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock Quantity: " + StockQuantity);
    }
    private void LogTransaction(){}
}