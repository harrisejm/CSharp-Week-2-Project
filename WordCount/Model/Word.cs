using System;
using System.Collections.Generic;
namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string _userWord;
    public string _userString;
    public RepeatCounter(string userWord, string userString)
    {
      _userWord = userWord.ToLower();
      _userString = userString.ToLower();
    }

    public string test()
    {
      int finalOutput = 0;
      string[]separator = {" ", ".", ",", "?", "!", ";", ":"};
      string[]wordArr = _userString.Split(separator, StringSplitOptions.None);
      for (int index = 0; index < wordArr.Length; index++)
      {
        if (wordArr[index] == _userWord)
        {
          finalOutput += 1;
        }
      }
      return _userWord + " appears " + finalOutput + " times.";
    }

  //  test to see if MStest is working
    public string testOutput()
    {
      return _userWord + _userString;
    }
  }
  //
  // class OutputWords
  // {
  //   static void Main()
  //   {
  //     Console.WriteLine("Enter Word");
  //     string userInputWord = Console.ReadLine();
  //     Console.WriteLine("Enter string");
  //     string userInputString = Console.ReadLine();
  //     RepeatCounter word = new RepeatCounter(userInputWord, userInputString);
  //     Console.WriteLine(word.test());
  //   }
  // }
}
