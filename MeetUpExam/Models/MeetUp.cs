namespace MeetUpExam.Models;

#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class MeetUp
{
    [Key]
    public int MeetUpId {get; set;}
    
    [Required(ErrorMessage = "is required")]
    [Display(Name = "Title: ")]
    public string Title {get; set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Date & Time: ")]
    [DateTimeValidation]
    public DateTime DateAndTime {get; set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Duration: ")]
    public int DurationNum {get; set;}

    [Required]
    public string DurationAmount {get; set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Description: ")]
    public string Description {get; set;}

    public int? UserId {get; set;}

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    [Required]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public User? User {get; set;}

    public List<Association> Attendees {get; set;} = new List<Association>();
}
