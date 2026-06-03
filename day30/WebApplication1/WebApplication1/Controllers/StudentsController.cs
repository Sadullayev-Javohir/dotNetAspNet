using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Data;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly AppDbContext _context;
    public StudentsController(AppDbContext context) => _context = context;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var students = await _context.Students.ToListAsync();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var student = _context.Students.FindAsync(id);

        if (student == null) return NotFound();
        return Ok(student);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        return Ok(student);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Student updated)
    {
        var student = await _context.Students.FindAsync(id);

        if (student == null) return NotFound();

        student.Name = updated.Name;
        student.Age = updated.Age;
        await _context.SaveChangesAsync();

        return Ok(student);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) return NotFound();

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
        return Ok("Deleted");
    }
}
