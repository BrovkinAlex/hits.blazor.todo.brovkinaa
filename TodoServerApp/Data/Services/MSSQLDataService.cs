
using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data;

public class MSSQLDataService(ApplicationDbContext context) : IDataService
{
    public async Task<IEnumerable<TaskItem>> GetAllAsync()
    {
        return await context.TaskItem.ToArrayAsync();
    }

    public async Task SaveAsync(TaskItem item)
    {
        if (item.Id == 0)
        {
            item.CreatedDate = DateTime.Now;
            await context.TaskItem.AddAsync(item);
        } else {
            context.TaskItem.Update(item);
        }
        await context.SaveChangesAsync();
    }

    public async Task<TaskItem> GetTaskAsync(int id)
    {
        return await context.TaskItem.FirstAsync(x => x.Id == id);
    }

    public async Task DeleteAsync(int id)
    {
        var taskItem = await context.TaskItem.FirstAsync(x => x.Id == id);
        context.TaskItem.Remove(taskItem);
        await context.SaveChangesAsync();
    }
}