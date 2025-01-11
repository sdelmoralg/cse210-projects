using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >=70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"You've got a {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }

        else
        {
            Console.WriteLine("You will do better next time!");
        }
    }
}