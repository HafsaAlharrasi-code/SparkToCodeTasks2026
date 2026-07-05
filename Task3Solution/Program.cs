namespace Task3Solution;

class Program
{
    static void Main(string[] args)
    {
        /*
        //1- Absolute Difference
        
        Console.WriteLine("Enter a number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        double number2 = double.Parse(Console.ReadLine());
        
        double result = number1 - number2;
        double absResult = Math.Abs(result);
        Console.WriteLine("The subtraction result is: "+absResult);
        */
        
        /*
        //2- Power & Root Explorer
        Console.WriteLine("Please enter a number:");
        double number = double.Parse(Console.ReadLine());
        double sqrtOfNumber = Math.Sqrt(number);
        double powerOfTwo = Math.Pow(number, 2);
        Console.WriteLine("The square root of " + number + " is " + sqrtOfNumber);
        Console.WriteLine("The square of " + number + " is " + powerOfTwo);
        */
        
        //3- Name Formatter
        Console.WriteLine("Enter your full name: ");
        string fullName = Console.ReadLine();
        string upperFullName = fullName.ToUpper();
        string lowerFullName = fullName.ToLower();
        int numberOfChars = fullName.Length;
        
        Console.WriteLine("Name in UpperCase: "+upperFullName);
        Console.WriteLine("Name in LowerCase: "+lowerFullName);
        Console.WriteLine("The full name contain " + numberOfChars + " characters");
        
    }
}