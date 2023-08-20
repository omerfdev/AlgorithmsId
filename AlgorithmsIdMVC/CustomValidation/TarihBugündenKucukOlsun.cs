using System.ComponentModel.DataAnnotations;

namespace AlgorithmsIdMVC.CustomValidation
{
    public class TarihBugündenKucukOlsun:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime date = (DateTime)value;
            if (date>DateTime.Now)
            {
                return new ValidationResult("Tarih bugunden buyuk olamaz");
            }
            return ValidationResult.Success;
        }
    }
}
