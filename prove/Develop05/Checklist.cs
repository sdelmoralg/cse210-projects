using System;

public class Checklist : Goal
{
    private int _bonusPoints = 0;
    private int _timesToComplete;
    private int _timesCompleted = 0;

    // public Checklist(string name, string description, int points, int bonusPoints, int timesToComplete, int timesCompleted) : base(name, description, points)
    // {
    //     _bonusPoints = bonusPoints;
    //     _timesToComplete = timesToComplete;
    //     _timesCompleted = timesCompleted;
    // }
    public override void RecordEvent() // add the number of times a goal is completed
    {
        Console.WriteLine("Which goal did you accomplish? ");
        string goalAccomplished = Console.ReadLine();

    }

    public override void UserInput()
    {
        base.UserInput();

        Console.WriteLine("how many times does this goal need to be accomplished for a bonus? ");
		_timesToComplete = int.Parse(Console.ReadLine());

        Console.WriteLine("what is the bonus for accomlishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override bool IsComplete() // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    {
        return false;
    }
}