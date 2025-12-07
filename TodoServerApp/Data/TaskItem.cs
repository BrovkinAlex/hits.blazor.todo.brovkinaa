using System.ComponentModel.DataAnnotations;

public class TaskItem
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Description { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? FinishDate { get; set; }
}