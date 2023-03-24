using System;
public class Comment
{
    public string _personName;
    public string _commentText;
    //Methods
    public string CommentTag() {

        Console.WriteLine($"Person: {_personName}");
        string person = Console.ReadLine();
        Console.WriteLine($"Comments: {_commentText}");
        string comment = Console.ReadLine();
        return (person + " " + comment);
    }
}