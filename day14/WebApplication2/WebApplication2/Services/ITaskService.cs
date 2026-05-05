using WebApplication2.Models;

namespace WebApplication2.Services;

public interface ITaskService
{
    List<TaskItem> GetAll();
    TaskItem GetById(int id);
    TaskItem Create(TaskItem task);
    bool Update(int id, TaskItem updatedTask);
    bool Delete(int id);
}