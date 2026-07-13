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