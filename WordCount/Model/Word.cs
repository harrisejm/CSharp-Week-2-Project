using System;
using System.Collections.Generic;
namespace WordCounter
{
  public class RepeatCounter
  {
  public string _userWord;
  public string _userString;
  public RepeatCounter(string userWord, string userString)
  {
    _userWord = userWord;
    _userString = userString;
  }

  public string test()
  {
//  List<string> userString = new List<string>{}
  string[]separator = {" ", ".", " "};
  string[]wordArr = _userString.Split(separator, StringSplitOptions.None);
  return wordArr[0];
  }







  public string testOutput()
  {
    return _userWord + _userString;
  }

  }

    class OutputWords
  {
    static void Main()
    {
   Console.WriteLine("Enter Word");
   string userInputWord = Console.ReadLine();
   Console.WriteLine("Enter string");
   string userInputString = Console.ReadLine();
   RepeatCounter word = new RepeatCounter(userInputWord, userInputString);
   Console.WriteLine(word.test());


    }
  }
}
