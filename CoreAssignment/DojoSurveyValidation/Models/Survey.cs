#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models;

public class Survey
{
  [Required (ErrorMessage = "Name is required!")]
  [MinLength(2, ErrorMessage = "Atleast 2 characters long!")]
  public string FullName { get; set; }

  [Required (ErrorMessage = "Location is required!")]
  public string Location { get; set; }

  [Required (ErrorMessage = "Language is required!")]
  public string Language { get; set; }

  [MinLength(20, ErrorMessage = "Must be atleast 20 characters long")]
  public string? Comment { get; set; }
}