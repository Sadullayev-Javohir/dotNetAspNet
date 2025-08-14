using System.ComponentModel.DataAnnotations;
using CustomValidator1.Models.CustomValidators;

namespace CustomValidator1.Models;

public class RegisterViewModel
{
  [Required(ErrorMessage = "Ism majburiy")]
  [StringLength(50, MinimumLength = 2, ErrorMessage = "Ism uzunligi 2-50 oralig'ida bo'lishi kerak")]
  public string FirstName { get; set; }

  [Required(ErrorMessage = "Familya majburiy")]
  [StringLength(50, MinimumLength = 2)]
  public string LastName { get; set; }

  [Required(ErrorMessage = "Email majburiy")]
  [EmailAddress(ErrorMessage = "Email formati noto'g'ri")]
  public string Email { get; set; }

  [Required(ErrorMessage = "Parol majburiy")]
  [DataType(DataType.Password)]
  [StringLength(100, MinimumLength = 6, ErrorMessage = "Parol kamida 6 belgi bo'lishi kerak")]
  [StrongPassword]
  public string Password { get; set; }

  [Required(ErrorMessage = "Parolni tasdiqlash majburiy")]
  [DataType(DataType.Password)]
  [Compare("Password", ErrorMessage = "Parollar mos kelmadi ")]
  public string ConfirmPassword { get; set; }

}
