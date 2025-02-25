using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    
    public void DisplayBreathingPrompt()
    {
        Console.WriteLine("prompt...");
    }
}