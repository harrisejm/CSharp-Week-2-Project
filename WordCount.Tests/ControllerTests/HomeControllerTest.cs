using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      ActionResult indexView = controller.Index();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestClass]
    public class WordCounterControllerTest
    {

      [TestMethod]
      public void IndexWords_ReturnsCorrectView_True()
      {
        //Arrange
        WordCounterController controller = new WordCounterController();

        //Act
        ActionResult indexView = controller.Index();

        //Assert
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void CreateFormWords_ReturnsCorrectView_True()
      {
        //Arrange
        WordCounterController controller = new WordCounterController();

        //Act
        ActionResult CreatFormView = controller.CreateForm();

        //Assert
        Assert.IsInstanceOfType(CreatFormView, typeof(ViewResult));
      }



    }
  }
}
