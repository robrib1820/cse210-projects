using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Fear not, only believe";
        video1._author = "Jeffrey R. Holland";
        video1._duration = 793;
        Comment comment1 = new Comment();
        Comment commentY = new Comment();
        comment1._personsName.Add("Robson Ribeiro");
        comment1._comments.Add("What a great spoke to our latter days!");
        comment1._personsName.Add("André Luis");
        comment1._comments.Add("I love the spokes from Elder Holland.");
        comment1._personsName.Add("Débora Garcia");
        comment1._comments.Add("All we need for our days are teachings like this!");


        video1._commentsList.Add(comment1);


        Video video2 = new Video();
        video2._title = "Let Doing Good Be Our Normal";
        video2._author = "Rafael E. Pino";
        video2._duration = 567;
        Comment comment2 = new Comment();
        comment2._personsName.Add("Karlyn Eliza");
        comment2._comments.Add("Avocato is better with sault haha!");

        video2._commentsList.Add(comment2);


        Video video3 = new Video();
        video3._title = "Overcome the World and Find Rest";
        video3._author = "Russell M. Nelson";
        video3._duration = 1123;
        Comment comment3 = new Comment();
        comment3._personsName.Add("Liz Agreda");
        comment3._comments.Add("President Nelson it's a prophet of God");
        video3._commentsList.Add(comment3);


        Console.WriteLine("------------------------------------------------------------");
        video1.DisplayVideoInfo();
        Console.WriteLine("------------------------------------------------------------");
        video2.DisplayVideoInfo();
        Console.WriteLine("------------------------------------------------------------");
        video3.DisplayVideoInfo();
        Console.WriteLine("------------------------------------------------------------");
    }
}