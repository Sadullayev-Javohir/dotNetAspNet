using Microsoft.OpenApi;
using WebApplication2.Models;
namespace WebApplication2.Services;

public class TaskService : ITaskService
{
    private readonly List<TaskItem> _tasks = new();
    private int _id = 1;

    public List<TaskItem> GetAll() => _tasks;

    public TaskItem GetById(int id)
    {
        return _tasks.FirstOrDefault(x => x.Id == id);
    }

    public TaskItem Create(TaskItem task)
    {
        task.Id = _id++;
        _tasks.Add(task);
        return task;
    }

    public bool Update(int id, TaskItem updatedTask)
    {
        var task = _tasks.FirstOrDefault(x => x.Id == id);
        if (task == null) return false;

        task.Name = updatedTask.Name;
        task.Description = updatedTask.Description;
        task.IsCompleted = updatedTask.IsCompleted;
        task.createdAt = updatedTask.createdAt;
        return true;
    }

    public bool Delete(int id)
    {
        var task = _tasks.FirstOrDefault(x => x.Id == id);
        if (task == null) return false;
        _tasks.Remove(task);
        return true;    
    }
}