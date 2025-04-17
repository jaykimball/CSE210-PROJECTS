using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal? 1=Simple, 2=Eternal, 3=Checklist");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times to complete? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points on completion: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Choose goal number to record event: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score: {_score} points");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];

                if (type == "SimpleGoal")
                {
                    var g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) g.SetComplete();
                    _goals.Add(g);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }
                else if (type == "ChecklistGoal")
                {
                    var g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                    g.SetProgress(int.Parse(parts[6]));
                    _goals.Add(g);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
