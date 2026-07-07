namespace Task4Solution;

class Program
{
    static void Main(string[] args)
    {
       
        //1- Personalized Welcome Function
        static void PrintWelcome(string userName)
        {
            Console.WriteLine("Welcome, " + userName);
        }
        
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        PrintWelcome(name);
        Console.WriteLine();
    }
}