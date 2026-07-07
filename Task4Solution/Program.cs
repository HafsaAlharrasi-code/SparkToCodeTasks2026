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
        
        /*
        //2-Square Number Function
        Console.WriteLine("Enter your a number:");
        int userNumber = int.Parse(Console.ReadLine());
        int squaredNum = Square(userNumber);
        Console.WriteLine("The squared number is: " + squaredNum);
        Console.WriteLine();
        */
        
        /*
        //3-Celsius to Fahrenheit Function
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine("Fahrenheit temperature is: " + fahrenheit);
        Console.WriteLine();
        */
        
        //4-Fixed Menu Display Function
        DisplayMenu();
        Console.WriteLine();
    }
    
    /*
    //1-Personalized Welcome Function
    static void PrintWelcome(string userName)
    {
        Console.WriteLine("Welcome, " + userName);
    }
    */
    
    /*
    //2-Square Number Function
    static int Square(int number)
    {
        return (number * number);
    }
    */
    
    /*
    static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9) / 5 + 32; 
        return fahrenheit;
    }
    */
    
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1) Start");
        Console.WriteLine("2) Help");
        Console.WriteLine("3) Exit");
    }
    
    
    
}