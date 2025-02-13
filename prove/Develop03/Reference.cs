using System;
using System.Data;

public class Reference  // Keeps track of the book, chapter, and verse information.
{ 
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

//Provide multiple constructors for the scripture reference to handle the
//case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").

    public Reference(string book, int chapter, int initialVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = initialVerse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int initialVerse, int finalVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = initialVerse;
        _endVerse = finalVerse;
    }

// methods

    public string DisplayText()
    {
        if (_endVerse == 0)
        {
            string stringReference = $"{_book} {_chapter}:{_verse}";
            return stringReference;
        }
        else
        {
            string stringReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return stringReference;
        }
    }
}