using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterApp.Models
{
  public class RepeatCounter
  {
    private static int _wordCount;

    public static int WordCountCalc(string userWord, string userSentence)
    {
      userWord = userWord.ToLower();
      string[] userSentenceArray = userSentence.ToLower().Split();
      foreach(string word in userSentenceArray)
      {
        if(word == userWord)
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }

    public static void ClearAll()
    {
      _wordCount = 0;
    }
  }
}
