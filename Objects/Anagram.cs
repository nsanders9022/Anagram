using System;
using System.Collections.Generic;

namespace AnagramApp.Objects
{
  public class Anagram
  {
    private string _word;

    public Anagram(string word)
    {
      _word = word;
    }
// this will get and set word
    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string word)
    {
      _word = word;
    }

// function for sorting characters into an array

    public bool Compare(string altWord)
    {
      int count = 0;
      string word = GetWord();
      char[] wordArray = word.ToCharArray();
      char[] altWordArray = altWord.ToCharArray();
      Array.Sort(wordArray);
      Array.Sort(altWordArray);

      Console.WriteLine(wordArray);
      Console.WriteLine(altWordArray);

      for (int i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] == altWordArray[i])
        {
        count += 1;
        }
      }
      if (count == wordArray.Length)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
