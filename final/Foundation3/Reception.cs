using System;

public class Reception : Event
{
    private string _rsvp;
    private string _type = "Reception";

    // constructor
    public Reception(string title, string description, string date, string time, Address address, string rsvp) : base(title, description, date, time, address, "Reception")
    {
        _rsvp = rsvp;
    }

    public override string FullDetails() // Lists all of the above, plus type of event and an email for RSVP. 
    {
        return StandardDetails() + $" Don't miss out on this {_type} event! Please RSVP to {_rsvp} to secure your spot!!\n"; 
    }
}