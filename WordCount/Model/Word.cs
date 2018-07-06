using System;
using System.Collections.Generic;
namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string _userWord;
    public string _userString;
    public string _results;
    private static List<RepeatCounter> _wordInstances = new List<RepeatCounter> {};

    public RepeatCounter(string userWord, string userString)
    {
      _userWord = userWord.ToLower();
      _userString = userString.ToLower();
    }
    //////
    public string GetWord()
    {
      return _userWord;
    }
    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }
    ///
    public string GetSentence()
    {
      return _userString;
    }
    public void SetSentence(string newString)
    {
      _userString= newString;
    }
    /////
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
        else
        {
          finalOutput += 0;
        }
      }
      if (finalOutput == 1 )
      {
        return "\"" + _userWord + "\"" + " appears " + finalOutput + " time in the sentence: " + "\"" + _userString + "\"";
      }
      else
      {
        return "\"" + _userWord + "\"" + " appears " + finalOutput + " times in the sentence: " + "\"" + _userString + "\"";
      }
    }

    // ////

    public static List<RepeatCounter> GetAll()
    {
      return _wordInstances;
    }

    public void Save()
    {
      _wordInstances.Add(this);
    }

    public static void ClearAll()
    {
      _wordInstances.Clear();
    }

    //  test to see if MStest is working
    public string testOutput()
    {
      return _userWord + _userString;
    }
  }
}
