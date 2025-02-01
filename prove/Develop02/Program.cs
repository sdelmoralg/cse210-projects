using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal menu = new Journal();

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

            Console.WriteLine(menu.JournalMenu()); // shows the journal menu
    
            string choice = Console.ReadLine();  // user input to pick choices

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry.RandomPrompt(); 
                entry.WriteEntry();
                journal.AddEntry(entry);

            }
    
            if (choice == "2")
            {
                journal.SaveEntry();
            }


            // if (choice == "3")
            // {
            //     // load
            // }

    //         if (choice == "4")
    //         {
    //             // display
    //         }

            if (choice == "5")
            {
                quit = true;
            }

        }

    }

}



