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
        // get summary in the from: date - Activity - distance - speed-pace
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
        return base.GetSummary();
    }
}