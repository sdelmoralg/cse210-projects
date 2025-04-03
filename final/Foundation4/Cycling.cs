using System;

public class Cycling : Activity
{
    private double _speed;

    // constructor
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes, "Cycling")
    {
        _speed = speed;
    }

     // override methods
    public override double GetDistance()
    {
        return GetSpeed() * Minutes / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}