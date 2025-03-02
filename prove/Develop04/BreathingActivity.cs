using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class BreathingActivity : Activity
{
    private int _rep; // number of times the breathing in and out repeats
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void DisplayBreathingPrompt()
    { 
        int count = 0;
        while (count < _rep)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            Countdown();
            Console.WriteLine();
            Console.Write("Breathe out... ");
            Countdown();
            Console.WriteLine();
            count++;
        }
    }

    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayInitialMsg();
        DisplayDescription(); 
        GetUserInput();  
        _rep = _inputDuration / (2 * _duration); //solves for number of reps based on durations
        DisplayBreathingPrompt();
        DisplayFinalMsg();
    }
}