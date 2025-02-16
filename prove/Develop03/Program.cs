using System;

class Program
{
    static void Main(string[] args)
    {
        List<(string book, int chapter, int verseStart, int verseEnd, string text)> scriptureLibrary = new List<(string, int, int, int, string)>
        {
            ("John", 3, 16, 0, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            ("2 Nephi", 2, 25, 0, "Adam fell that men might be; and men are, that they might have joy."),
            ("Moroni", 10, 4, 5, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."),
            ("Doctrine and Covenants", 130, 20, 21, "There is a law, irrevocably decreed in heaven before the foundations of this world, upon which all blessings are predicated— And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated."),
            ("Doctrine and Covenants", 64, 10, 0, "I, the Lord, will forgive whom I will forgive, but of you it is required to forgive all men."),
            ("Ether", 12, 27, 0, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."),
            ("Doctrine and Covenants", 112, 10, 0, "Be thou humble; and the Lord thy God shall lead thee by the hand, and give thee answer to thy prayers.")
        };

        Random random = new Random();
        int index = random.Next(scriptureLibrary.Count);
        var randomScripture = scriptureLibrary[index];

        //Reference r = new Reference("John", 3, 16);
        Reference r = new Reference(randomScripture.book, randomScripture.chapter, randomScripture.verseStart, randomScripture.verseEnd);
        //Scripture s = new Scripture(r, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture s = new Scripture(r, randomScripture.text);

        bool quitButton = false;

        while (quitButton == false && s.IsCompletelyHidden() == false)
        {
            Console.Clear();
            s.DisplayText();
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                quitButton = true;
            }
            s.HideWords();
            if (s.IsCompletelyHidden() == true)  // allows completely hidden scripture to be shown
            {
                Console.Clear();
                s.DisplayText();
                Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
                Console.ReadLine();
            }
        }
    
      
    }
}
