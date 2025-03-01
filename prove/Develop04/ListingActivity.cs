using System;
using System.Formats.Asn1;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        "-- Who are people that you appreciate?-- ",    
        "-- What are personal strengths of yours?-- ",
        "-- Who are people that you have helped this week?-- ",
        "-- When have you felt the Holy Ghost this month?-- ",
        "-- Who are some of your personal heroes?-- "
    };

    private int _answerCount = 0;
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void DisplayListingPrompt()
    {
        Random r = new Random();
        string randomListingPrompt = _listingPrompts[r.Next(_listingPrompts.Count)];
        Console.WriteLine(randomListingPrompt);
        Console.WriteLine();
    }

    public void GetListingAnswers()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_inputDuration);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        DisplayListingPrompt();
        Console.Write("You may begin in: "); 
        Countdown();

        while (DateTime.Now  < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _answerCount ++;
        }
        Console.WriteLine($"You listed {_answerCount} items!");
    }  

    public void RunListingActivity()
    {
        DisplayInitialMsg();
        DisplayDescription();
        Console.Clear();
        GetUserInput();
        GetListingAnswers();
        Console.WriteLine();
        DisplayFinalMsg();
    }

}
