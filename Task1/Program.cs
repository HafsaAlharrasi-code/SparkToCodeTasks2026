namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        /*
        //1- Countdown Timer
        Console.WriteLine("Enter a starting number:");
        int startNumber = int.Parse(Console.ReadLine());
        for (int i = startNumber; i >=1 ; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Liftoff");
        */
        
        /*
        //2-Sum of Numbers 1 to N
        Console.WriteLine("Enter a positive whole number N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum is: "+sum);
        */
        
        /*
        //3-Multiplication Table
        Console.WriteLine("Please enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10 ; i++)
        {
            Console.WriteLine(userNumber + "*" + i + "=" + (userNumber * i) );
        }      
        */
        
        /*
        //4-Password Retry
        Console.WriteLine(" Enter the password: ");
        string password = Console.ReadLine();
        string correctPassword = "Spark2026";

        while (correctPassword != password)
        {
            Console.WriteLine("Wrong password, try again:");
            password = Console.ReadLine();
        }
        Console.WriteLine("Access Granted");
        
        */
        
        /*
        //5-Number Guessing Game
        int secretNumber = 42;
        int attempts = 0;
        int guessedNumber;
        
        do
        {
            Console.WriteLine("Guess the number:");
            guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber > secretNumber)
            {
                Console.WriteLine("Too high");
            }
            else if (guessedNumber < secretNumber)
            {
                Console.WriteLine("Too low");
            }
            else
            {
                Console.WriteLine("Correct");
            }
            attempts++;
        } 
        while (guessedNumber != secretNumber);
        */
        
        //6-Safe Division Calculator
        try
        {
            Console.WriteLine("Enter the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double result = (firstNumber / secondNumber);
            Console.WriteLine("The result is: " + result);

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: you cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: invalid input");
        }
        
    }
}
