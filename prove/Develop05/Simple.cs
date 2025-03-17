using System;

public class Simple : Goal
{    
    private bool _sGoalCompleted;

    public bool SimpleGoalCompleted
    {
        get {return _sGoalCompleted; }
        set {_sGoalCompleted = value; }
    }
    public Simple(string type, string name, string description, int points, bool simpleGoalCompleted) : base(type, name, description, points)
    {
        SimpleGoalCompleted = simpleGoalCompleted; 
    }

        public Simple(string type, string name, string description, int points) : base(type, name, description, points)
    {
        SimpleGoalCompleted = false; 
    }

    public override void RecordEvent(Manager m) //  should mark a goal completed
    {
        m.TotalPoints += Points;
        Console.WriteLine($"You earned {Points} points!");
        SimpleGoalCompleted = true;
        

    }

    public override bool IsComplete() // This method should return true if the goal is completed. 
    {                                 // The way you determine if a goal is complete is different for each type of goal.
        return SimpleGoalCompleted;
    }

}