using WebApplication1.DTOs;
using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repository;
    private readonly ILogger<TaskService> _logger;

    public TaskService(ITaskRepository repository, ILogger<TaskService> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<List<TaskResponseDto>> GetAllAsync()
    {
        _logger.LogInformation("Getting all tasks");
        var tasks = await _repository.GetAllAsync();
        return tasks.Select(MapToDto).ToList();
    }

    public async Task<TaskResponseDto?> GetByIdAsync(int id)
    {
        _logger.LogInformation("Getting task {Id} ", id);

        var task = await _repository.GetByIdAsync(id);
        if (task is null)
        {
            _logger.LogWarning("Task not found {Id}", id);
            return null;
        }

        return MapToDto(task);
    }

    public async Task<TaskResponseDto> CreateAsync(CreateTaskDto dto)
    {
        var task = new TaskItem
        {
            Title = dto.Title,
            Description = dto.Description
        };
        await _repository.CreateAsync(task);
        _logger.LogInformation("Task created");
        return MapToDto(task);
    }

    public async Task<bool> updatedAsync(int id, UpdateTaskDto dto)
    {
        var task = await _repository.GetByIdAsync(id);
        if (task is null) return false;

            task.Title = dto.Title;
            task.Description = dto.Description;
            task.IsCompleted = dto.IsCompleted;

            await _repository.UpdatedAsync(task);
            return true;
        
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var task = await _repository.GetByIdAsync(id);

        if (task is null) return false;
        await _repository.DeleteAsync(task);
        return true;
    }

    public async Task<bool> CompleteTaskAsync(int id)
    {
        var task = await _repository.GetByIdAsync(id);
        if (task is null) return false;
        task.IsCompleted = true;
        await _repository.UpdatedAsync(task);
        return true;
    }

    private static TaskResponseDto MapToDto(TaskItem task)
    {
        return new TaskResponseDto
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            IsCompleted = task.IsCompleted,
            CreatedAt = task.CreatedAt
        };
    }
}