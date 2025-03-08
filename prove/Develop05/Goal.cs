using System;
using System.Collections.Concurrent;

public class Goal
{
    private string _name;
    private string _description;

    private int _points; 

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public virtual void RecordEvent() // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal 
    {                                 // complete and adding to the number of times a checklist goal has been completed. It should return the point 
                                      // value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist 
                                      // goal was just finished, for example).
        return // code here 
    }

    public virtual bool IsComplete() // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    {
        return // code here 
    }


}