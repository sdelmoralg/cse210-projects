using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _commentList;

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public int numOfComments()
    {
        return // number of commetns
    
    }

    public void DisplayVideoInfo()
    {
        // video info 
    }

}
