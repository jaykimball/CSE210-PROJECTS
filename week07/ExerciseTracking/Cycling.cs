public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed() => _speed;

    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}
