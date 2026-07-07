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
        
        /*
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
        */
        
        /*
        //7-Grade Letter Function
        Console.WriteLine("Enter your score (0-100): ");
        int score = int.Parse(Console.ReadLine());
        string grade = GetGradeLetter(score);
        Console.WriteLine("Your grade is: " + grade);
        Console.WriteLine();
        */
        
        /*
        //8-Countdown Function
        Console.WriteLine("Enter a starting number: ");
        int startNum = int.Parse(Console.ReadLine());
        Countdown(startNum);
        Console.WriteLine();
        */
        
        //9-Overloaded Multiply Function
        Console.WriteLine("Multiply int * int (4*20): " + Multiply(4, 20));
        Console.WriteLine("Multiply double * double (5.5*12.6): " + Multiply(5.5, 12.6));
        Console.WriteLine("Multiply int * int * int (5*7*9): " + Multiply(5, 7, 9));
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
    
    /*
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static double CalculatePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }
    */
    
    /*
    static string GetGradeLetter(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
    */
    
    /*
    static void Countdown(int start)
    {
        for (int i = start; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
    */
    
    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static int Multiply(int num1, int num2, int num3)
    {
        return num1 * num2 * num3;
    }
    
    
    
    
    
    
}