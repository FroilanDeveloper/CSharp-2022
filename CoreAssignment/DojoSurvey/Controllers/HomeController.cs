

using Microsoft.AspNetCore.Mvc;
using Survey.Models;

public class HomeController : Controller
{
  [HttpGet("/")]
  public IActionResult Survey()
  {
    return View();
  }

  [HttpPost("/survey")]
  public IActionResult Result(HomeSurvey  newSubmitted) // Dotnet takes the field from our form and creates an object base on the view model that we defined
  {
    return View(newSubmitted); 
  }
}

