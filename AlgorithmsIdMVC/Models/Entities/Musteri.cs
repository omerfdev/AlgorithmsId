using System.ComponentModel.DataAnnotations;
using ValidationMVC.CustomValidation;

namespace ValidationMVC.Models.Entities
{
    public class Musteri:IValidatableObject
    {
        [Display(Name = "Musteri Kodu"), Required(ErrorMessage = "{0} Boş Geçilemez")]
        [SifirdanBuyukOlsun]
        public int MusteriID { get; set; }

        [Display(Name = "Firma Ünvanı"), Required(ErrorMessage = "{0} Boş Geçilemez")]
        [MaxLength(50, ErrorMessage = "En Fazla 50 karakterden oluşabilir.")]
        public string CompanyName { get; set; }

        public enum CinsiyetTipi { Erkek, Kadın }
        [Display(Name = "Cinsiyet")]
        public CinsiyetTipi Gender { get; set; }

        [Display(Name = "E-Posta")]
        [EmailAddress(ErrorMessage = "Hatalı bir E-Posta girdiniz.")]
        public string? Email { get; set; }
        [TarihBugündenKucukOlsun]
        [Display(Name = "Doğum Günü")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Müşteri Notları")]
        [DataType(DataType.MultilineText)]
        public string? Notes { get; set; }

        [Display(Name = "İlgili Kişi")]
        [MinLength(5,ErrorMessage ="En az {1} karakter girme")]
        [RegularExpression("\\D*",ErrorMessage ="Sadece harf girebilirsiniz.")]       
        public string ContactName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Gender==CinsiyetTipi.Kadın)
            {
                if (Email==null)
                {
                    yield return new ValidationResult("kadın müşteriler eposta girmelidir.", new[] {"Gender","Email"});
                }
            }
        }
    }
}
