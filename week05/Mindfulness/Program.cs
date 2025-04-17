using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");

        // === CREATIVE BONUS FEATURES ===
        // - Modular Inheritance across all 3 Activities
        // - Spinner and Countdown animations for all pauses
        // - Randomized prompts & questions ensure variation
        // - Listing Activity includes item count feedback
        // - Fully follows OOP best practices (Encapsulation, Abstraction)

        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("====================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to try again.");
                Console.ReadLine();
            }

            Console.WriteLine(); // Add spacing between loops
        }
    }
}
