using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

    // this class should represent a journal entry. Does not have many
    // behaviors. Its main responsability is to hold data. 

public class Entry
{
    //public List<Entry> _entries = new List<Entry>(); // empty list of entries
    DateTime theCurrentTime = DateTime.Now;
    public string _date;

    public string rndPrompt;

    public void RandomPrompt() // calls random prompt
    {
        Prompts _prompt = new Prompts();
        rndPrompt = _prompt.DisplayPrompt();
    }

    public string journalContent;
    
    public Entry()
    {
        _date = theCurrentTime.ToShortDateString(); // converts date to string 
    }
    
    public void WriteEntry() // stores the new entry
    {
        Console.WriteLine($"Date: {_date} - Prompt: {rndPrompt} ");
        Console.Write("> ");
        journalContent = Console.ReadLine();
    } 

}