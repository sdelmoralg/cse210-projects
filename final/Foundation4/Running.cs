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
        // get summary in the from: date - Activity - distance - speed-pace
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
        return base.GetSummary();
    }
}