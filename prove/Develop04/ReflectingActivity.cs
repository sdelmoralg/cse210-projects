using System;
using System.Collections.Generic;
using System.ComponentModel;

public class ReflectingActivity : Activity
{
    private List<string> _reflectingPrompts = new List<string>
    {
        "--- reflecting prompt 1 ---",
        "--- reflecting prompt 2 ---",
        "--- reflecting prompt 3 ---"
    };

    private List<string> _reflectingQuestions = new List<string>
    {
        "reflecting question 1",
        "reflecting question 2",
        "reflecting question 3"
    };

    public ReflectingActivity (string name, string description, int duration) : base(name, description, duration) 
    {
        
    }

    public void DisplayReflectingPrompt()
    { 
        Random random = new Random();
        string randomPrompt = _reflectingPrompts[random.Next(_reflectingPrompts.Count)];
        Console.WriteLine();
        Console.WriteLine(randomPrompt);
        Console.WriteLine();
    }

    public void DisplayReflectingQuestion()
    {
        Random r = new Random();
        string randomQuestion = _reflectingQuestions[r.Next(_reflectingQuestions.Count)];
        Console.WriteLine(randomQuestion);
        Countdown();
        Console.WriteLine();
    }

    public void RunReflectingActivity()
    {
        DisplayInitialMsg();
        DisplayDescription();
        GetUserInput();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        DisplayReflectingPrompt();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine($"You may begin in: {Countdown}");
        Console.Clear();
        DisplayReflectingQuestion();
        DisplayReflectingQuestion();
        DisplayFinalMsg();
        
        
        

    }
}