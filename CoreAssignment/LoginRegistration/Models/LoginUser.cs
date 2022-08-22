#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LoginRegistration.Models;
public class LoginUser
{
    [Required(ErrorMessage = "is required to login!")]
    public string Email {get; set;}
    [Required(ErrorMessage = "is required to login!")]
    public string Password {get; set;}
}