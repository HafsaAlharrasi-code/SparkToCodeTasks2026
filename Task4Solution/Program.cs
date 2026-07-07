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
        
        /*
        //4-Fixed Menu Display Function
        DisplayMenu();
        Console.WriteLine();
        */
        
        /*
        //5-Even or Odd Function
        Console.WriteLine("Enter an ineger: ");
        int number = int.Parse(Console.ReadLine());
        bool isEven = IsEven(number);

        if (isEven)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
        */
        
        //6-Rectangle Area & Perimeter Functions
        Console.WriteLine("Enter the length: ");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width: ");
        double width = double.Parse(Console.ReadLine());
        double area = CalculateArea(length, width);
        double perimeter = CalculatePerimeter(length, width);
        Console.WriteLine("The area is: " + area);
        Console.WriteLine("The perimeter is: " + perimeter);
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
    
    /*
    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1) Start");
        Console.WriteLine("2) Help");
        Console.WriteLine("3) Exit");
    }
    */

    /*
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    */
    
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }
    
    
    
    
}