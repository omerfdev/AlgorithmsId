using System.ComponentModel.DataAnnotations;

namespace AlgorithmsIdMVC.CustomValidation
{
    public class SifirdanBuyukOlsun:ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int deger=(int)value;
            if ( deger==0) 
            {
                return new ValidationResult("DEĞER SIFIRA EŞİT VEYA KÜÇÜK OLAMAZ");           
            }
            else if (deger < 0)
            {
                return new ValidationResult("DEĞER SIFIRA EŞİT VEYA KÜÇÜK OLAMAZ");
            }
            return ValidationResult.Success;
        }
    }
}
