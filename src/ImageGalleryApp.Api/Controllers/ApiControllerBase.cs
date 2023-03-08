using Microsoft.AspNetCore.Mvc;

namespace ImageGalleryApp.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{
    public ApiControllerBase()
    {
    }
}
