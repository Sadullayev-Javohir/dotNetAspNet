using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
  // Login qilishda kiritiladigan ma'lumotlar
  public class LoginViewModel
  {
    [Required, EmailAddress] // Email kiritilishi majburiy va to'g'ri formatda bo'lishi kerak
    public string Email { get; set; }

    [Required, DataType(DataType.Password)] // Parol kiritilishi shart
    public string Password { get; set; }

    // Agar true bo'lsa -> foydalanuvchi uzoqroq vaqt tizimda qoladi (cookie muddati uzayadi)
    public bool RememberMe { get; set; }
  }
}
