using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List <Video> videos = new List<Video>();

        Video video1 = new Video("Hola Argentina", "Julian Maccaferri", 180);
        video1._comments.Add(new Comment("Bruno", "Beautiful country!"));
        video1._comments.Add(new Comment("Roberto", "Can't wait to visit"));
        video1._comments.Add(new Comment("Lucia", "Awesome Video!!!"));
        videos.Add(video1);

        Video video2 = new Video("The Joy of Cooking Milhouse", "Edna Crabapell", 523);
        video2._comments.Add(new Comment("Principal Skinner", "Mmm yommy"));
        video2._comments.Add(new Comment("Nurse Doris", "Delisous"));
        video2._comments.Add(new Comment("Willie", "Don't be afraid kid I'll save you"));
        videos.Add(video2);

        Video video3 = new Video("El gol del siglo", "Diego Maradona", 30);
        video3._comments.Add(new Comment("Victor Morales", "Barrilete cosmico, de que planeta viniste?"));
        video3._comments.Add(new Comment("Rodrigo", "Sembro alegria en el pueblo, rego de gloria este suelo"));
        video3._comments.Add(new Comment("Ciro", "A los poderosos reta y ataca a los mas villanos sin mas armas en la mano que un 10 en la camiseta"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lenght} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment.GetCommentDetails());
            }

            Console.WriteLine();
        }       
    }
}