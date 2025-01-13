using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string userResponse = Console.ReadLine();
        int magicNumber = int.Parse(userResponse);*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

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

        
    }
}