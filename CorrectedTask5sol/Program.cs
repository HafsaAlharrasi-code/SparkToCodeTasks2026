namespace CorrectedTask5sol;

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
        
        /*
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
        */
        
        /*
        //7-High Score Podium
        List<int> scores = new List<int>();
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Enter game score: ");
            int score = int.Parse(Console.ReadLine());
            scores.Add(score);
        }
        scores.Sort();
        scores.Reverse();
        int firstScore = scores[0];
        int secondScore = scores[1];
        int thirdScore = scores[2];
        Console.WriteLine("The first place score is: "+ firstScore);
        Console.WriteLine("The second place score is: " + secondScore);
        Console.WriteLine("The third place score is: " + thirdScore);
        */
        
        /*
        //8-Undo Last Action
        Stack<string> actions = new Stack<string>();
        while (true)
        {
            Console.Write("Enter an action or stop to finish: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "stop")
            {
                break;
            }
            else
            {
                actions.Push(input);
            }
        }
        Console.WriteLine("Undo 1: " + actions.Pop());
        Console.WriteLine("Undo 2: " + actions.Pop());
        Console.WriteLine("Remaining actions:");
        foreach (string action in actions)
        {
            Console.WriteLine(action);
        }
        */
        
        /*
        //9-Grade Analyzer with Functions
        Console.WriteLine("How many grades you want to enter?");
        int numberOfGrades = int.Parse(Console.ReadLine());
        List<int> gradesList = new List<int>();

        for (int i = 0; i < numberOfGrades; i++)
        {
            Console.WriteLine("Ener grade: ");
            gradesList.Add(int.Parse(Console.ReadLine()));
        }
        double averageGrade = CalculateAverage(gradesList);
        int failing = FindFirstFailing(gradesList);
        Console.WriteLine("The average is:  " + averageGrade);

        if (failing == 0)
        {
            Console.WriteLine("No failing grade found");
        }
        else
        {
            Console.WriteLine("First failing grade: " + failing);
        }
        */

    }

    /*
    static double CalculateAverage(List<int> numbers)
    {
        double sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        double average = sum / numbers.Count;
        return average;
        
    }

    static int FindFirstFailing(List<int> gradesList)
    {
        return gradesList.Find(grade => grade < 60);
    }
    */
    
}