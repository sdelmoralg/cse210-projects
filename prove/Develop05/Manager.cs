using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.IO;

public class Manager // this class will manage user interface and saving/loading a users performance and their goals.
{
    private int _totalPoints;
    private string _fileName;
    public List<Goal> _goalList { get; private set; }

    public Manager()
    {
        _goalList = new List<Goal>();
    }

    public Manager(string filename) 
    {
        _fileName = filename;
        _goalList = new List<Goal>();
    }

    public int TotalPoints
    {
        get { return _totalPoints; }
        set { _totalPoints = value; }
    }
    public void LoadGoal()    
    {
        Console.WriteLine("\nWhat is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        _goalList.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileName); 

        TotalPoints = int.Parse(lines[0]);

        // foreach (string line in lines)
        for (int i = 1; i <lines.Length; i++) //skips total points
        {
            string[] parts = lines[i].Split(",");
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool goalCompleted = bool.Parse(parts[4]);

            if (goalType == "Simple Goal")
                _goalList.Add(new Simple(goalType, name, description, points, goalCompleted));

            else if (goalType == "Eternal Goal")
                _goalList.Add(new Eternal(goalType, name, description, points));

            else if (goalType == "Checklist Goal")
                _goalList.Add(new Checklist(goalType, name, description, points, goalCompleted, int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
        }

        Console.WriteLine("\nGoals loaded succesfully!"); 
    }
    public void AddToList(Goal goal)
    {
        _goalList.Add(goal);
    }
    public void DisplayGoalList()
    {
        Console.Clear();
        Console.WriteLine("Your goals:\n");
        int i = 0;
        string checkMark; 

        foreach (Goal goal in _goalList)
        {
            i++; // enumera las metas
            if (goal.IsComplete() == true) 
            {
                checkMark = "X";  
            }
            else
            {
                checkMark = " "; 
            }
            
            if (goal is Checklist checklistGoal)
            {
                Console.WriteLine($"{i} - [{checkMark}] {goal.Name} ({goal.Description}) -- completed ({checklistGoal.TimesCompleted}/{checklistGoal.TimesToComplete})"); 
            }
            else
            {
            Console.WriteLine($"{i} - [{checkMark}] {goal.Name} ({goal.Description})");
            }
        }
        Console.WriteLine("\nPress enter to continue");
        Console.ReadLine();
    }

    public void DisplayTotalPoints()
    {
        Console.WriteLine($"\nYou have {TotalPoints} points.");
    }

    public void SaveGoal()  
    {
        Console.WriteLine("What is the filename for the foal file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputfile = new StreamWriter(_fileName))
        {
            outputfile.WriteLine(TotalPoints);

            foreach (Goal goal in _goalList) // saves each goal
            {
                if (goal is Checklist checklistGoal)
                {                                       // formato de como se gurdan las metas
                    outputfile.WriteLine($"{goal.Type},{goal.Name},{goal.Description},{goal.Points},{checklistGoal.IsComplete()},{checklistGoal.BonusPoints},{checklistGoal.TimesToComplete}, {checklistGoal.TimesCompleted}");
                }

                else
                {
                    outputfile.WriteLine($"{goal.Type},{goal.Name},{goal.Description},{goal.Points},{goal.IsComplete()}");
                }
            }
        }
    }
}