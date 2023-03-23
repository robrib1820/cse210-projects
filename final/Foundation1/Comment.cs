using System;
public class Comment
{
    public string _personName;
    public string _commentText;
    //Methods
    public void CommentTag() {
        Console.WriteLine($"Person: {_personName}");
        Console.WriteLine($"Comments: {_commentText}");
    }
}