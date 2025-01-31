using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Journal menu = new Journal();
        Console.WriteLine(menu.JournalMenu()); // shows the journal menu

        Journal entry = new Journal();

        Prompts prompt = new Prompts();


        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        
        string choice = Console.ReadLine();  // user input to pick choices
        if (choice == "1")
        {
            Console.Write($"Date: {date} - ");
            Console.WriteLine(prompt.DisplayPrompt());  
            // entry.WriteEntry();
            // TODO add this to the list of entries 

        }
    } /// borrar este

} // borrar este 
    
//         if (choice == "2")
//         {
//             // Display Journal
//         }

//         if (choice == "3")
//         {
//             // load
//         }

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