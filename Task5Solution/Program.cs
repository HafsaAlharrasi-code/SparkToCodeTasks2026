namespace Task5Solution;

class Program
{
    static void Main(string[] args)
    {
        /*
        //1-Fixed Grades Array
        int[] grades = new int[5];
        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine("Enter grade: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Grades: ");
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        */
        
        //2-Dynamic To-Do List
        List<string> toDo = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter a task: ");
            toDo.Add(Console.ReadLine());
        }
        
        Console.WriteLine("Your To-Do list: ");

        foreach (string task in toDo)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine();
    }
}