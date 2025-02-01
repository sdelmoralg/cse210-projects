using System;
using System.Reflection.Metadata;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal menu = new Journal();

        Entry entry = new Entry();

        Prompts prompt = new Prompts();

        entry.RamdomPrompt();

        // add while loop --- what wouid you like to do?

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

    } // borrar

} // borrar 

        // if (choice == "3")
        // {
        //     // load
        // }

//         if (choice == "4")
//         {
//             // save
//         }

//         else
//         {
//             // quit
//             Console.WriteLine("Goodbye");
//         }


//     }
    

// } 