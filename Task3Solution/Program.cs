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
        
        /*
        //3- Name Formatter
        Console.WriteLine("Enter your full name: ");
        string fullName = Console.ReadLine();
        string upperFullName = fullName.ToUpper();
        string lowerFullName = fullName.ToLower();
        int numberOfChars = fullName.Length;
        
        Console.WriteLine("Name in UpperCase: "+upperFullName);
        Console.WriteLine("Name in LowerCase: "+lowerFullName);
        Console.WriteLine("The full name contain " + numberOfChars + " characters");
        */
        
        /*
        //4- Subscription End Date
        Console.WriteLine("Please enter the number of days of a free trial: ");
        int freeTrailDays = int.Parse(Console.ReadLine());
        DateTime startDate = DateTime.Today;
        DateTime endDate = startDate.AddDays(freeTrailDays);
        Console.WriteLine("The End Date is " + endDate.ToString("dd/MM/yyyy"));
        */
        
        /*
        //5-Grade Rounding System
        Console.WriteLine("Enter your raw exam score:");
        double examScore = double.Parse(Console.ReadLine());
        double roundedExamScore = Math.Round(examScore);
        Console.WriteLine("Your rounder exam score is: " + roundedExamScore);
        
        if (roundedExamScore >= 60)
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }
        */
        
        /*
        //6-Password Strength Checker
        Console.WriteLine("Enter a password: ");
        string password = Console.ReadLine();
        int passwordLength = password.Length;

        if ( (passwordLength >= 8) && !( password.ToLower().Contains("password") ) )
        {
            Console.WriteLine("The password is Strong");
        }
        else
        {
            Console.WriteLine("The password is Weak");
        }
        */
        
        /*
        //7- Clean Name Comparator
        Console.WriteLine("Enter your name:");
        string name1 = Console.ReadLine();
        Console.WriteLine("Enter your name again:");
        string name2 = Console.ReadLine();
        
        string name1afterTrimmed = name1.Trim().ToLower();
        string name2afterTrimmed = name2.Trim().ToLower();

        if (name1afterTrimmed == name2afterTrimmed)
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("No match");
        }
        */
        
        /*
        //8-Membership Expiry Checker
        Console.WriteLine("Enter your membership start date(YYYY-MM-DD): )");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of valid membership days: ");
        int validDays = int.Parse(Console.ReadLine());
        DateTime endDate = startDate.AddDays(validDays);
        DateTime today = DateTime.Today;
        
        Console.WriteLine("Your membership expiry date is: " + endDate );

        if (endDate < today)
        {
            Console.WriteLine("Your membership is Expired");
        }
        else
        {
            Console.WriteLine("Your membership is Active");
        }
        */
        
        //9-Round Up / Round Down Explorer
        Console.WriteLine("Enter a decimal number: ");
        double number = double.Parse(Console.ReadLine());

        double roundedToNearest = Math.Round(number);
        double roundedUp = Math.Ceiling(number);
        double roundedDown = Math.Floor(number);
        
        Console.WriteLine("rounded to NEAREST result: " + roundedToNearest);
        Console.WriteLine("rounded to UP result: " + roundedUp);
        Console.WriteLine("rounded to DOWN result: " + roundedDown);
        
    }
}