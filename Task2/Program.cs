namespace Task2;

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

        /*
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
        */

        /*
        //7-Repeating Menu with Exit Option
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.WriteLine("MENU: ");
            Console.WriteLine("1) Say Hello");
            Console.WriteLine("2) Show Current Time-of-day Greeting");
            Console.WriteLine("3) Exit");
            Console.Write("Enter your choice: ");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello");
                        break;
                    case 2:
                        Console.WriteLine("Have a good day");
                        break;
                    case 3:
                        Console.WriteLine("Exiting the program");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 3.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid whole number");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex.Message);
            }
        }
        */

        /*
        //8- Sum of Even Numbers Only
        Console.WriteLine("Enter a positive whole number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine("The sum of positive numbers between 1 and " + number + " is: "+sum);
        */

        /*
        //9-Validated Positive Number Input
        int num = 0;
        bool isValidInput = false;

        do
        {
            Console.Write("Enter a positive whole number: ");
            try
            {
                num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    Console.WriteLine("Error: The number must be greater than zero");
                }
                else
                {
                    isValidInput = true;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid format.");
            }
        } while (!isValidInput);

        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum of all numbers from 1 to " +num+ " is:" + sum);
        */
    }
}