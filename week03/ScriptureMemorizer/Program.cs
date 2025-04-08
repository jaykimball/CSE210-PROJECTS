using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer Program!\n");

        // Print the current working directory to debug the file path issue
        Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());

        string fileName = "scripture.txt";

        // Check if the file exists in the working directory
        if (!File.Exists(fileName))
        {
            Console.WriteLine($"\nERROR: Could not find '{fileName}' in the current directory.");
            Console.WriteLine("Fix: Place 'scripture.txt' in the same folder as your Program.cs,");
            Console.WriteLine("or in the bin/Debug/net6.0 folder if you're using Visual Studio.");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            return;
        }

        // Read scripture lines
        string[] lines = File.ReadAllLines(fileName);

        if (lines.Length < 2)
        {
            Console.WriteLine("Invalid format: First line = reference, second line = scripture text.");
            return;
        }

        string referenceLine = lines[0].Trim(); // e.g., "Proverbs 3:5-6"
        string scriptureText = lines[1].Trim(); // e.g., "Trust in the Lord..."

        Reference reference;

        try
        {
            // Extract book (can have spaces), chapter and verse(s)
            int colonIndex = referenceLine.IndexOf(':');
            int lastSpaceBeforeColon = referenceLine.LastIndexOf(' ', colonIndex);
            string book = referenceLine.Substring(0, lastSpaceBeforeColon);
            string rest = referenceLine.Substring(lastSpaceBeforeColon + 1); // e.g., "3:5-6" or "3:16"

            if (rest.Contains("-"))
            {
                string[] parts = rest.Split(new[] { ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                int chapter = int.Parse(parts[0]);
                int startVerse = int.Parse(parts[1]);
                int endVerse = int.Parse(parts[2]);
                reference = new Reference(book, chapter, startVerse, endVerse);
            }
            else
            {
                string[] parts = rest.Split(':');
                int chapter = int.Parse(parts[0]);
                int verse = int.Parse(parts[1]);
                reference = new Reference(book, chapter, verse);
            }
        }
        catch
        {
            Console.WriteLine("Error parsing scripture reference. Please check the format.");
            return;
        }

        Scripture scripture = new Scripture(reference, scriptureText);

        // Loop until all words are hidden or user quits
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}
