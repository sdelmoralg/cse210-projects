using System;

public class Eternal : Goal
{

    public override void RecordEvent() // should mark a goal completed. eternal goals are never completed
    {
        // code here 
    }
    public override bool IsComplete()
    {
        return false;
    }
}