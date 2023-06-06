using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.Dtos;

public class CreateMovieDto
{
    [Required(ErrorMessage = "Title is requried")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Gender is requried")]
    [StringLength(50, ErrorMessage = "The max size is 50")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Duration is requried")]
    [Range(70, 600, ErrorMessage = "The duration must be in 70min and 600min")]
    public int Duration { get; set; }
}
