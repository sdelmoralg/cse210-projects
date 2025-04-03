using System;

public class Activity // the base class should contain virtual methods for getting the distance, speed, pace. These methods should be overridden in the derived classes.
{
    private Date _date;
    private string _minutes;

    // constructor

    public double GetDistance()
    {
        // get distance
    }

    public double GetSpeed()
    {
        // get speed
    }

    public double GetPace()
    {
        // get pace
    }

    public string GetSummary()
    {
        // get summary in the from: date - Activity - distance - speed-pace
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
    }
}