using System;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",    
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

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

    public void RunListingActivity()
    {
        // run activity
    }

}
