using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    private string _type = "Lecture";

    // constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails() // Lists all of the above, plus type of event and the speaker name and capacity.
    {
        return StandardDetails() + $"\nType of Event: {_type}\nSpeaker: {_speaker}\nCapacity: {_capacity}"; 
    }
}