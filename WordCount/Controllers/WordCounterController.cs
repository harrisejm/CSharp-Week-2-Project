using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordController : Controller
    {

        [HttpGet("/words")]
        public ActionResult Index()
        {
            List<Item> allItems = Item.GetAll();
            return View(allItems);
        }

        [HttpGet("/words/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/words")]
        public ActionResult Create()
        {
          Item newWord= new Item (Request.Form["new-item"]);
          //newItem.Save();
          List<Item> allItems = Item.GetAll();
          return View("Index", allItems);
        }

        // [HttpPost("/items/delete")]
        // public ActionResult DeleteAll()
        // {
        //     Item.ClearAll();
        //     return View();
        // }

    }
}
