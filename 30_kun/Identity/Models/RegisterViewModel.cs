using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
  // Ro'yxatdan o'tishda foydalanuvchi kiritadigan maydonlar
  public class RegisterViewModel
  {
    [Required] // FullName bo'sh qolmasligi kerak
    public string FullName { get; set; }

    [Required, EmailAddress] // Email bo'sh emas va to'g'ri formatda bo'lishi shart
    public string Email { get; set; }

    [Required, DataType(DataType.Password)] // Password maxfiy ko'rinishda kiritiladi
    public string Password { get; set; }

    [Required, Compare("Password", ErrorMessage = "Parollar mos emas!")]
    public string ConfirmPassword { get; set; }
  }
}
