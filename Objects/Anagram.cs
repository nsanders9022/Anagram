using System;
using System.Collections.Generic;

namespace AnagramApp.Objects
{
  public class Anagram
  {
    private string _word;
     private static List<string> _anagramList = new List<string> {};

    public Anagram(string word)
    {
      _word = word;
      _anagramList = new List<string>{};
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

    public List<string> GetArgumentList()
    {
      return _anagramList;
    }

// function for sorting characters into an array

    public List<string> Compare(string altWord)
    {

      string[] altWordList = altWord.Split(' ');
      // List<string> anagramList = new List<string>{};


      for (int word = 0; word < altWordList.Length; word++)
      {
        int count = 0;
        string userWord = GetWord();
        Console.WriteLine(userWord);
        char[] wordArray = userWord.ToCharArray();
        char[] altWordArray = altWordList[word].ToCharArray();
        Array.Sort(wordArray);
        Array.Sort(altWordArray);

        if (wordArray.Length == altWordArray.Length)
        {
          for (int i = 0; i < wordArray.Length; i++)
          {
            if (wordArray[i] == altWordArray[i])
            {
            count += 1;
            }
          }
        }
        else
        {
          break;
        }

        if (count == wordArray.Length)
        {
          _anagramList.Add(altWordList[word]);
        }
      }
      return _anagramList;

    }
  }
}
