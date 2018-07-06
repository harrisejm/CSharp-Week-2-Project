using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {

        // [HttpGet("/words")]
        // public ActionResult Index()
        // {
        //     List<RepeatCounter> allItems = RepeatCounter.GetAll();
        //     return View(allWords);
        // }

        [HttpGet("/words/new")]
        public ActionResult CreateForm()
        {
            return View();
        }


        // [HttpPost("/words")]
        // public ActionResult Create()
        // {
        //   RepeatCounter newWord= new RepeatCounter(Request.Form["new-word"]);
        //   //newItem.Save();
        //   List<RepeatCounter> allItems = Item.GetAll();
        //   return View("Index", allItems);
        // }

        // [HttpPost("/items/delete")]
        // public ActionResult DeleteAll()
        // {
        //     Item.ClearAll();
        //     return View();
        // }

    }
}
