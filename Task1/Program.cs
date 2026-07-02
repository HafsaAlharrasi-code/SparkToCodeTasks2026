namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        
        //1- Countdown Timer
        Console.WriteLine("Enter a starting number:");
        int startNumber = int.Parse(Console.ReadLine());
        for (int i = startNumber; i >=1 ; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Liftoff");
    }
}
