using CalculatorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorController(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }
    
    [HttpGet("add")]
    public IActionResult Add([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(_calculatorService.Add(a, b));
    }
    
    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(_calculatorService.Subtract(a, b));
    }

    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery] double a, [FromQuery] double b)
    {
        return Ok(_calculatorService.Multiply(a, b));
    }

    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] double a, [FromQuery] double b)
    {
        if (b == 0)
            return BadRequest("Cannot divide by zero.");

        return Ok(_calculatorService.Divide(a, b));
    }
}