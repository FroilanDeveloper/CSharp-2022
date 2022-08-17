#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefNDishes.Models;
public class Dish
{
  [Key]
  public int DishId {get; set;}


  [Required(ErrorMessage = "is required")]
  [MinLength(2, ErrorMessage = "must be at least 2 characters")]
  public string Name { get; set; }

  [Required(ErrorMessage = "is required")]
  [MinLength(2, ErrorMessage = "must be at least 2 characters")]

  public int Tastiness { get; set; }


  [Required(ErrorMessage = "is required")]
  public int Calories { get; set; }


  [Required(ErrorMessage = "is required")]
  public string Description { get; set; }


  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; } = DateTime.Now;

  public int ChefId { get; set; }

}