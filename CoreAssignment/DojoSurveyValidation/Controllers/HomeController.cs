using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }

  [HttpGet("/")]
  public IActionResult Survey()
  {
    
    return View();
  }

  [HttpPost("/result")]
  public IActionResult Result(Survey  newSubmitted) // Dotnet takes the field from our form and creates an object base on the view model that we defined
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
