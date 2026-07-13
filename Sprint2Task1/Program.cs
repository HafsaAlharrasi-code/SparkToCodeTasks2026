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
            
            switch (choice)
            {
                case 1: ViewAccountDetails(); break;
                case 2: UpdateStudentAddress(); break;
                case 3: MakeDeposit(); break;
                case 4: MakeWithdrawal(); break;
                case 5: ViewProductDetails(); break;
                case 6: RegisterStudent(); break;
                case 7: CompareAccountBalances(); break;
                case 8: RestockProduct(); break;
                case 9: TransferBetweenAccounts(); break;
                case 10: UpdateStudentGrade(); break;
                case 11: StudentReportCard(); break;
                case 12: AccountHealthStatus(); break;
                case 13: BulkSaleWithRevenue(); break;
                case 14: ScholarshipEligibilityCheck(); break;
                case 15: FullBalanceTopUpFlow(); break;
                case 16: QuickAccountOpening(); break;
                case 17: TotalStudentsCounter(); break;
                case 18: OverdrawnAccountCheck(); break;
                case 19: SetStudentSecurityPin(); break;
                case 20:
                    exitApp = true;
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose between 1 and 20.");
                    break;
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

    //Case5- View Product Details
    static void ViewProductDetails()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            double value = product.GetInventoryValue();
            Console.WriteLine("Total Inventory Value: " + value);
        }
    }
    
    //Case6- Register a Student
    static void RegisterStudent()
    {
        Student student = SelectStudent();
        if (student != null)
        {
            Console.Write("Enter an email: ");
            string email = Console.ReadLine();
            student.Register(email);
            Console.WriteLine("Student registered successfully.");
        }
    }
    
    //Case7- Compare Two Account Balances
    static void CompareAccountBalances()
    {
        Console.WriteLine("Comparing the 2 accounts balances: ");
        Console.WriteLine(account1.HolderName + ": " + account1.Balance);
        Console.WriteLine(account2.HolderName + ": " + account2.Balance);

        if (account1.Balance > account2.Balance)
        {
            Console.WriteLine(account1.HolderName + " has more money.");
        }
        else if (account2.Balance > account1.Balance)
        {
            Console.WriteLine(account2.HolderName + " has more money.");
        }
        else
        {
            Console.WriteLine("Both accounts have equal balances.");
        }
    }
    
    //Case8- Restock Product & Stock Level Check
    static void RestockProduct()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            Console.Write("Enter quantity to add: ");
            int quantity = int.Parse(Console.ReadLine());
            if (quantity > 0)
            {
                product.Restock(quantity);
                Console.WriteLine("Restock complete. New stock: " + product.StockQuantity);
                if (product.StockQuantity < 10)
                {
                    Console.WriteLine("Stock Level: Low");
                }
                else if (product.StockQuantity >= 10 && product.StockQuantity <= 49)
                {
                    Console.WriteLine("Stock Level: Moderate");
                }
                else
                {
                    Console.WriteLine("Stock Level: Well Stocked");
                }
            }
            else
            {
                Console.WriteLine("Invalid quantity. Please enter a positive number.");
            }
        }
    }
    
    //Case9- Transfer Between Accounts
    static void TransferBetweenAccounts()
    {
        Console.WriteLine("Select source account:");
        BankAccount source = SelectAccount();
        if (source == null) return;
        
        Console.WriteLine("Select destination account:");
        BankAccount destination = SelectAccount();
        if (destination == null) return;
        
        Console.Write("Enter amount to transfer: ");
        double amount = double.Parse(Console.ReadLine());
        if (amount > 0)
        {
            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
                Console.WriteLine("Transfer successful");
            }
            else
            {
                Console.WriteLine("Transfer failed. Insufficient balance");
            }
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
        }
        
    }
    
    //case10- Update Student Grade (Validated)
    static void UpdateStudentGrade()
    {
        Student student = SelectStudent();
        if (student != null)
        {
            Console.WriteLine("Enter new grade (0-100): ");
            int newGrade = int.Parse(Console.ReadLine());
            if (newGrade >= 0 && newGrade <= 100)
            {
                student.Grade = newGrade;
                Console.WriteLine("Grade updated successfully. New grade: " + student.Grade);
            }
            else
            {
                Console.WriteLine("Invalid grade. Must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    
    //Case11- Student Report Card
    static void StudentReportCard()
    {
        Student student = SelectStudent();
        if (student != null)
        {
            Console.WriteLine("STUDENT REPORT CARD");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Grade: " + student.Grade);
            if (student.Grade >= 60)
            {
                Console.WriteLine("Status: PASS ");
            }
            else
            {
                Console.WriteLine("Status: FAIL ");
            }
        }
    }
    
    //Case12- Account Health Status
    static void AccountHealthStatus()
    {
        BankAccount acc = SelectAccount();
        if (acc != null)
        {
            Console.WriteLine("Balance: " + acc.Balance);
            if (acc.Balance < 50)
            {
                Console.WriteLine("Status: Low Balance");
            }
            else if (acc.Balance >= 50 && acc.Balance <= 1000)
            {
                Console.WriteLine("Status: Healthy");
            }
            else
            {
                Console.WriteLine("Status: Premium");
            }
        }
    }
    
    //Case13- Bulk Sale With Revenue Calculation
    static void BulkSaleWithRevenue()
    {
        Product product = SelectProduct();
        if (product != null)
        {
            Console.Write("Enter quantity to sell: ");
            int quantity = int.Parse(Console.ReadLine());
            if (product.StockQuantity >= quantity)
            {
                product.Sell(quantity);
                double revenue = quantity * product.Price;
                Console.WriteLine("Sale completed successfully");
                Console.WriteLine("Total revenue from sale: " + revenue);
            }
            else
            {
                int needed = quantity - product.StockQuantity;
                Console.WriteLine("Sale failed. Insufficient balance, " + needed + "more stock needed");
            }
        }
        else
        {
            Console.WriteLine("Invalid quantity. Please enter a positive number.");
        }
    }
    
    //Case14- Scholarship Eligibility Check
    static void ScholarshipEligibilityCheck()
    {
        Student student = SelectStudent();
        if (student == null) return;
        BankAccount acc = SelectAccount();
        if (acc == null) return;

        if ((student.Grade>=80) && (acc.Balance>=100))
        {
            Console.WriteLine("Eligible:");
        }
        else
        {
            Console.WriteLine("Not Eligible:");
            if (student.Grade < 80)
            {
                Console.WriteLine("Grade must be 80 or above");
            }
            if (acc.Balance <100)
            {
                Console.WriteLine("Account balance must be 100 or above ");
            }
        }
    }
    
    //Case15- Full Balance Top-Up Flow
    static void FullBalanceTopUpFlow()
    {
        BankAccount acc = SelectAccount();
        if (acc == null)
        {
            double beforeBalance = acc.Balance;
            if (beforeBalance < 50)
            {
                double topUpAmount = 100 - beforeBalance;
                acc.Deposit(topUpAmount);
                Console.WriteLine("Top-up Done, Added: " + topUpAmount);
                Console.WriteLine("Balance before: " + beforeBalance);
                Console.WriteLine("Balance after: " + acc.Balance);
            }
            else
            {
                Console.WriteLine("No top-up needed. Balance is 50 or above.");
            }
        }
    }
    
    //Case16- Quick Account Opening [Parameterized Constructor]
    static void QuickAccountOpening()
    {
        Console.WriteLine("Enter account number: ");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter account holder name: ");
        string holderName = Console.ReadLine();
        Console.WriteLine("Enter starting balance: ");
        double balance = double.Parse(Console.ReadLine());
        if (balance < 0)
        {
            Console.WriteLine("Invalid balance. Please enter a positive number.");
            return;
        }
        
        BankAccount newAccount = new BankAccount(accountNumber, holderName, balance);
        Console.WriteLine("Account created successfully");
        Console.WriteLine("Account Number: " + newAccount.AccountNumber);
        Console.WriteLine("Holder Name: " + newAccount.HolderName);
        Console.WriteLine("Balance: " + newAccount.Balance);
    }
    
    //Case17- Total Students Counter [Static Fields & Methods]
    static void TotalStudentsCounter()
    {
        int total = Student.GetTotalStudents();
        Console.WriteLine("Total number of students: " + total);
        
    }
    
    //Case 18 - Overdrawn Account Check [Read-Only Property]
    static void OverdrawnAccountCheck()
    {
        BankAccount acc = SelectAccount();
        if (acc == null)
        {
            Console.WriteLine("Account: " + acc.HolderName);
            Console.WriteLine("Balance: " + acc.Balance);
            if (acc.IsOverdrawn)
            {
                Console.WriteLine("The account is Overdrawn");
            }
            else
            {
                Console.WriteLine("The account is NOT overdrawn:");
            }
            
        }
    }
    
    //Case19- Set Student Security PIN [Write-Only Property]
    static void SetStudentSecurityPin()
    {
        Student student = SelectStudent();
        if (student == null)
        {
            Console.WriteLine("Enter a 4-digit PIN : ");
            int pin = int.Parse(Console.ReadLine());
            student.SecurityPin = pin;
            Console.WriteLine("Security PIN set successfully.");
        }
        else
        {
            Console.WriteLine("Invalid PIN. Must be a 4-digit number");
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
    public BankAccount() { }    public bool IsOverdrawn
    {
        get { return Balance < 0; }
    }
    
    //for case 16
    public BankAccount(int accountNumber, string holderName, double balance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = balance;
    }
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
    
    private static int totalStudents = 0;
    public static int GetTotalStudents()
    {
        return totalStudents;
    }
    public Student()
    {
        totalStudents++;
    }
    
    private int securityPin;
    public int SecurityPin
    {
        set
        {
            if (value >= 1000 && value <= 9999)
            {
                securityPin = value;
            }
            else
            {
                Console.WriteLine("Invalid PIN. Must be a 4-digit number");
            }
        }
    }
    
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