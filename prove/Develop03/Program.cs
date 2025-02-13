using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r = new Reference("John", 3, 16);
        
        Scripture s = new Scripture(r, "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have eternal life.");
        s.Display();
      
    }
}
