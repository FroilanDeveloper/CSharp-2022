// Using statements
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
namespace CRUDelicious.Controllers;
  
public class DishController : Controller
{
  private CRUDeliciousContext _context;
    
  // here we can "inject" our context service into the constructor
  public DishController(CRUDeliciousContext context)
  {
    _context = context;
  }
  [HttpGet("/")]
  [HttpGet("/dishes/all")]
  public IActionResult AllDishes()
  {   //                   MyDataBase.Dishes.ToList();
    List<Dish> AllDishes = _context.Dishes.ToList();
    // _context has collection of Dish and convert it to a list function
    return View("All", AllDishes);
  }

  [HttpGet("/dishes/new")]
  public IActionResult New()
  {
    return View("New");
  }

  [HttpPost("/dishes/create")]
  public IActionResult Create(Dish newDish)
  {
    if ( ModelState.IsValid)
    {
    _context.Dishes.Add(newDish);
    _context.SaveChanges();
    List<Dish> AllDishes = _context.Dishes.OrderByDescending(f => f.CreatedAt).ToList();
    return RedirectToAction("AllDishes");
    }
    else
    {
      return View("New");
    }
  }

  [HttpGet("/dishes/{dishId}")]
  public IActionResult ViewDish(int dishId)
  {
    Dish? dish = _context.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
    if (dish == null)
    {
      return RedirectToAction("All");
    }
    return View("Detail", dish);
  }

  [HttpGet("/edit/{dishId}")]
  public IActionResult Edit(int dishId)
  {
    Dish? dish = _context.Dishes.FirstOrDefault(dishes => dishes.DishId == dishId);
    return View("Edit", dish);
  }

  [HttpPost("/edit/dish/{dishId}")] 
  public IActionResult UpdatedDish(int dishId, Dish food)
  {
    if (ModelState.IsValid)
    {
      Dish? dish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
      dish.Name = food.Name;
      dish.Chef = food.Chef;
      dish.Tastiness = food.Tastiness;
      dish.Calories = food.Calories;
      dish.Description = food.Description;
      dish.UpdatedAt = DateTime.Now;
      
      _context.Update(dish); // make sure put update
      _context.SaveChanges();
      return RedirectToAction("AllDishes"); // redirecting to wrong route instead of "ALL" should be "ALLDishes"
    }else
    {
      return View("Edit", dishId);
    }

  }



  [HttpGet("/delete/{dishId}")]
  public IActionResult Delete(int dishId)
  {
    Dish? dish = _context.Dishes.SingleOrDefault(dishes => dishes.DishId == dishId);
    if (dish != null)
    {
      _context.Dishes.Remove(dish);
      _context.SaveChanges();
    }
    return RedirectToAction("AllDishes"); 
  }
}

