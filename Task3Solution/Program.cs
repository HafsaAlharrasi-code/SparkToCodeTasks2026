namespace Task3Solution;

class Program
{
    static void Main(string[] args)
    {
        
        //1- Absolute Difference
        
        Console.WriteLine("Enter a number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        double number2 = double.Parse(Console.ReadLine());
        
        double result = number1 - number2;
        double absResult = Math.Abs(result);
        Console.WriteLine("The subtraction result is: "+absResult);
        
    }
}