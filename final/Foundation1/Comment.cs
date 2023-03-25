using System;
public class Comment
{
    public List<string> _personsName = new List<string>();
    
    public List<string> _comments = new List<string>();
    public int comments = 0;
    //Methods
    public void CommentTag() {
        for (int i = 0; i < _personsName.Count;i++)
        
        {
            Console.WriteLine($"PERSON: {_personsName[i]} -- COMMENT: {_comments[i]}");
            comments++;
        }
        Console.WriteLine($"This video has {comments} comments!");
    }
}