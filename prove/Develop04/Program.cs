using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        Activity a = new Activity("animation", "blah blah blah", 10);
        ReflectingActivity b = new ReflectingActivity("prompts", "description", 10);

        a.PauseCountdown();
        a.PauseAnimation();

        b.DisplayReflectingPrompt();
        b.DisplayReflectingQuestion();
    }
}