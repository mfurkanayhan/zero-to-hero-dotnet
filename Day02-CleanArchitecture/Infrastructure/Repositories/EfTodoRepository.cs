using Domain;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class EfTodoRepository : ITodoRepository
{
    private readonly AppDbContext _context;
    public EfTodoRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<ToDoItem>> GetAllAsync()
    {
        return await _context.ToDoItems.AsNoTracking().ToListAsync();
    }
    public async Task<ToDoItem?> GetByIdAsync(Guid id)
    {
        return await _context.ToDoItems.FindAsync(id);
    }
    public async Task AddAsync(ToDoItem item)
    {
        await _context.ToDoItems.AddAsync(item);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteAsync(Guid id)
    {
        var entity = await _context.ToDoItems.FindAsync(id);
        if (entity != null)
        {
            _context.ToDoItems.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
    public async Task UpdateAsync(ToDoItem item)
    {
        _context.ToDoItems.Update(item);
        await _context.SaveChangesAsync();
    }
}
