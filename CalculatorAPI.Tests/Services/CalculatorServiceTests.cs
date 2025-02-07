using CalculatorAPI.Services;

namespace CalculatorAPI.Tests.Services;

public class CalculatorServiceTests
{
    private readonly ICalculatorService _calculatorService;

    public CalculatorServiceTests()
    {
        _calculatorService = new CalculatorService();
    }
    
    [Fact]
    public void Add_ReturnsCorrectResult()
    {
        // Arrange
        double a = 5, b = 3;

        // Act
        double result = _calculatorService.Add(a, b);

        // Assert
        Assert.Equal(8.0, result);
    }
    
    [Fact]
    public void Subtract_ReturnsCorrectResult()
    {
        // Arrange
        double a = 10, b = 4;
        
        // Act
        double result = _calculatorService.Subtract(a, b);
        
        // Assert
        Assert.Equal(6.0, result);
    }

    [Fact]
    public void Multiply_ReturnsCorrectResult()
    {
        // Arrange
        double a = 6, b = 7;
        
        // Act
        double result = _calculatorService.Multiply(a, b);
        
        // Assert
        Assert.Equal(42.0, result);
    }

    [Fact]
    public void Divide_ReturnsCorrectResult()
    {
        // Arrange
        double a = 20, b = 4;
        
        // Act
        double result = _calculatorService.Subtract(a, b);
        
        // Assert
        Assert.Equal(16.0, result);
    }

    [Fact]
    public void Divide_ThrowsException_WhenDividingByZero()
    {
        // Arrange
        double a = 10, b = 0;
        
        // Act
        
        // Assert
        Assert.Throws<DivideByZeroException>(() => _calculatorService.Divide(10, 0));
    }
}