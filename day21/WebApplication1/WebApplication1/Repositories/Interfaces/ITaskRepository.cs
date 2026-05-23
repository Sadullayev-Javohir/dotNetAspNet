using WebApplication1.Models;

namespace WebApplication1.Repositories.Interfaces;

public interface ITaskRepository
{
    Task<List<TaskItem>> GetAllAsync();
    Task<TaskItem?> GetByIdAsync(int id);
    Task<TaskItem> CreateAsync(TaskItem task);
    Task UpdatedAsync(TaskItem task);
    Task DeleteAsync(TaskItem task);
}
