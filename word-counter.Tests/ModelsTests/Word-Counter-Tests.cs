using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;

namespace WordCounterApp.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void GetInputLetters_ReturnWordCount_Int()
    {
      string TestLetter =  "A";
      string TestSentence = "A";
      int TestScore = 1;
      int CountedSentence = WordCounter.WordCountCalc(TestLetter, TestSentence);
      Assert.AreEqual(TestScore, CountedSentence);
    }
  }
}
