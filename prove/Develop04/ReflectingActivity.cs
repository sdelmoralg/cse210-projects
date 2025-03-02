using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;

public class ReflectingActivity : Activity
{
    public ReflectingActivity (string name, string description, int duration) : base(name, description, duration) 
    {
        
    }
    private Dictionary<string, bool> _reflectingPrompts = new Dictionary<string, bool> //dictionary to not repeat prompts
    {
        {"--- Think of a time when you stood up for someone else. ---", false},  
        {"--- Think of a time when you did something really difficult. ---", false},
        {"--- Think of a time when you helped someone in need. ---", false},
        {"--- Think of a time when you did something truly selfless. --- ", false}
    };

    private Dictionary<string, bool> _reflectingQuestions = new Dictionary<string, bool> //dictionary to not repeat prompts
    {
        {"Why was this experience meaningful to you?", false},
        {"Have you ever done anything like this before?", false},
        {"How did you get started?", false},
        {"How did you feel when it was complete?", false},
        {"What made this time different than other times when you were not as successful?", false},
        {"What is your favorite thing about this experience?", false},
        {"What could you learn from this experience that applies to other situations?", false},
        {"What did you learn about yourself through this experience?", false},
        {"How can you keep this experience in mind in the future?", false}
    };

    public void DisplayReflectingPrompt()
    { 
        Random random = new Random();
        //string randomPrompt = _reflectingPrompts[random.Next(_reflectingPrompts.Count)];
        if (_reflectingPrompts.Values.Contains(false) == false) //check if all prompts have been used
            {
                foreach (string key in _reflectingPrompts.Keys.ToList()) //resets prompts
                {
                    _reflectingPrompts[key] = false;
                }
            }
        string randomPrompt = _reflectingPrompts.Keys.ElementAt(random.Next(_reflectingPrompts.Count));
        while (_reflectingPrompts[randomPrompt] == true) //chooses new random prompt until non used one is picked
        {
            randomPrompt = _reflectingPrompts.Keys.ElementAt(random.Next(_reflectingPrompts.Count));
        }
        _reflectingPrompts[randomPrompt] = true; //sets prompt to used
        Console.WriteLine();
        Console.WriteLine(randomPrompt);
        Console.WriteLine();
    }
    
    public void DisplayReflectingQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_inputDuration);
        Random r = new Random();

        while (DateTime.Now  < futureTime)
        {
            //string randomQuestion = _reflectingQuestions[r.Next(_reflectingQuestions.Count)];
            if (_reflectingQuestions.Values.Contains(false) == false)
            {
                foreach (string key in _reflectingQuestions.Keys.ToList())
                {
                    _reflectingQuestions[key] = false;
                }
            }

            string randomQuestion = _reflectingQuestions.Keys.ElementAt(r.Next(_reflectingQuestions.Count));
            if (_reflectingQuestions[randomQuestion] == true) //checks if prompt has been used
            {
                continue; //jumps to new iteration
            }
            else
            {
                _reflectingQuestions[randomQuestion] = true;
            }
            Console.WriteLine(randomQuestion);
            Thread.Sleep(10000); //question timer in milliseconds
            Console.WriteLine();  
        }

    }
    public void RunReflectingActivity()
    {
        Console.Clear();
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
        Console.Write($"You may begin in: ");
        Countdown();
        Console.Clear();
        DisplayReflectingQuestion();
        DisplayFinalMsg();
    }
}