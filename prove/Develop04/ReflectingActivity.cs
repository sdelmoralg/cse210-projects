using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _reflectingPrompts = new List<string>
    {
        "prompt1",
        "prompt 2",
        "prompt 3"
    };

    private List<string> _reflectingQuestions = new List<string>
    {
        "question 1",
        "question 2",
        "question 3"
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
    }

    public void DisplayInstructions()
    {
        Console.WriteLine("instructions....");
    }

    public void DisplayReflectingQuestion()
    {
        Random r = new Random();
        string randomQuestion = _reflectingQuestions[r.Next(_reflectingQuestions.Count)];
        Console.WriteLine(randomQuestion);
    }


}