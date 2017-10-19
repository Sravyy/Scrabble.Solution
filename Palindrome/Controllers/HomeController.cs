
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Palindrome;

namespace Palindrome.Controllers
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
      Palindrome newPal = new Palindrome(Request.Form["str"]);
          return View (newPal);
    }
  }
}
