using System;
using System.Formats.Asn1;

public class ListingActivity : Activity
{
    private Dictionary<string, bool> _listingPrompts = new Dictionary<string, bool>
    {
        {"-- Who are people that you appreciate?-- ", false},   
        {"-- What are personal strengths of yours?-- ", false},
        {"-- Who are people that you have helped this week?-- ", false},
        {"-- When have you felt the Holy Ghost this month?-- ", false},
        {"-- Who are some of your personal heroes?-- ", false}
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void DisplayListingPrompt()
    {
        Random r = new Random();
        if (_listingPrompts.Values.Contains(false) == false)
            {
                foreach (string key in _listingPrompts.Keys.ToList())
                {
                    _listingPrompts[key] = false;
                }
            }
        //string randomListingPrompt = _listingPrompts[r.Next(_listingPrompts.Count)];
        string randomListingPrompt = _listingPrompts.Keys.ElementAt(r.Next(_listingPrompts.Count));
        while (_listingPrompts[randomListingPrompt] == true)
        {
            randomListingPrompt = _listingPrompts.Keys.ElementAt(r.Next(_listingPrompts.Count));
        }
        _listingPrompts[randomListingPrompt] = true;
        Console.WriteLine(randomListingPrompt);
        Console.WriteLine();
    }

    public void GetListingAnswers()
    {
        int answerCount = 0; //resets answer count
        Console.WriteLine("List as many responses you can to the following prompt: \n");
        DisplayListingPrompt();
        Console.Write("You may begin in: "); 
        Countdown();
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_inputDuration);

        while (DateTime.Now  < futureTime)
        { 
            Console.Write("> ");
            Console.ReadLine();
            answerCount ++;
        }
        Console.WriteLine($"\nYou listed {answerCount} items!");
    }  

    public void RunListingActivity()
    {
        Console.Clear();
        DisplayInitialMsg();
        DisplayDescription();
        GetUserInput();
        Console.Clear();
        GetListingAnswers();
        Console.WriteLine();
        DisplayFinalMsg();
    }

}
