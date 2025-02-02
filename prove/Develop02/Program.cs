using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {

       Journal journal = new Journal();

        bool quit = false;

        bool welcome = true;

        while (quit == false)
        {
            if (welcome == true)
            {
                Console.WriteLine("Welcome to your Journal");
                welcome = false;
            }

            Console.WriteLine(journal.JournalMenu()); // shows the journal menu
    
            string choice = Console.ReadLine();  // user input to pick choices

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry.RandomPrompt(); 
                entry.WriteEntry();
                journal.AddEntry(entry);

            }
    
            else if (choice == "2")
            {
                journal.SaveEntry();
            }

            else if (choice == "3") // load journal
            {
                journal.LoadJournal();
            }

            else if (choice == "4")
            {
                journal.DisplayJournal(); // displays the contents of the journal
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
                quit = true;
            }

            else
            {
                Console.WriteLine("Invalid response. Please try again");

            }

        }

    }

}



