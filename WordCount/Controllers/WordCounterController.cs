using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/repeatCounter/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpGet("/repeatCounter")]
    public ActionResult Index()
    {
      List<RepeatCounter> allWords = RepeatCounter.GetAll();
      return View(allWords);
    }

    [HttpPost("/repeatCounter")]
    public ActionResult Create()
    {
      RepeatCounter newWord = new RepeatCounter(Request.Form["new-Word"], Request.Form["new-sentence"]);
      newWord.Save();
      List<RepeatCounter> allWords = RepeatCounter.GetAll();
      return View("Index", allWords);
    }

    [HttpPost("/repeatCounter/delete")]
    public ActionResult DeleteAll()
    {
      RepeatCounter.ClearAll();
      return View();
    }
  }
}
