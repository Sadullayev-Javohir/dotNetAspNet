using System.ComponentModel.DataAnnotations;
using CustomValidator.Models.CustomValidators;

namespace CustomValidator.Models;

public class RegisterViewModel
{
  [Required(ErrorMessage = "Ism majburiy")]
  [StringLength(50, MinimumLength = 2, ErrorMessage = "Ism uzunligi 2-50 oralig'ida")]
  public string FirstName { get; set; }

  [Required(ErrorMessage = "Familya majburiy")]
  [StringLength(50, MinimumLength = 2)]
  public string LastName { get; set; }

  [Required(ErrorMessage = "Email majburiy")]
  [EmailAddress(ErrorMessage = "Email formati noto'g'ri")]
  public string Email { get; set; }

  [Required(ErrorMessage = "Parol majburiy")]
  [DataType(DataType.Password)]
  [StringLength(100, MinimumLength = 6, ErrorMessage = "Parol kamida 6-100 oralig'ida bo'lishi kerak")]
  [StrongPassword]
  public string Password { get; set; }

  [Required(ErrorMessage = "Parolni tasdiqlash majburiy")]
  [DataType(DataType.Password)]
  [Compare("Password", ErrorMessage = "Parollar mos emas")]
  public string ConfirmPassword { get; set; }
}
