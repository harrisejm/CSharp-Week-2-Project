using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

using WordCounter;
namespace WordCounter.Tests
{
  [TestClass]
  public class TestWordCounter
  {
    [TestMethod]
    public void wordNumber()
    {
      RepeatCounter word = new RepeatCounter("Hello", "hi");
      Assert.AreEqual("Hellohi" , word.testOutput());
    }
  }
}
