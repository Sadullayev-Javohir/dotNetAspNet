using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
[LogActionFilter]
[CustomExceptionFilter]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;
    public TasksController(ITaskService taskService) => _taskService = taskService;

    /// <summary>
    /// Hamma tasklarni qaytaradi
    /// </summary>
    [HttpGet]
    public IActionResult GetAll()
    {
        var tasks = _taskService.GetAll();
        return Ok(tasks);
    }

    /// <summary>
    /// Id bo'yicha task qaytaradi
    /// </summary>
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var task = _taskService.GetById(id);
        if (task == null) return NotFound("Task topilmadi");
        return Ok(task);
    }

    /// <summary>
    /// Yangi task yaratadi
    /// </summary>
    [HttpPost]
    public IActionResult Create(TaskItem task)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var createdTask = _taskService.Create(task);

        return CreatedAtAction(
            nameof(GetById),
            new { id = createdTask.Id },
            createdTask);
    }


    /// <summary>
    /// Taskni update qil
    /// </summary>
    [HttpPut("{id}")]
    public IActionResult Update(int id, TaskItem task)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        var updated = _taskService.Update(id, task);
        if (!updated) return NotFound("Task topilmadi");
        return Ok("Updated sucessfully");
    }

    /// <summary>
    /// Taskni o'chiradi
    /// </summary>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var deleted = _taskService.Delete(id);
        if (!deleted) return NotFound("Task topilmadi");
        return Ok("Deleted sucessfully");
    }
}