
using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(3);
            elapsed += 3;

            Console.WriteLine("Breathe out...");
            Countdown(3);
            elapsed += 3;
        }

        DisplayEndingMessage();
    }
}
