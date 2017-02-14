using Xunit;
using AnagramApp.Objects;
using System;
using System.Collections.Generic;

namespace AnagramApp
{
  public class AnagramTest
  {
    [Fact]
    public void Compare_singleWord_true()
    {
      // arrange
      string testWord = "bread";
      string testAltWord = "beard";
      Anagram testAnagram = new Anagram(testWord);
      Console.WriteLine(testWord);
      Console.WriteLine(testAltWord);

      // act
      bool result = testAnagram.Compare(testAltWord);

      // assert
      Assert.Equal(true, result);
    }
  }
}
