using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterApp.Models
{
  public class WordCounter
  {
    private static int _wordCount;

    public static int WordCountCalc(string userWord, string userSentence)
    {
      userWord = userWord.ToLower();
      userSentence = userSentence.ToLower();
      if(userSentence.Contains(userWord))
      {
        _wordCount += 1;
        return _wordCount;
      }
      return _wordCount;

    }
  }
}
