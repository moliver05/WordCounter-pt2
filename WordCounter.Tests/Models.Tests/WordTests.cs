using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Word.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void CountTheWords_NumberOfWords()
    {
      //Arrange
      string input = "Mochi";
      string output = "Mochi is my favorite icecream";
      int count = 1;

      // Act
      int result = RepeatCounter.CountTheWords(input, RepeatCounter.SplitTheText(output));

      //Assert
      Assert.AreEqual(count, result);
    }

    [TestMethod]
    public void wordSearch_Returns_True()
    {
    // Arrange
    string wordSearch = "hungry";
    string givenSentence = "I am always hungry."
    int result = 1;

    // Act
    int actualResult = RepeatCounter.CountTheWords(wordSearch, userInput);

    // Assert
    Assert.AreEqual(result, actualResult);
    }

    [TestMethod]
    public void wordSearchNeeds_MatchingWord_True()
    {
      // Arrange
      string wordSearch = "hungry";
      string givenSentence = "I am full";
      int result = 0;

      // Act
      int actualResult = RepeatCounter.CountTheWords(wordSearch, userInput);

      // Assert
      Assert.AreNotEqual(result, actualResult);
    }
  }
}
