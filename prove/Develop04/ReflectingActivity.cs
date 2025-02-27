using System;
using System.Collections.Generic;
using System.ComponentModel;

public class ReflectingActivity : Activity
{
    public ReflectingActivity (string name, string description, int duration) : base(name, description, duration) 
    {
        
    }
    private List<string> _reflectingPrompts = new List<string>
    {
        "--- Think of a time when you stood up for someone else. ---",   
        "--- Think of a time when you did something really difficult. ---",
        "--- Think of a time when you helped someone in need. ---",
        "--- Think of a time when you did something truly selfless. --- "
    };

    private List<string> _reflectingQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

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
        Console.ReadLine();   // TODO arreglar esto
        Console.WriteLine();  // no esta mostrando las dos lineas de abajo. se va directo a las preguntas
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine($"You may begin in: {Countdown}");
        Console.Clear();
        DisplayReflectingQuestion();
        DisplayReflectingQuestion();
        DisplayFinalMsg();
        
        
        

    }
}