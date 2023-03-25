using System;

public class Video
{
    public string _title;
    public string _author;
    public List<Comment> _commentsList = new List<Comment>();
    public int _duration;
    public int _comments;

    //Methods
    public void DisplayVideoInfo() {
        foreach (Comment comment in _commentsList)
        {
            Console.WriteLine($"TITLE: {_title} - AUTHOR: {_author} - DURATION: {_duration}");
            Console.WriteLine("Comments of the video:");
            comment.CommentTag();
        }
    }
    public int NumbOfComments() {
        return _comments;
    }
}