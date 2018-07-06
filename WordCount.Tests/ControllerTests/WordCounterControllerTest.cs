using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterControllerTest
  {
    [TestMethod]
    public void IndexWords_ReturnsCorrectView_True()
    {
      WordCounterController controller = new WordCounterController();

      ActionResult indexView = controller.Index();

      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void CreateFormWords_ReturnsCorrectView_True()
    {

      WordCounterController controller = new WordCounterController();

      ActionResult CreatFormView = controller.CreateForm();

      Assert.IsInstanceOfType(CreatFormView, typeof(ViewResult));
    }
  }
}
