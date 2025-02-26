using System;
using System.ComponentModel;
using System.Dynamic;

public class Activity 
{
    private string _activityName;
    private string _description;
    private int _duration;
    private int inputDuration;
    public Activity(string name, string description, int duration)
    {
        _activityName = name;              
        _description = description;
        _duration = duration;
    }

    public void DisplayMenuOptions()
    {
        Console.WriteLine("Menu Options:\n\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit\n\nSelect a choice from the menu:");
    }
    public void DisplayInitialMsg()
    {
        Console.WriteLine($"Welcome to the {_activityName}.");
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void DisplayFinalMsg()
    {
        Console.WriteLine("well done!!");
        PauseAnimation();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {inputDuration} seconds of the {_activityName}");
        PauseAnimation();
    }

    public void PauseAnimation()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void GetUserInput()
    {
        Console.Write("How long, in seconds, would you like for your sesion? ");
        string input = Console.ReadLine();
        inputDuration = int.Parse(input);
        Console.Clear();
        Console.Write("Get ready");
        PauseAnimation();
    }
    public void Countdown()
    {
        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        } 
    }

    public void UserInputCountdown()
    {
        for (int i = inputDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
    }
}