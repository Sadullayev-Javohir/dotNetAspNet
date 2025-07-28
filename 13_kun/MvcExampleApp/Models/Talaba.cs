using System;
using System.ComponentModel.DataAnnotations;

namespace MvcExampleApp.Models
{
  public class Talaba
  {
    [Required(ErrorMessage = "Ism majburiy")]
    public string? Ism { get; set; }

    [Required(ErrorMessage = "Familya majburiy")]
    public string? Familya { get; set; }

    [Required(ErrorMessage = "Email majburiy")]
    [EmailAddress(ErrorMessage = "To‘g‘ri email kiriting")]
    public string? Email { get; set; }

    [Range(15, 100, ErrorMessage = "Yosh 15 va 100 orasida bo‘lishi kerak")]
    public int Yosh { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Tug‘ilgan sana")]
    public DateTime TugilganSana { get; set; }
  }
}
