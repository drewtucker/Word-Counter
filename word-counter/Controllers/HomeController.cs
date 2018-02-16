using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounterApp.Models;

namespace WordCounterApp.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult Display()
    {
      RepeatCounter.ClearAll();
      RepeatCounter newCount = new RepeatCounter();
      string userWord = (Request.Form["userWord"]);
      string userSentence = (Request.Form["userSentence"]);

      int result = RepeatCounter.WordCountCalc(userWord, userSentence);

      return View("Index", newCount);
    }



  }
}
