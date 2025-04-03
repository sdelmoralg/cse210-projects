using System;

public class Swimming : Activity
{
    private int _laps;

    // constructor
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes, "Swimming")
    {
        _laps = laps;
    }

    // override methods
    public override double GetDistance()
    {
        // Distance (km) = swimming laps * 50 / 1000
        return _laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        // Speed (mph or kph) = (distance / minutes) * 60
        return GetDistance() / Minutes * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile or min per km)= minutes / distance
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        // get summary in the from: date - Activity min- distance - speed-pace
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
        return base.GetSummary();
    }
}