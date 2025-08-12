using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
  [Required(ErrorMessage = "Ism majburiy")]
  [StringLength(50, ErrorMessage = "Ism 50 belgidan oshmasin")]
  public string FirstName { get; set; }

  [Required(ErrorMessage = "Email majburiy")]
  [EmailAddress(ErrorMessage = "Noto'g'ri email")]
  public string Email { get; set; }

  [Required]
  [MinLength(6, ErrorMessage = "Parol kamida 6 belgildan iborat bo'lishi kerak.")]
  public string Password { get; set; }

  [Compare("Password", ErrorMessage = "Parollar mos kelmadi")]
  public string ConfirmPassword { get; set; }
}
