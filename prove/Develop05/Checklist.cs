using System;

public class Checklist : Goal
{
    private int _bonusPoints;
    private int _timesToComplete;
    private int _timesCompleted;
    private bool _cGoalCompleted;

    public Checklist(string type, string name, string description, int points, int bonusPoints, int timesToComplete) : base(type, name, description, points) /////
    {
        _bonusPoints = bonusPoints;
        _timesToComplete = timesToComplete;             // constructor
        _timesCompleted = 0;
    }
    public Checklist(string type, string name, string description, int points, bool goalCompleted, int bonusPoints, int timesToComplete, int timesCompleted) : base(type, name, description, points) /////
    {
        BonusPoints = bonusPoints;
        TimesToComplete = timesToComplete;             // constructor
        TimesCompleted = timesCompleted;
        ChecklistGoalCompleted = goalCompleted;

    }
    public int BonusPoints              // getters / setters
    {
        get { return _bonusPoints; }
        set { _bonusPoints = value; }
    }

    public int TimesToComplete
    {
        get { return _timesToComplete; }
        set { _timesToComplete = value; }
    }

    public int TimesCompleted
    {
        get { return _timesCompleted; }
        set { _timesCompleted = value; }
    }
        public bool ChecklistGoalCompleted
    {
        get { return _cGoalCompleted; }
        set { _cGoalCompleted = value; }
    }
    public override void UserInput()
    {
        base.UserInput();

        Console.WriteLine("how many times does this goal need to be accomplished for a bonus? ");
		_timesToComplete = int.Parse(Console.ReadLine());

        Console.WriteLine("what is the bonus for accomlishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent(Manager m)
    {
        if (_timesCompleted < _timesToComplete)
        {
            _timesCompleted++;
            m.TotalPoints += Points; 

            if (_timesCompleted == _timesToComplete)
            {
                m.TotalPoints += _bonusPoints;
                Console.WriteLine($"\nCongratulations! You have earned {BonusPoints} bonus points!");
                _cGoalCompleted = true;
            }
            else
            {
                Console.WriteLine($"\nYou earned {Points} points!");
            }
        }
        else
        {
            Console.WriteLine("\nThis goal has already been completed!");
        }
    }
    public override bool IsComplete() 
    {
        return _cGoalCompleted;
        
        
    }
}