using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main(string[] args)
    {

    	BreathingActivity a = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 5);

    	ReflectingActivity b = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 5);

    	ListingActivity c = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 5);

    	bool quitButton = false;
    	while (quitButton == false)
    	{
      	Console.Clear();
		Console.Write("Menu Options:\n\n1. Start Breathing Activity\n2. Start Reflecting Activity\n3. Start Listing Activity\n4. Quit\n\nSelect a choice from the menu: ");
        
      	string userInput = Console.ReadLine();
		Console.WriteLine();
        
      	if (userInput == "1")
      	{
        	a.RunBreathingActivity();   
      	}

      	else if (userInput == "2")
      	{
        	b.RunReflectingActivity();
     	}
          
      	else if (userInput == "3")
      	{
        	c.RunListingActivity();
      	}

      	else if (userInput == "4") 
      	{
        	Console.WriteLine("Goodbye");
        	quitButton = true;
      	}

      	else 
      	{
       		Console.WriteLine("Please choose a valid option: ");
        	Console.WriteLine();
      	}

    	}
  	}
}

