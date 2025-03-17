using System;

// exceeding requirements - added exception handling in some parts of the program
class Program
{
	static void Main(string[] args)
	{
		Manager m = new Manager();
		
		bool quitButton = false;
		while (quitButton == false)
		{
			m.DisplayTotalPoints();
			Console.Write("\nMenu Options:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\nSelect a choice from the menu: ");
			string menuOption = Console.ReadLine();

			if (menuOption == "1")
			{
				Console.Clear();
				Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhich type of goal would you like to create? ");
				string goalOption = Console.ReadLine();

				if (goalOption == "1")
				{
					Goal s = new Simple("Simple Goal", "", "", 0);
					s.UserInput();	
					m.AddToList(s);
				}
				else if (goalOption == "2")
				{
					Goal e = new Eternal("Eternal Goal", "", "", 0);
					e.UserInput();
					m.AddToList(e);
				}

				else if (goalOption == "3")
				{
					Goal c = new Checklist("Checklist Goal", "", "", 0, 0, 0);
					c.UserInput();
					m.AddToList(c);
				}
				Console.Clear(); 
			}

			else if (menuOption == "2")
			{
				m.DisplayGoalList();
			}

			else if (menuOption == "3")
			{
				m.SaveGoal();
			}

			else if (menuOption == "4")
			{
				m.LoadGoal(); 
				// m.DisplayGoalList();
			}

			else if (menuOption == "5")
			{
				m.DisplayGoalList();
				Console.WriteLine("Which goal did you accomplish? ");
            	int goalIndex = int.Parse(Console.ReadLine()) - 1; // matches the goal index
				Goal goal = m._goalList[goalIndex];
            	goal.RecordEvent(m);  // updates points
			}

			else if (menuOption == "6")
			{
				Console.WriteLine("Goodbye!\n");
				quitButton = true;
			}

			else
			{
				Console.WriteLine("\nPlease choose a valid option.\n\nPress enter to continue");
				Console.ReadLine();
				Console.Clear();
			}
		}
	}
}