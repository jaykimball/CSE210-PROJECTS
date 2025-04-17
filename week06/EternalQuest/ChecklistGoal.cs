using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _currentCount++;
            int totalPoints = _points;
            if (_currentCount == _targetCount)
            {
                totalPoints += _bonus;
                Console.WriteLine($"Bonus! You completed the checklist and earned an additional {_bonus} points!");
            }
            Console.WriteLine($"You earned {totalPoints} points!");
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";
    }

    // 🔧 Add this at the very bottom of the class
    public void SetProgress(int progress)
    {
        _currentCount = progress;
    }
}
