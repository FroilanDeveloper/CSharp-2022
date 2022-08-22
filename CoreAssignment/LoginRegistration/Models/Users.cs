#pragma warning disable CS8618
namespace LoginRegistration.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class User
{
    [Key]
    public int UserId { get; set; }
    [Required(ErrorMessage = "is Required")]
    [Display(Name = "First Name ")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "is Required")]
    [Display(Name = "Last Name ")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "is Required")]
    [Display(Name = "Email ")]
    public string Email { get; set; }
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "is Required")]
    [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
    [Display(Name = "Password ")]
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password ")]
    public string Confirm { get; set; }
}

