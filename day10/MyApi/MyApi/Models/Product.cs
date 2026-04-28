using System.ComponentModel.DataAnnotations;

namespace MyApi.Models;

public class Product
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name majburiy")]
    [MaxLength(50)]
    public string Name { get; set; }
    
    [Range(1, 10000, ErrorMessage = "Price 1-10000 orasida bo'lishi kerak")]
    public decimal Price { get; set; }
}