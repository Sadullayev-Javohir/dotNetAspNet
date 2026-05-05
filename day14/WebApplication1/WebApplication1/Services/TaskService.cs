using WebApplication1.Models;

namespace WebApplication1.Services;

public class TaskService : ITaskService
{
    private readonly List<TaskItem> _tasks = new();
    private int _id = 1;

    public List<TaskItem> GetAll() => _tasks;

    public TaskItem GetById(int id) => _tasks.FirstOrDefault(x => x.Id == id);

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
        task.Title = updatedTask.Title;
        task.Description = updatedTask.Description;
        task.IsCompleted = updatedTask.IsCompleted;
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