using System;
using System.Security.Cryptography.X509Certificates;

public class Word // Keeps track of a single word and whether it is shown or hidden.
{
    private string _word;
    private bool _hidden;

    // constructors: This constructor should likely accept the text of the word to save
    // it as an attribute. In addition, the constructor will need to set the initial
    //visibility of the word (whether it is shown or hidden).

    public Word(string word)
    {
        _word = word;
        _hidden = true;
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