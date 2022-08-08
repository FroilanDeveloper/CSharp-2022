using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;



public class HomeController : Controller
{
  [HttpGet("/")]
  public IActionResult Survey()
  {
    
    return View();
  }

  [HttpPost("/survey")]
  public IActionResult Result(HomeModel  newSubmitted) // Dotnet takes the field from our form and creates an object base on the view model that we defined
  {
    if (ModelState.IsValid)
    {
    return View("Result", newSubmitted); 
    } 
    else
    {
      return View("Survey");
    }
  }
}


