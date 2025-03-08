using System;
using System.Runtime.CompilerServices;

public class Manager : Goal  // this class will manage user interface and saving/loading a users performance and their goals.
{
    // code here 
    private int _totalPoints;
    private string _fileName;
    private List<Goal> goalList = new List<Goal>();

    public Manager(int totalPoints, string filename, Goal goalList)
    {
        //
    }

    public void SaveGoal()
    {
        // save goal
    }

    public string LoadGoal()
    {
        return // load goal
    }

    public void DisplayGoalList()
    {
        // display goal list
    }

    public void DisplayPoints()
    {
        // display points
    
    }

    public void DisplayTotalPoints()
    {
        // display total points
    }

}