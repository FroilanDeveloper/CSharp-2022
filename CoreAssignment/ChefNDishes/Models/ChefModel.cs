#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefNDishes.Models;

public class Chef
{

  [Key]
  public int ChefId { get; set; }

  [Required(ErrorMessage = "is required")]
  public string FirstName { get; set; }

  [Required(ErrorMessage = "is required")]
  public string LastName { get; set; }

  [Required(ErrorMessage = "is required")]
  public DateTime DoB { get; set; }

  public DateTime CreatedAt { get;  set; }  = DateTime.Now;

  public DateTime UpdatedAt { get; set; } = DateTime.Now;

  public List<Dish> AllDishes { get; set; } = new List<Dish>();

}