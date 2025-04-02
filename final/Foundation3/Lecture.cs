using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        // full details override
        return StandardDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}