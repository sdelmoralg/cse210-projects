using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // string userInput;
        // Activity a = new Activity("menu", "shows the menu", 5);

        // BreathingActivity b = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 5);

        ReflectingActivity c = new ReflectingActivity("Reflecting Activity", "This activity will elp you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 5);

        c.RunReflectingActivity();
        
        // a.DisplayMenuOptions();
        // userInput = Console.ReadLine();
        // if (userInput == "1")
        // {
        //     // run breathing activity
        //     // RunBreathingActivity();
        // }

        // if (userInput == "2")
        // {
        //     // run reflecting activity
        //     c.RunReflectingActivity();
        // }
        
        // if (userInput == "3")
        // {
        //     // run listing activity
        // }

        // if (userInput == "4")
        // {
        //     // quit
        // }

        // else
        // {
        //     Console.WriteLine("Please choose a valid option: ");
        //     Console.WriteLine();
        // }
    }
}

