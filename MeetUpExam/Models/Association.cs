namespace MeetUpExam.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable CS8618

public class Association
{
    [Key]
    public int AssociationId { get; set; }

    public int MeetUpId {get; set;}

    public int UserId {get; set;}

    public User? User {get; set;}

    public MeetUp? MeetUp {get; set;}

}