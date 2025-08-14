using System.ComponentModel.DataAnnotations;
namespace Annotation.Models;
public class RegisterViewModel
{
  [Required(ErrorMessage = "Ism majburiy")]
  [StringLength(50, MinimumLength = 2, ErrorMessage = "2-50 oralig'ida bo'lishi kerak")]
  public string FirstName { get; set; }

  [Required(ErrorMessage = "Familya majburiy")]
  [StringLength(50, MinimumLength = 2, ErrorMessage = "2-50 oralig'ida bo'lishi kerak")]
  public string FamilyName { get; set; }

  [Required(ErrorMessage = "Email majburiy")]
  [EmailAddress(ErrorMessage = "Email formati noto'g'ri")]
  public string Email { get; set; }

  [Required(ErrorMessage = "Parol majburiy")]
  [DataType(DataType.Password)]
  [StringLength(100, MinimumLength = 6, ErrorMessage = "6-100 oralig'ida bo'lishi kerak")]
  public string Password { get; set; }

  [Required(ErrorMessage = "Parol majburiy")]
  [DataType(DataType.Password)]
  [Compare("Password", ErrorMessage = "Mos emas")]
  public string ConfirmPassword { get; set; }
}
