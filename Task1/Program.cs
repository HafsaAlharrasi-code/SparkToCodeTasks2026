namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        /*
        //1-personal info card
        string userName = "Hafsa";
        int age = 21;
        double gpa = 3.11;
        bool student = true;
        Console.WriteLine("Name: " + userName + " ,Age: "+ age +" ,GPA: "+gpa + " ,Student: "+student);
        //////////////////////////////////////
        */
        
        /*
        //2-Rectangle Calculator
        Console.WriteLine("Enter the length: ");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width: ");
        double width = double.Parse(Console.ReadLine());
        double area = (length * width);
        double perimeter = 2*(length + width);
        Console.WriteLine("The area is: " + area + " ,The perimeter is: " + perimeter);
        */
        
        /*
        //3-Even or Odd Checker
        Console.WriteLine("Please enter a number: ");
        double number = double.Parse(Console.ReadLine());
        double modResult = (number % 2);

        if (modResult == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
        */
        
        /*
        //4-Voting Eligibility
        Console.WriteLine("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Do you hold a valid national ID? (yes/no)");
        string nationalID = Console.ReadLine();
        bool hasNationalID = nationalID == "yes";

        if (age >= 18 && hasNationalID )
        {
            Console.WriteLine("Your are eligible to vote.");
        }
        else
        {
            Console.WriteLine("Your are not eligible to vote.");
        }
        */
        
        /*
        //5-Grade Letter Lookup
        Console.WriteLine("Enter your grade ('A', 'B', 'C', 'D', or 'F'):");
        string grade = Console.ReadLine();
        switch (grade) 
        {
            case "A":
                Console.WriteLine("Excellent");
                break;
            case "B":
                Console.WriteLine("Very Good");
                break;
            case "C":
                Console.WriteLine("Good");
                break;
            case "D":   
                Console.WriteLine("Pass");
                break;
            case "F":
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }
        */
        
        /*
        //6-Temperature Converter
        Console.WriteLine("Enter a temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit temperature is: " + fahrenheit);
        
        if (celsius < 10)
        {
            Console.WriteLine("Weather Classification is Cold");
        }
        else if (celsius >= 10 && celsius <= 30)
        {
            Console.WriteLine("Weather Classification is Mild");
        }
        else if (celsius >= 30)
        {
            Console.WriteLine("Weather Classification is Hot");
        }
        */
        
        /*
        //7- Movie Ticket Pricing
        Console.WriteLine("Please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        
        if (age > 0 && age <= 12)
        {
            Console.WriteLine("Children, Ticket price is 2.000 OMR");
        }
        else if (age >= 13 && age <= 59)
        {
            Console.WriteLine("Adults, Ticket price is 5.000 OMR");
        }
        else if (age > 59)
        {
            Console.WriteLine("Seniors, Ticket price is 3.000 OMR");
        }
        */
        
        /*
        //8-Restaurant Bill with Membership Discount
        Console.WriteLine("Please enter your total bill amount: ");
        double billAmount = double.Parse(Console.ReadLine());
        Console.WriteLine("Are you a loyalty member (yes/no).");
        string loyalMember = Console.ReadLine();
        bool isLoyaltyMember = loyalMember == "yes";

        double discountAmount = ( 0.15 * billAmount );
        double finalAmountToPay = (billAmount - discountAmount);
        
        if (billAmount > 20 && isLoyaltyMember)
        {
            Console.WriteLine("The original bill is: " + billAmount);
            Console.WriteLine("The discount amount is: " + discountAmount);
            Console.WriteLine("The final amount to pay is: " + finalAmountToPay);
        }
        else
        {
            Console.WriteLine("The original bill is: " + billAmount);
            Console.WriteLine("No discount");
            Console.WriteLine("The final amount to pay is: " + billAmount);
        }
        */
        
        /*
        //9-Day Name Finder
        Console.WriteLine("Enter a number from 1 to 7");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number");
                break;
        }
        */
        
        /*
        //10-Mini Calculator
        Console.WriteLine("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter operator character (+, -, *, /, or %): ");
        char operatorCharacter = char.Parse(Console.ReadLine());

        switch (operatorCharacter)
        {
            case '+':
                Console.WriteLine("Addition result: " + (firstNumber + secondNumber) );
                break;
            case '-':
                Console.WriteLine("Subtraction result: " + (firstNumber - secondNumber));
                break;
            case '*':
                Console.WriteLine("Multiplication result: " + (firstNumber * secondNumber));
                break;
            case '/':
                if ( secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                else
                {
                    Console.WriteLine("Division result: " + (firstNumber / secondNumber));
                }
                break;
            case '%':
                if ( secondNumber == 0)
                {
                    Console.WriteLine("Cannot modulus by zero");
                }
                else
                {
                    Console.WriteLine("modulus result: " + (firstNumber % secondNumber));
                }
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
                
        }
        */
        

    }
}