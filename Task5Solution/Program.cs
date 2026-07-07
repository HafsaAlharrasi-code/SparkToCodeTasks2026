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
        
        /*
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
        */
        
        /*
        //3-Browsing History Stack
        Stack<string> history = new Stack<string>();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter website URL: ");
            string websiteURL = Console.ReadLine();
            history.Push(websiteURL);
        }
        string backPage = history.Pop();
        Console.WriteLine("You pressed back and landed on:" + backPage);
        */
        
        /*
        //4-Customer Service Queue
        Queue<string> customers =  new Queue<string>();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter customer name:");
            string customerName = Console.ReadLine();
            customers.Enqueue(customerName);
        }
        string servedCustomer = customers.Dequeue();
        Console.WriteLine("Served the customer: "+servedCustomer);
        */
        
        /*
        //5-Array Grade Range
        int[] grades = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter a grade: ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(grades);
        int lowestGrade = grades[0];
        int highestGrade = grades[grades.Length - 1];

        int sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        double averageGrade = sum / grades.Length;
        
        Console.WriteLine("The lowest grade is: " + lowestGrade);
        Console.WriteLine("The highest grade is: " + highestGrade);
        Console.WriteLine("The average grade is: " + averageGrade);
        */
        
        //6-Filtered Shopping List
        List<string> shoppingList = new List<string>();
        
        while (true)
        {
            Console.WriteLine("Enter an item or done to stop: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            else
            {
                shoppingList.Add(input);
            }
        }
        Console.WriteLine("Your shopping list is: " );
        foreach (string shoppingItem in shoppingList)
        {
            Console.WriteLine(shoppingItem);
        }
        
        Console.WriteLine("Enter an item to remove: ");
        string removeItem = Console.ReadLine();
        shoppingList.Remove(removeItem);
        Console.WriteLine("Your shopping list after removal is: " );
        foreach (string shoppingItem in shoppingList)
        {
            Console.WriteLine(shoppingItem);
        }
        
    }
}