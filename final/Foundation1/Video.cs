using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
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
