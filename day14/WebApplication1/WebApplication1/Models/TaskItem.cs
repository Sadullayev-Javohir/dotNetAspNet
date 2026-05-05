using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Diagnostics;

namespace WebApplication1.Models;

public class TaskItem
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Title majburiy")]
    [MinLength(3)]
    public string Title { get; set; }
    
    [Required]
    [MinLength(3)]
    [MaxLength(1500)]
    public string Description { get; set; }
    
    public bool IsCompleted { get; set; }

    [Required] public DateTime CreatedAt { get; set; } = DateTime.Now;
}