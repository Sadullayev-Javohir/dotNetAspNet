namespace WebApplication1.DTOs;

public class UpdateTaskDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty; 
    public bool IsCompleted { get; set; }
}