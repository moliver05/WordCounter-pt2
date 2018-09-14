using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string _text;
    private string _input;
    private static List<Word> _instances = new List<Word>{};

    public void SetPrivateInput(string input)
    {
      _input = input;
    }

    public string GetPrivateInput()
    {
      return _input;

    }

    public void SetPrivateText(string text)
    {
      _text = text;
    }

    public string GetPrivateText()
    {
      return _text;

    }

    public static List<Word> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

// Split the words
    public static string[] SplitTheText(string text)
    {
    string[] splitText = text.Split(' ');
    return splitText;
    }

// Loop function
    public static int CountTheWords(string input, string[] splitText)
    {
      int matches = 0;
      foreach(string text in splitText)
    {
      if (text.Equals(input))
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
