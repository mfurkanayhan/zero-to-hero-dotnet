using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly TodoService _todoService;

    public TodoController(TodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var todos = await _todoService.GetAllAsync();
        return Ok(todos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var todo = await _todoService.GetByIdAsync(id);
        return todo == null ? NotFound() : Ok(todo);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] ToDoItem item)
    {
        await _todoService.AddAsync(item);
        return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] ToDoItem item)
    {
        await _todoService.UpdateAsync(item);
        return NoContent();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _todoService.DeleteAsync(id);
        return NoContent();
    }
}
