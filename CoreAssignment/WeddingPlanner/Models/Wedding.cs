#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;

public class Wedding
{
    [Key]
    public int WeddingId {get; set;}
    [Required(ErrorMessage = "is required")]
    [Display(Name = "Date ")]
    public DateTime Date {get; set;}
    [Required(ErrorMessage = "is required")]
    [Display(Name = "Address ")]
    public string Address {get; set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Wedder One ")]
    public string PersonOne {get; set;}
    [Required(ErrorMessage = "is required")]
    [Display(Name = "Wedder Two ")]
    public string PersonTwo {get; set;}
    public int? Creator {get; set;}
    [Required]
    public DateTime CreatedAt {get; set;} = DateTime.Now;
    [Required]
    public DateTime UpdatedAt {get; set;} = DateTime.Now;

    public List<Association> Attendees {get; set;} = new List<Association>();

    public string People()
    {
        return $"{PersonOne} & {PersonTwo}";
    }

}