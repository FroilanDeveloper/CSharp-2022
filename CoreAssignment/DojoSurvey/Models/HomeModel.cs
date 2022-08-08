#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace Survey.Models;

public class HomeSurvey
{
  [Required]
  [MinLength(2, ErrorMessage = "Atleast 2 characters long")]
  public string FullName { get; set; }
  [Display(Name ="Dojo Location")]
  public string Location { get; set; }

  [Display(Name ="Favorite Language")]

  public string Language { get; set; }

  [MinLength(20, ErrorMessage ="must be at least 20 characters long")]
  public string? Comment { get; set; }
}

