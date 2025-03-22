using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Generating a random number
        Random randomGenarator = new Random();
        int magicNumber = randomGenarator.Next (1, 101);

        int guess = -1;

        //Creating a loop
        while (guess != magicNumber)
        {        
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());


        if (magicNumber > guess)
        {
            Console.WriteLine("Go Higher");
        }

        else if (magicNumber < guess)
        {
            Console.WriteLine("Go Lower");
        }

        else 
        {
            Console.WriteLine("Congratulations.You guessed it");
        }

        }
    }

    
}