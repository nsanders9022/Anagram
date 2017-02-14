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


      // act
      List<string> result = testAnagram.Compare(testAltWord);

      // assert
      List<string> resultList = new List<string>{};
      resultList.Add("beard");
      Assert.Equal(resultList, result);
    }


    [Fact]
    public void Compare_singleWordOutOfTwo_true()
    {
      // arrange
      string testWord = "bread";
      string testAltWord = "beard dread";
      Anagram testAnagram = new Anagram(testWord);


      // act
      List<string> result = testAnagram.Compare(testAltWord);

      // assert
      List<string> resultList = new List<string>{};
      resultList.Add("beard");
      Assert.Equal(resultList, result);
    }
  }
}
