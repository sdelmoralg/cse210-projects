using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    
   
    public void DisplayBreathingPrompt()
    { // TODO loop

        Console.WriteLine("Breath in...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        } 
        Console.WriteLine("Breath out...");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        } 
    }

    public void RunBreathingActivity()
    {
        // Console.WriteLine(name);
        // Console.WriteLine(description);
        UserInputCountdown();
        Console.Clear();
        Console.Write("Get ready...");
        PauseAnimation();
    }
}