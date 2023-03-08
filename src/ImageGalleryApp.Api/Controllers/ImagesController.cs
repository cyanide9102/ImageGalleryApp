using Microsoft.AspNetCore.Mvc;

namespace ImageGalleryApp.Api.Controllers;
public class ImagesController : ApiControllerBase
{
    private readonly ILogger<ImagesController> _logger;

    public ImagesController(ILogger<ImagesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetImages()
    {
        try
        {
            return Ok(Enumerable.Empty<object>());
        }
        catch (Exception e)
        {
            return Problem(e.Message, statusCode: StatusCodes.Status500InternalServerError);
        }
    }
}
