using System;

public class Simple : Goal
{
    // private bool _sGoalCompleted = false;

    // public Simple(int points, bool simpleGoalCompleted) : base(points)
    // {
    //     _sGoalCompleted = simpleGoalCompleted;
    // }
   
    public override void RecordEvent() //  should mark a goal completed
    {
        Console.WriteLine("Which goal did you accomplished? ");
        string goalAccomplished = Console.ReadLine();

    //     if (goalAccomplished = ) // ?


    }

    public override bool IsComplete() // This method should return true if the goal is completed. 
    {                                 // The way you determine if a goal is complete is different for each type of goal.
        return true;
    }

}