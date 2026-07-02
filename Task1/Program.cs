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
        
        //2-Sum of Numbers 1 to N
        Console.WriteLine("Enter a positive whole number N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("The sum is: "+sum);
    }
}
