using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Globalization;
using System.IO.Enumeration;

   // this should contain all of my journal entries
   // needs behaviors such as adding an entry, dispalying all entries, saving to a file, loading from a file.

   // the display method should iterate through all Entry objects
   // and call the Entry display method. 

   // should store a list of Entry objects the data type for this should be List<Entry>

public class Journal
{  
   public string _fileName;
   public List<Entry> _entries = new List<Entry>();
   public Entry e = new Entry();
   public string _menu;
   public string JournalMenu()  // menu options 
   {
      _menu = "Please select one of the following choices::\n1. Write\n2. Save\n3. Load\n4. Display\n5. Quit\nWhat would you like to do? ";
      return _menu;     
   }

   public void AddEntry(Entry entry) // adds entry to the journal
   {
      _entries.Add(entry);
   }

   public void SaveEntry() // creates the journal file
   {
      Console.WriteLine("Please enter a file name: ");
      _fileName = Console.ReadLine();

      using (StreamWriter outputFile = new StreamWriter(_fileName))
      {
         foreach (Entry e in _entries) // saves each entry
         {
            outputFile.WriteLine($"Date: {e._date} - Prompt: {e.rndPrompt} "); // saves date and prompt
            outputFile.WriteLine($"> {e.journalContent}\n"); // saves the user answer to the prompt           
         }         
      }
   }

   public void LoadJournal() // loads all entries * ask for file name
   {
      Console.WriteLine("Please enter the file name: ");
      string fileName = Console.ReadLine();

      string[] lines = System.IO.File.ReadAllLines(fileName);
      
      for (int i = 1; i <= lines.Length/3; i++)
      {
         Entry e = new Entry();
         e._date = lines[3 * i - 3].Substring(6, lines[3 * i - 3].IndexOf("-") - 8);  // extracts date from each date line in text file
         e.rndPrompt = lines[3 * i - 3].Substring(lines[3 * i - 3].IndexOf("-") + 10); //same but prompt
         e.journalContent = lines[3 * i - 2].Substring(2); // same but content
         _entries.Add(e);
      }         
   }   
    public void DisplayJournal() // displays all entries in the journal 
    {
         if (_entries.Count == 0)
         {
            Console.WriteLine("No entries to display");
         }

         foreach (Entry e in _entries)
         {
            Console.WriteLine($"Date: {e._date} - Prompt: {e.rndPrompt} "); 
            Console.WriteLine($"> {e.journalContent}\n");
         } 
    }
}


