using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

    // this class should represent a journal entry. Does not have many
    // behaviors. Its main responsability is to hold data. It has to have a
    // display method.

public class Entry
{
    public List<Entry> _entries = new List<Entry>(); // empty list of entries
    DateTime theCurrentTime = DateTime.Now;
    public string _date;

    public string rndPrompt;

    public void RamdomPrompt() // calls random prompt
    {
        Prompts _prompt = new Prompts();
        rndPrompt = _prompt.DisplayPrompt();
    }

    public string journalContent;
    
    public Entry()
    {
        _date = theCurrentTime.ToShortDateString(); // shows the date 
    }
    
    public void WriteEntry() // stores the new entry
    {
        Console.WriteLine($"Date: {_date} - Prompt: {rndPrompt} ");
        Console.Write("> ");
        Entry newEntry = new Entry();
        newEntry.journalContent = Console.ReadLine();
        _entries.Add(newEntry);

    }

    // public void DisplayJournal() // displays all entries in the journal
    // {
    //     add code
    // }  

}