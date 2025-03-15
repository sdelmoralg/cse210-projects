using System;
using System.Drawing;
using System.Runtime.CompilerServices;

public class Manager // this class will manage user interface and saving/loading a users performance and their goals.
{
    // code here 
    private int _totalPoints = 0;
    private string _fileName;
    private List<Goal> _goalList = new List<Goal>();

    // public Manager(int totalPoints, string filename)
    // {
    //     _totalPoints = totalPoints;
    //     _fileName = filename;
    // }

    // public void SaveGoal()
    // {
    //     Console.WriteLine("What is the filename for the foal file? ");
    //     _fileName = Console.ReadLine();

    //     using (StreamWriter outputfile = new StreamWriter(_fileName))
    //     {
    //         foreach (Goal goal in _goalList) // saves each goal
    //         {
    //             outputfile.WriteLine($"{}"); // saves user input - TO DO points, type of goal, name, description, points (bonus points), is completed (times to complete, times completes)
    //         }
    //     }
    // }

    // public void LoadGoal()
    // {
    //     Console.WriteLine("What is the filename for the goal file? ");
    //     string fileName = Console.ReadLine();

    //     string[] lines = System.IO.File.ReadAllLines(fileName); // 
        
    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split(",");
    //     }
    // }
    public void AddToList(Goal goal)
    {
        _goalList.Add(goal);
    }
    public void DisplayGoalList()
    {
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{goal._name}, {goal._description}, {goal._points}");
        }
    }

    // public void DisplayPoints()
    // {
    //     Console.WriteLine($"You now have {_points} points")


    // }

    // public void DisplayTotalPoints()
    // {
    //     Console.WriteLine($"You have {_totalPoints} points.");
    // }

}