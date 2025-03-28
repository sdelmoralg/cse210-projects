using System;
using System.Windows.Markup;
public class Video
{
    public string _title;    // private? 
    public string _author;
    public int _seconds;
    public List<Comment> _commentList;
                                            // getter and setters????
    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        _commentList = new List<Comment>();
    }

    public void AddComment(string name, string text) /// adds comments to the list
    {
        _commentList.Add(new Comment(name, text));
    }

    public int numOfComments()  // count the comments of each video
    {
        return _commentList.Count;
    }
    public void DisplayVideoInfo()
    {
        // title, author, length, number of comments and list of the comments
        Console.WriteLine($"\"{_title}\" by {_author}\nLength: {_seconds} seconds  -  Number of comments: {numOfComments()}");
        foreach (var comment in _commentList)
        {
            Console.WriteLine($"{comment._name}: {comment._text}"); 
        }
    }
}
