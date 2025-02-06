using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpGet("test")]
    public IActionResult Add()
    {
        return Ok("Service alive!");
    }
}