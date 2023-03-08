using System.ComponentModel.DataAnnotations;

namespace ImageGalleryApp.Api.Dtos;
public class ImageRequestDto
{
    [Required, StringLength(256)]
    public string Name { get; set; } = string.Empty;
    [Required]
    public IFormFile ImageFile { get; set; } = default!;
}
