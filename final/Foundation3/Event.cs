using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    protected string _type;

    // constructor
    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public virtual string StandardDetails() // Lists the title, description, date, time, and address.
    {
        return $"Get ready for {_title}! Join us on {_date} at {_address.GetAddress()} starting at {_time} for an unforgetable experience! {_description} This is your chance to be part of something exciting! Mark your calendar and get ready for an amazing time!";
    }
    public abstract string FullDetails(); // Lists all of the above, plus type of event and information specific to 
    // that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email
    // for RSVP. For outdoor gatherings, this includes a statement of the weather.
    
    public string ShortDetails() // Lists the type of event, title, and the date.
    {
        return $"Join us for a {_type} event - {_title}! Mark your calendar for {_date} and be part of something special! Don't miss out on this exciting event!\n";
    }
}