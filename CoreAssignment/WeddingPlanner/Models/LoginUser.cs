#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;
public class LoginUser
{
    [Required(ErrorMessage = "is required to login!")]
    [Display(Name = "Email ")]
    public string EmailValid { get; set; }
    [Required(ErrorMessage = "is required to login!")]
    [Display(Name = "Password ")]
    public string PasswordValid { get; set; }
}