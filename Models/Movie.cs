using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models;

public class Movie
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is requried")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Gender is requried")]
    [MaxLength(50, ErrorMessage = "The max size is 50")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Duration is requried")]
    [Range(70, 600, ErrorMessage = "The duration must be in 70min and 600min")]
    public int Duration { get; set; }
}
