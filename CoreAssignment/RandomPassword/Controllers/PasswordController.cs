using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPassword.Models;
using Microsoft.AspNetCore.Http;

public class PasswordController : Controller
{
  [HttpGet("/")]
  public IActionResult Generate()
  { 
    string AlphabetNums = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    Random random = new Random();
    string password = new string(Enumerable.Repeat(AlphabetNums, 14).Select(s=>s[random.Next(s.Length)]).ToArray()); // generating a string of letters and numbers with a length of 14 characters
  int? count = HttpContext.Session.GetInt32("amount");
  if(count == null )
  {
    count = 0; 
  }
  count++;
    HttpContext.Session.SetInt32("amount", (int)count);
    HttpContext.Session.SetString("password", password);
  return View("RandomPassword");
  }
}

