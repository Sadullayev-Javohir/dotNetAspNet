using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models;

public class TaskItem
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Ism bo'lishi kerak")]
    [MinLength(3)]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Tavsif bo'lishi kerak")]
    [Length(0, 1000)]
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    
    public DateTime createdAt { get; set; } = DateTime.Now;
}