using System;
using System.Security.Cryptography.X509Certificates;

public class Word // Keeps track of a single word and whether it is shown or hidden.
{
    private string _word;
    public string _Word
    {
        get {return _word;}
    }

    private bool _hidden;
    public bool _Hidden
    {
        get {return _hidden;}
    }

    // constructors: the constructor will need to set the initial
    //visibility of the word (whether it is shown or hidden).

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    // methods

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetRenderedText()
    {
        if (_hidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}