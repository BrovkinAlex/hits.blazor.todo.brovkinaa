
using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data;

public class MSSQLDataService(ApplicationDbContext context) : IDataService
{
    public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
    {
        return await context.TaskItem.ToArrayAsync();
    }
}