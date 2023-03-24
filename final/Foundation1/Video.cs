using System;

public class Video
{
    public string _title;
    public string _author;
    public List<Comment> _comments = new List<Comment>();
    public List<Video> _videos = new List<Video>();
    public int _duration;

    //Methods
    public void ListOdVideos() {
        foreach (Video video in _videos)
        {
            video.DisplayVideoInfo();
        }
    }
    public void DisplayVideoInfo() {
        
            Console.WriteLine($"Title: {_title}, Author: {_author}, Duration: {_duration}");
    }
}