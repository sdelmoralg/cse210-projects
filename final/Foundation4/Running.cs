using System;

public class Running : Activity
{
    private double _distance;

    // constructor
    public Running (DateTime date, int minutes, double distance) : base(date, minutes, "Running")
    {
        _distance = distance;
    }

    // override methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return GetDistance() / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary();
    }
}