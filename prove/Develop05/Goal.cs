using System;
using System.Collections.Concurrent;

public abstract class Goal
{
    public string _name;
    public string _description;
    public int _points;

    // public Goal(string name, string description, int points)
    // {
    //     _name = name;
    //     _description = description;
    //     _points = points;
    // }
    public virtual void UserInput()
    {
        Console.WriteLine("what is the name of your goal? ");
        _name = Console.ReadLine();

        Console.WriteLine("what is a short description of it? ");
        _description = Console.ReadLine();

        Console.WriteLine("what is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public abstract void RecordEvent(); // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal 
                                      // complete and adding to the number of times a checklist goal has been completed. It should return the point 
                                      // value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist 
                                      // goal was just finished, for example).
    public abstract bool IsComplete(); // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.

}