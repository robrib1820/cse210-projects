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
        comment1._personName = "Robson Ribeiro";
        comment1._commentText ="Excelent video about the principle of faith";
        video1._comments.Add(comment1);

        Video video2 = new Video();
        video2._title = "Let Doing Good Be Our Normal";
        video2._author = "Rafael E. Pino";
        video2._duration = 567;
        Comment comment2 = new Comment();
        comment2._personName = "Karlyn Eliza";
        comment2._commentText ="Avocato is better with sault haha!";
        video1._comments.Add(comment2);

        Video video3 = new Video();
        video3._title = "Overcome the World and Find Rest";
        video3._author = "Russell M. Nelson";
        video3._duration = 1123;
        Comment comment3 = new Comment();
        comment3._personName = "Robson Ribeiro";
        comment3._commentText ="What a great spoke to our latter days!";
        video1._comments.Add(comment3);
        
        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
        

    }
}