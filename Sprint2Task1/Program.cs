namespace Sprint2Task1;

class Program
{
    static void Main(string[] args)
    {
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