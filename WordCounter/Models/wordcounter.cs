using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _userInput;
    private string _result;
    private int _countMatch;

    public RepeatCounter(string userInput, string result)
    {
      _userInput = userInput;
      _result = result;
    }
    public void SetCountMatch(int countMatch)
    {
      _countMatch = countMatch;
    }

    public int GetCountMatch()
    {
      return _countMatch;
    }

    public void SetUserResult(string result)
    {
      _result = result;
    }

    public string GetUserResult()
    {
      return _result;

    }

    public void SetUserInput(string userInput)
    {
      _userInput = userInput;
    }

    public string GetUserInput()
    {
      return _userInput;

    }

// Split the words
    public static string[] SplitTheText(string userInput)
    {
    char[] DeleteExtras= new char[] {',','.','!','?',':',';',' '};
    string[] wordsInput = userInput.Split(DeleteExtras);
    return wordsInput;
    }

// Loop function
    public static int CountTheWords(string wordSearch, string[] result)
    {
      int matches = 0;
      foreach(string userInput in result)
    {
      if (userInput == wordSearch)
      {
         matches ++;
      }
    }
      return matches;
    }
  }

  // public class Program
  // {
  //     public static void Main()
  //   {
  //     Console.WriteLine("Welcome to WordCounter Program");
  //     Console.WriteLine("Please type in a word");
  //     string wordInput = Console.ReadLine();
  //     Console.WriteLine("Please type in a text");
  //     string textInput = Console.ReadLine();
  //     RepeatCounter counterInstance = new RepeatCounter();
  //     counterInstance.SetPrivateInput(wordInput);
  //     counterInstance.SetPrivateText(textInput);
  //     string wordToCount = counterInstance.GetPrivateInput();
  //     string[] textToCount = RepeatCounter.SplitTheText(counterInstance.GetPrivateText());
  //     int totalCounts = RepeatCounter.CountTheWords(wordToCount, textToCount);
  //     Console.WriteLine("Count is :"+ totalCounts);
  //
  //
  //
  //   }
  // }
}
