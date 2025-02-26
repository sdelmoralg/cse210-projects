using System;

public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>
    {
        "listing prompt 1",
        "listing prompt 2",
        "listing prompt 3"
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
        //
    }

}
