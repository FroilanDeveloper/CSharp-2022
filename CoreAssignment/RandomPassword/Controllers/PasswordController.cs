using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPassword.Models;
using Microsoft.AspNetCore.Http;

public class PasswordController : Controller
{
  [HttpGet("/")]
  public IActionResult Generate()
  { 
  int? Count = HttpContext.Session.GetInt32("amount");
  if(Count == null )
  {
    HttpContext.Session.SetInt32("amount", 1);
  }
  Password newPassword = new Password();
  return View("Random", newPassword);
  }

  [HttpPost("/addCount")]
  public IActionResult addCount()
  {
    int? PasswordCount = HttpContext.Session.GetInt32("amount");
    if (PasswordCount == null)
    {
      PasswordCount = 1;
    }
    else{
      PasswordCount += 1;
    }
    HttpContext.Session.SetInt32("amount", (int)PasswordCount);
    return RedirectToAction("Generate");
  }
}

