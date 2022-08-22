namespace WeddingPlanner.Models;
#pragma warning disable CS8618
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
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required(ErrorMessage = " is Required")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "must be 8 characters or longer!")]
    [Display(Name = "Password ")]
    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    [NotMapped]
    [Compare("Password", ErrorMessage = "Passwords do not match!")]
    [DataType(DataType.Password)]

    [Display(Name = "Confirm Password ")]
    public string Confirm { get; set; }
    public List<Association> Attending { get; set; } = new List<Association>();

    public string Name()
    {
        return FirstName + " " + LastName;
    }
}