using System;

public class Eternal : Goal
{

    public Eternal(string type, string name, string description, int points) : base(type, name, description, points)
    {
     
    }
    public override void RecordEvent(Manager m) // Eternal goals are never completed but they earn points
    {
        m.TotalPoints += Points;
        Console.WriteLine($"You earned {Points} points!");
    }
    public override bool IsComplete()
    {
        return false;  // eternal goals are never completed
    }
}