using System;

public class Outdoor : Event
{
    private string _weather;

    // constructor
    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address, "Outdoor")
    {
        _weather = weather;
    }
    
    public override string FullDetails() // Lists all of the above, plus type of event and a statement of the weather.
    {
        return StandardDetails() + $" Dont miss out on this {_type} event! The weather will be {_weather}!\n"; 
    }
}