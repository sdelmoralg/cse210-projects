using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Journal menu = new Journal();

        Entry entry = new Entry();

        entry.RamdomPrompt();

        // add while loop --- what wouid you like to do?
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
                entry.WriteEntry();

            }
    
            // if (choice == "2")
            // {
            //      /// add code to display journal content 
            // }


            // if (choice == "3")
            // {
            //     // load
            // }

    //         if (choice == "4")
    //         {
    //             // save
    //         }

            if (choice == "5")
            {
                quit = true;
            }

        }

    }

}



