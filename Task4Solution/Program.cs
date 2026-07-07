namespace Task4Solution;

class Program
{
    static void Main(string[] args)
    {
        /*
        //1-Personalized Welcome Function
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        PrintWelcome(name);
        Console.WriteLine();
        */
        
        //2-Square Number Function
        Console.WriteLine("Enter your a number:");
        int userNumber = int.Parse(Console.ReadLine());
        int squaredNum = Square(userNumber);
        Console.WriteLine("The squared number is: " + squaredNum);
        Console.WriteLine();
    }
    
    /*
    //1-Personalized Welcome Function
    static void PrintWelcome(string userName)
    {
        Console.WriteLine("Welcome, " + userName);
    }
    */
    
    //2-Square Number Function
    static int Square(int number)
    {
        return (number * number);
    }
    
    
}