using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

public class Journal
{
   // this should contain all of my journal entries
   // needs behaviors such as adding an entry, dispalying all entries, saving to a file, loading from a file.

   // the display method should iterate through all Entry objects
   // and call the Entry display method. 

   // should store a list of Entry objects the data type for this should be List<Entry>

  

   // public List<Entry> _entries = new List<Entry>();

   public string _fileName = "";
   public string _entry;

   public string _menu;

   public string JournalMenu()  // menu options 
   {
      _menu = "Welcome to your Journal\nPlease select one of the following choices::\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit";
      return _menu;
      
   }
   // public void SaveEntry() // saves journal file
   // {
   //    Console.WriteLine("Please enter a file name: ");
   //    _fileName = Console.ReadLine();
   //    using (StreamWriter outputFile = new StreamWriter(_fileName))
   //    {
   //       outputFile.WriteLine(_entry);
   //    }

   // }
}

//    public void WriteEntry() // 
//    {
//       Console.WriteLine(">");
//       _entry = Console.ReadLine();
   
//    }


//    public void LoadEndry() // loads 
//    {

//    }

//    public List<Entry> DisplayJournal() // displays all journal contents
//    {
//       public List<Entry> entries = new List<Entry>();

//       return entries;
//    }

   
   
// }


