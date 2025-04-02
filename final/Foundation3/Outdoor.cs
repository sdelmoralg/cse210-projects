using System;

public class Outdoor : Event
{
    private string _weather;
    private string _type = "Outdoor";

    // constructor
    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address, "Outdoor")
    {
        _weather = weather;
    }

    public override string FullDetails() // Lists all of the above, plus type of event and a statement of the weather.
    {
        return StandardDetails() + $"Type of Event: {_type}\nWeather: {_weather}\n"; 
    }
}