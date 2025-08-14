using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CustomValidator.Models.CustomValidators;

public class StrongPasswordAttribute : ValidationAttribute
{
  public StrongPasswordAttribute()
  {
    ErrorMessage = "Parol kamida 1ta katta harf va 1ta raqamdan iborat bo'lishi kerak.";
  }

  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    var password = value as string;
    if (string.IsNullOrWhiteSpace(password))
    {
      return new ValidationResult("Parol bo'sh bo'lishi mumkin emas");
    }

    if (!password.Any(char.IsUpper))
    {
      return new ValidationResult("Parol kamida 1 ta katta harf boi'lishi kerak");
    }
    if (!password.Any(char.IsDigit))
    {
      return new ValidationResult("Parolda kamida 1 ta raqam bo'lishi kerak");
    }
    return ValidationResult.Success;
  }
}
