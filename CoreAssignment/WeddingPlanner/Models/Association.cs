namespace WeddingPlanner.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable CS8618

public class Association
{
    [Key]
    public int AssociationId { get; set; }


    public int WeddingId { get; set; }


    public int UserId { get; set; }

    public Wedding? Wedding { get; set; }

    public User? User { get; set; }
}