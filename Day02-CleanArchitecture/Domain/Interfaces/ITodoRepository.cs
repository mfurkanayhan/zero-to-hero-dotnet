namespace Domain.Interfaces;
public interface ITodoRepository
{
    Task<IEnumerable<ToDoItem>> GetAllAsync();
    Task<ToDoItem?> GetByIdAsync(Guid id);
    Task AddAsync(ToDoItem item);
    Task DeleteAsync(Guid id);
    Task UpdateAsync(ToDoItem item);
}