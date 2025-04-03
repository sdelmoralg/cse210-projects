using System;

public class Activity // the base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes.
{
    private DateTime _date;
    private int _minutes;

    // constructor
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        // get distance
    }

    public virtual double GetSpeed()
    {
        // get speed
    }

    public virtual double GetPace()
    {
        // get pace
    }

    public virtual string GetSummary()
    {
        // get summary in the from: date - Activity - distance - speed-pace
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
    }
}