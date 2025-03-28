using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();  /// video list - ya funciona

        Video video1 = new Video("How to Learn Spanish in 2 weeks", "Robert Garcia", 300);  
        video1.AddComment("Grace Larsen", "Great video! i always wanted to learn spanish");  //name, comment
        video1.AddComment("Gladys Martinez", "Good advice, but it would take more time than that");
        video1.AddComment("Matthew Olsen", "best way to learn is to live in a spanish speaking country");

        Video video2 = new Video("How being bilingual made me 5k dollars!", "Kate Ramos", 450);
        video2.AddComment("Jonathan Davis", "It opens up more doors thats for sure!");
        video2.AddComment("Lucia Thorpe","I love your video, keep up the good work!");
        video2.AddComment("Chase Wilson", "i learned a useless language, wish i would have learn spanish instead");
        video2.AddComment("Hazel Mendoza","i dont believe it");

        Video video3 = new Video("Comparing cultures", "SuperHolly", 1380);
        video3.AddComment("Maria Garcia", "I love your videos, Holly!");
        video3.AddComment("Sebastian Marx", "each culture has good and bad things");
        video3.AddComment("Martha Sandoval", "When i went to the USA everyone was so nice! I loved it!");

        Video video4 = new Video("Learning a new language opens up new doors", "Marie Grey", 560);
        video4.AddComment("James White", "I speak 3 languages. I get many more job opportunities than my friends that only speak english");
        video4.AddComment("Ashley Mayers", "i agree with everything you said");
        video4.AddComment("Amanda Railey", "I wish they would teach that in schools");
        video4.AddComment("Emily Kirn", "everyone is too lazy now to learn a new language");
   
        // add videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
          
        foreach (var video in videos  )
        {
            video.DisplayVideoInfo();
            Console.WriteLine();               
        }
    }
}