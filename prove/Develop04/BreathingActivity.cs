using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class BreathingActivity : Activity
{
    private int _rep; // number of times the breathing in and out repeats
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        // name = "Breathing Activity";
        // description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        // duration = 5;
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
        DisplayInitialMsg(); // no salio
        DisplayDescription(); // no salio
        GetUserInput();  // tampoco
        _rep = _inputDuration/(2*_duration);
        DisplayBreathingPrompt();
        DisplayFinalMsg();
    }
}