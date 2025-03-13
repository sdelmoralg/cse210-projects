using System;

class Program
{
    static void Main(string[] args)
    {
		bool quitButton = false;
		while (quitButton == false)
		{
			// "You have {} points." // total points 
			Console.WriteLine("Menu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nSelect a choice from the menu: ");
			string menuOption = Console.ReadLine();

			if (menuOption == "1")
			{
				Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you liek to create? ");
				string goalOption = Console.ReadLine();

				if (goalOption == "1")
				{
					// simple goal
					// add to list // 
					// "what is the name of your goal?
					// "what is a short description of it?
					// what is the amount of points associated with this goal?
				}
				 else if (goalOption == "2")
				 {
					// eternal goal
				 }

				 else if (goalOption == "3")
				 {
					// checklist goal
				 }
			}

			else if (menuOption == "2")
			{
				// list goals
			}

			else if (menuOption == "3")
			{
				// save goals
			}

			else if (menuOption == "4")
			{
				// load goals
			}

			else if (menuOption == "5")
			{
				// record event
			}

			else if (menuOption == "6")
			{
				Console.WriteLine("Goodbye!\n");
				quitButton = true;
			}

			else
			{
				Console.WriteLine("Please choose a valid option.\nPress enter to continue");
				Console.ReadLine();
			}

		}


    }
}