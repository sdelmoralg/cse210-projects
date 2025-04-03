using System;

public class Activity // the base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes.
{
    private DateTime _date;
    private int _minutes;
    protected string _activity;

    // constructor
    public Activity(DateTime date, int minutes, string activity)
    {
        _date = date;
        _minutes = minutes;
        _activity = activity;
    }

    public DateTime Date
    {
        get {return _date;}
    }

    public int Minutes
    {
        get {return _minutes;}
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        // get summary in the from: date - Activity - distance - speed-pace
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
        return $"{Date:dd MMM yyyy} {_activity} ({Minutes} min): Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";       

    }
}