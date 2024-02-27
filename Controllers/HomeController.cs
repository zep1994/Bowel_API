using Microsoft.AspNetCore.Mvc;

namespace Bowel_API.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    [Route("/")]

    public IActionResult Get()
    {
        return Ok(new { message = "Hello, world!" });
    }
}
