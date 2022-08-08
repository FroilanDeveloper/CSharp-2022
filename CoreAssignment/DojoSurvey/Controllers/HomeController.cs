

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

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}

