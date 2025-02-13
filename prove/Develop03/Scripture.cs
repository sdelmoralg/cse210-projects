using System;
using System.Collections.Generic;

public class Scripture   // Keeps track of the reference and the text of the scripture.
                         // Can hide words and get the rendered display of the text.
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;

// Constructors: accepts both a reference and the text of the scripture.

// use the class by passing the
// text of the scripture as a single string with all of the words in it.
// Then, the constructor would have the responsibility of creating the list,
// and splitting up the words in the string to create Word objects for each
// one and put them in the list

    public Scripture (Reference reference, string text)
    {
        _reference = reference;   
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }



// methods 

    public string HideWords()
    {
        Random rndm = new Random();
    }

    public string GetRenderedText()
    {

    }

    public void IsCompletelyHidden()
    {

    }
}