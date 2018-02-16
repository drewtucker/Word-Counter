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



  }
}
