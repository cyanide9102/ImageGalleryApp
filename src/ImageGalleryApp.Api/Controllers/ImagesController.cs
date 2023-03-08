using ImageGalleryApp.Api.Dtos;
using ImageGalleryApp.Core.Entities;
using ImageGalleryApp.Core.Interfaces;

using Microsoft.AspNetCore.Mvc;

namespace ImageGalleryApp.Api.Controllers;
public class ImagesController : ApiControllerBase
{
    private readonly IRepository<Image> _imgRepository;
    private readonly ILogger<ImagesController> _logger;

    public ImagesController(IRepository<Image> imgRepository, ILogger<ImagesController> logger)
    {
        _imgRepository = imgRepository;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetImages()
    {
        try
        {
            var images = await _imgRepository.ListAsync();
            return Ok(images);
        }
        catch (Exception e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPost]
    public async Task<IActionResult> AddImage([FromForm] ImageRequestDto dto)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string imagePath = await UploadImage(dto.ImageFile);

            var image = new Image(dto.Name, imagePath);
            await _imgRepository.AddAsync(image);
            await _imgRepository.SaveChangesAsync();

            return NoContent();
        }
        catch (Exception e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status500InternalServerError);
        }
    }

    private static async Task<string> UploadImage(IFormFile imageFile)
    {
        try
        {
            string fileName = new string(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Trim().Replace(' ', '-').ToLower();
            fileName = $"{fileName}-{DateTime.UtcNow.Ticks}{Path.GetExtension(imageFile.FileName)}";

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", fileName);

            using var stream = System.IO.File.Create(filePath);
            await imageFile.CopyToAsync(stream);
            stream.Dispose();

            var path = $"/images/{fileName}";
            return path;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
