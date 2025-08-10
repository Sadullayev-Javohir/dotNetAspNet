using System.ComponentModel.DataAnnotations;

namespace File.Models;

public class RegisterViewModel
{
  [Required(ErrorMessage = "Ism kiritish majburiy")]
  [StringLength(50, MinimumLength = 3, ErrorMessage = "Ism 3-50 belgi oralig'ida bo'lishi kerak")]
  public string FirstName { get; set; }

  [Required(ErrorMessage = "Email kiritish majburiy")]
  [EmailAddress(ErrorMessage = "Email formati noto'g'ri")]
  public string Email { get; set; }

  [Required(ErrorMessage = "Yosh kiritish majburiy")]
  [Range(18, 60, ErrorMessage = "Yosh 18-60 oralig'ida bo'lishi kerak")]
  public int Age { get; set; }

  [Required(ErrorMessage = "TElefon raqam kiritish majburiy")]
  [RegularExpression(@"^\+998\d{9}$", ErrorMessage = "Telefon formati noto'g'ri")]
  public string Phone { get; set; }

  [Required(ErrorMessage = "Parol kiritish majburiy")]
  [StringLength(100, MinimumLength = 6, ErrorMessage = "Parol uzunligi kamida 6 belgi bo‘lishi kerak")]
  public string Password { get; set; }

  [Required(ErrorMessage = "Parol kiritish majburiy")]
  [Compare("Password", ErrorMessage = "Parol mos emas")]
  public string ConfirmPassword { get; set; }
}

