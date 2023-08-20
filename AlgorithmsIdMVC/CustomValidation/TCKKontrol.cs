using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmsIdMVC.CustomValidation
{
    public class TCKKontrol : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string tck = (string)value;
            if (tck == null)
            {
                return new ValidationResult("TCK Boş Olamaz.");
            }
            else if (tck.Length != 11)
            {
                return new ValidationResult("TCK 11 sayıdan oluşmaktadır.");
            }
            else if (tck[0] == '0') 
            {
                return new ValidationResult("TCK İlk rakamı sıfır olamaz.");
            }

            int deger = 0;
            for (int i = 0; i < 10; i++)
            {
                deger += int.Parse(tck[i].ToString()); 
            }

            if (deger % 10 != int.Parse(tck[10].ToString()))
            {
                return new ValidationResult("Geçerli TCK değil.");
            }

            bool onlyDigits = true;

            foreach (char c in tck)
            {
                if (!char.IsDigit(c))
                {
                    onlyDigits = false;
                    break;
                }
            }
            int digit1 = int.Parse(tck[0].ToString());
            int digit2 = int.Parse(tck[1].ToString());
            int digit3 = int.Parse(tck[2].ToString());
            int digit4 = int.Parse(tck[3].ToString());
            int digit5 = int.Parse(tck[4].ToString());
            int digit6 = int.Parse(tck[5].ToString());
            int digit7 = int.Parse(tck[6].ToString());
            int digit8 = int.Parse(tck[7].ToString());
            int digit9 = int.Parse(tck[8].ToString());
            int digit10 = int.Parse(tck[9].ToString());
            int digit11 = int.Parse(tck[10].ToString());

            int oddSum = digit1 + digit3 + digit5 + digit7 + digit9;
            int evenSum = digit2 + digit4 + digit6 + digit8;
            int result = (oddSum * 7 - evenSum) % 10;

            if (result != digit10) 
            {
                return new ValidationResult("Geçerli TCK değil.");
            }

            if  (!onlyDigits) 
            {
                return new ValidationResult("Geçerli TCK değil.");
            }

            return ValidationResult.Success;
        }
    }
}
