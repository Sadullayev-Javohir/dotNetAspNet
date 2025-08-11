using System.ComponentModel.DataAnnotations;

namespace ViewModelDemo.ViewModels;

public class ProductViewModel
{
  public int Id { get; set; }

  [Required(ErrorMessage = "Nomi majburiy")]
  public string Name { get; set; }

  [Range(0.01, 1000000, ErrorMessage = "Narx musbat bo'lishi kerak")]
  public decimal Price { get; set; }

  public string CreatedDate { get; set; }
}
