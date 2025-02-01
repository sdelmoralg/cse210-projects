using System;
using System.Collections.Generic;

public class Prompts
{
    public List<string> _prompts = new List<string>()
     {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is one of the hobbies I enjoy doing?",
        "What am I grateful for today?",
        "What did I do today that I am prod of?",
        "What was the most challenging thing I faced today?",
        "What do I love the most about myself?",
        "How did I help others today?",
        "What were my top priorities for today?",
        "How can I make tomorrow better than today?",
        "What were the highlights of my day?",
        "What did I accomplish today?",
        "What I am looking foward tomorrow?",
        "What did I do to make someone elses day better?",
        "What are some things I want to remember about today?",
        "What made me laugh today?",
        "Who is someone that inspires me and why?"
    };

    public string DisplayPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);

        return _prompts[index];

    }

}