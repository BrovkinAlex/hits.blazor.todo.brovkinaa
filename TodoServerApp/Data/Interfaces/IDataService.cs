public interface IDataService
{
    Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
}