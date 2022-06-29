using System.ComponentModel.DataAnnotations;

namespace ToDoList.Data.Models;

internal sealed class Post
{
    [Key]
    public int PostId { get; set; }
    [Required]
    [MaxLength(200)]

    public string? Title { get; set; }
    [Required]
    [MaxLength(200)]

    public string Content { get; set; } = string.Empty;

}
