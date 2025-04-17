using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.\n");

        GoalManager manager = new GoalManager();
        manager.LoadGoals();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    manager.RecordEvent();
                    break;
                case "4":
                    manager.DisplayScore();
                    break;
                case "5":
                    manager.SaveGoals();
                    break;
                case "6":
                    manager.LoadGoals();
                    break;
                case "7":
                    Console.WriteLine("Exiting Eternal Quest. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}