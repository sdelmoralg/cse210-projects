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
   public string _entry;

   public string _menu;
   
   public string JournalMenu()  // menu options 
   {
      _menu = "Please select one of the following choices::\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ";
      return _menu;
      
   }
} // borrar 


//    public void SaveEntry() // saves journal file
//    {
//       Console.WriteLine("Please enter a file name: ");
//       _fileName = Console.ReadLine();
//       using (StreamWriter outputFile = new StreamWriter(_fileName))
//       {
//          outputFile.WriteLine(_entry);
//       }

//    }


//    public void LoadEndry() // loads all entries * ask for file name

//    {
//       Console.WriteLine("What is the file name? ");
//       string _nameOfTheFile = Console.ReadLine();
//       string [] lines = System.IO.File.ReadAllLines(_nameOfTheFile);

//       foreach (string line in lines)
//       {
//          string[] parts = line.Split("Date:");
         
//       }
   
//    }
   
// }


