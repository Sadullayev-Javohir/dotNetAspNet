using WebApplication1.DTOs;
using WebApplication1.Repositories;

namespace WebApplication1.Services.Interfaces;

public interface ITaskService
{
    Task<List<TaskResponseDto>> GetAllAsync();
    Task<TaskResponseDto?> GetByIdAsync(int id);
    Task<TaskResponseDto> CreateAsync(CreateTaskDto dto);
    Task<bool> updatedAsync(int id, UpdateTaskDto dto);
    Task<bool> DeleteAsync(int id);
    Task<bool> CompleteTaskAsync(int id);
    
}