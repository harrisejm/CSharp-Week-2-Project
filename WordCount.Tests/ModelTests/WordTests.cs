using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;
namespace WordCounter.Tests
{
  [TestClass]
  public class TestWordCounter
  {
    [TestMethod]
    public void wordNumber()
    {
      RepeatCounter word = new RepeatCounter("Hello", "hi");
      Assert.AreEqual("hellohi" , word.testOutput()); //Test MS TEST
    }

    [TestMethod]
    public void testArr()
    {
      RepeatCounter word = new RepeatCounter("Hello", "HELLO WORLD HELLO");
      Assert.AreEqual("\"" + "hello" + "\"" + " appears 2 times in the sentence: " + "\"" + "hello world hello" + "\"", word.test() ); //test() return wordArr[0];
    }

    [TestMethod]
    public void testFinalOutput()
    {
      RepeatCounter word = new RepeatCounter("Hello", "hello World hello");
      Assert.AreEqual("\"" + "hello" + "\"" + " appears 2 times in the sentence: " + "\"" + "hello world hello" + "\"", word.test());
    }
    
    [TestMethod]
    public void testFinalOutput1()
    {
      RepeatCounter word = new RepeatCounter("Hello", "Hello. World? Hello: helLO! HELLO; hellO!");
      Assert.AreEqual("\"" + "hello" + "\"" + " appears 5 times in the sentence: " + "\"" + "hello. world? hello: hello! hello; hello!" + "\"", word.test());
    }
  }
}
