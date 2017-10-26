
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Scrabble;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/results")]
    public ActionResult Results()
    {
      Scrabble newScore = new Scrabble(Request.Form["str"]);
          return View (newScore);
    }
  }
}
