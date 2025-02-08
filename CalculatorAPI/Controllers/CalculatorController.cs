using CalculatorAPI.Helpers;
using CalculatorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController(ICalculatorService calculatorService) : ControllerBase
{
    [HttpGet("add")]
    public IActionResult Add([FromQuery] double a, [FromQuery] double b)
    {
        var result = calculatorService.Add(a, b);
        return Ok(ApiResponse<double>.Success(result));
    }
    
    [HttpGet("subtract")]
    public IActionResult Subtract([FromQuery] double a, [FromQuery] double b)
    {
        var result = calculatorService.Subtract(a, b);
        return Ok(ApiResponse<double>.Success(result));
    }

    [HttpGet("multiply")]
    public IActionResult Multiply([FromQuery] double a, [FromQuery] double b)
    {
        var result = calculatorService.Multiply(a, b);
        return Ok(ApiResponse<double>.Success(result));
    }

    [HttpGet("divide")]
    public IActionResult Divide([FromQuery] double a, [FromQuery] double b)
    {
        try
        {
            var result = calculatorService.Divide(a, b);
            return Ok(ApiResponse<double>.Success(result));
        }
        catch (DivideByZeroException)
        {
            return BadRequest(ApiResponse<double>.Fail("Division by zero is not allowed."));
        }
    }
}