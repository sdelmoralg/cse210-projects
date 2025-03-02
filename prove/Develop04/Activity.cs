using System;
using System.ComponentModel;
using System.Dynamic;

public class Activity 
{
    private string _activityName;
    private string _description;
    protected int _duration;
    protected int _inputDuration;

    public Activity(string name, string description, int duration)
    {
        _activityName = name;              
        _description = description;
        _duration = duration;
    }
    
    public void DisplayInitialMsg()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayFinalMsg()
    {
        Console.WriteLine();
        Console.WriteLine("well done!!");
        PauseAnimation();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_inputDuration} seconds of the {_activityName}");
        PauseAnimation();
    }

    public void PauseAnimation()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void GetUserInput()
    {
        Console.Write("How long, in seconds, would you like for your sesion? ");
        string input = Console.ReadLine();
        _inputDuration = int.Parse(input);
        Console.Clear();
        Console.Write("Get Ready");
        PauseAnimation();
        Console.WriteLine();
    }

    public void UserInputCountdown()
    {
        for (int i = _inputDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }
        public void Countdown() 
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        } 
    }
   
}