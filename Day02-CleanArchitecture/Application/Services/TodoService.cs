using Domain;
using Domain.Interfaces;

namespace Application.Services;
public class TodoService
{
    private readonly ITodoRepository _repository;

    public TodoService(ITodoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ToDoItem>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<ToDoItem?> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task AddAsync(ToDoItem item)
    {
        await _repository.AddAsync(item);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task UpdateAsync(ToDoItem item)
    {
        await _repository.UpdateAsync(item);
    }
}
