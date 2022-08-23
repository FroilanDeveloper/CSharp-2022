#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MeetUpExam.Models;
[NotMapped]
public class LoginUser
{
    [Required(ErrorMessage = "is required to login!")]
    [Display(Name = "Email ")]
    public string EmailValid { get; set; }
    [Required(ErrorMessage = "is required to login!")]
    [Display(Name = "Password ")]
    public string PasswordValid { get; set; }
}