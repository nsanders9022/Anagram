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

    public List<string> Compare(string altWord)
    {

      string[] altWordList = altWord.Split(' ');
      List<string> anagramList = new List<string>{};

      for (int word = 0; word < altWordList.Length; word++)
      {
        int count = 0;
        string userWord = GetWord();
        Console.WriteLine(userWord);
        char[] wordArray = userWord.ToCharArray();
        char[] altWordArray = altWordList[word].ToCharArray();
        Array.Sort(wordArray);
        Array.Sort(altWordArray);

        for (int i = 0; i < wordArray.Length; i++)
        {
          if (wordArray[i] == altWordArray[i])
          {
          count += 1;
          }
        }
        if (count == wordArray.Length)
        {
          anagramList.Add(altWordList[word]);
          Console.WriteLine(anagramList);
        }
      }
      return anagramList;

    }
  }
}
