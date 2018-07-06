using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        //
        // [HttpGet("/words")]
        // public ActionResult Index()
        // {
        // //    List<RepeatCounter> allWords = RepeatCounter.GetAll();
        //     return View();
        // }

        [HttpGet("/words/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpGet("/words")]
        public ActionResult Index()
        {
          List<RepeatCounter> allWords = RepeatCounter.GetAll();
            return View(allWords);
        }


        [HttpPost("/words")]
        public ActionResult Create()
        {
          RepeatCounter newWord = new RepeatCounter(Request.Form["firstWord"], Request.Form["testSentence"]);
          newWord.Save();
          List<RepeatCounter> allWords = RepeatCounter.GetAll();
          return View("Index", allWords);
        }

        [HttpPost("/words/delete")]
        public ActionResult DeleteAll()
        {
            RepeatCounter.ClearAll();
            return View();
        }

    }
}
