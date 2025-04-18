using System;

public class Activity
{
    private string _date;
    private int _duration; // in minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetDate() => _date;
    public int GetDuration() => _duration;

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
