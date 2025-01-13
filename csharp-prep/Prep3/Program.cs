using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string userResponse = Console.ReadLine();
        int magicNumber = int.Parse(userResponse);*/
        
        string keepPlaying = "yes";
        
        while (keepPlaying == "yes")
        {
            int guess = 0;
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            while (magicNumber != guess)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if  (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }

            Console.WriteLine("Do you want to play again? ");
            keepPlaying = Console.ReadLine();

        }
        
        Console.WriteLine("Thanks for playing");
        
    }
}