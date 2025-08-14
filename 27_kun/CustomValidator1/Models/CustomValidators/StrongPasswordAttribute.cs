using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CustomValidator1.Models.CustomValidators;

public class StrongPasswordAttribute : ValidationAttribute
{
  public StrongPasswordAttribute()
  {
    ErrorMessage = "Parol kamida 1 ta katta harf va 1 ta raqamdan iborat bo'lishi kerak";
  }

  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    var password = value as string;
    if (string.IsNullOrWhiteSpace(password))
    {
      return new ValidationResult("Parol bo'sh bo'lmasligi kerak");
    }

    if (!password.Any(char.IsUpper))
    {
      return new ValidationResult("Parol kamida 1 ta katta harf bo'lishi kerak");
    }

    if (!password.Any(char.IsDigit))
    {
      return new ValidationResult("Parol kamida 1 ta raqam bo'lishi kerak");
    }

    return ValidationResult.Success;
  }
}
