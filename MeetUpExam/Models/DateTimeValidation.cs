#pragma warning disable CS8765
#pragma warning disable CS8603

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
namespace MeetUpExam.Models;

[NotMapped]

public class DateTimeValidation : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        int result = DateTime.Compare(DateTime.Now, (DateTime)value);
        if(result > 0)
        {
            return new ValidationResult("Date must be in the future!");
        }
        return ValidationResult.Success;
    }
}