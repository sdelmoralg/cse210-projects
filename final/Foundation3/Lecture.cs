using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    // constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails() // Lists all of the above, plus type of event and the speaker name and capacity.
    {
        return StandardDetails() + $" Dont miss out on this {_type} featuring {_speaker}. This event has a capacity of {_capacity} so be sure to secure your spot before is full!!\n"; 
    }
}