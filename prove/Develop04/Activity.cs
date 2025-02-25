using System;
using System.ComponentModel;

public class Activity 
{
    private string _activityName = "";
    private string _description = "";
    private int _duration = 0;

    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayInitialMsg()
    {
        Console.WriteLine("hello...");
    }

    public void DisplayFinalMsg()
    {
        Console.WriteLine("well done...");
    }

    public void PauseAnimation()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void PauseCountdown()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }   
    }

}