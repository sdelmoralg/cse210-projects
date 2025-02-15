using System;
using System.Collections.Generic;

public class Scripture   // Keeps track of the reference and the text of the scripture.
                         // Can hide words and get the rendered display of the text.
{
    private Reference _reference;
    public List<Word> _words;

// Constructors: ""accepts both a reference and the text of the scripture.

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
    public void HideWords()
    {
        Random random = new Random();
       
        for (int i = 0; i < 3; i++)
        {
            if (IsCompletelyHidden() == true)
            {
                break;
            }

            int index = random.Next(_words.Count);
            if (_words[index]._Hidden  == false)
            {
                _words[index].Hide();
            }

            else
            {
                i--;
            }
        }
    }

    public void DisplayText()
    {
        Console.Write($"{_reference.DisplayReference()} ");
        foreach (Word word in _words)
        {
            if (word._Hidden == false)
            {
                Console.Write($"{word._word} ");
            }

            else
            {
                Console.Write($"{new string('_', word._word.Length)} ");
            }
        }
    }

    public bool IsCompletelyHidden()
    {
       if (_words.Any(Word => !Word._Hidden) == true)
       {
        return false;
       }
       else
       {
        return true;
       }
    }
}