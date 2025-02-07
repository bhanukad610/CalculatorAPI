using CalculatorAPI.Controllers;
using CalculatorAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CalculatorAPI.Tests.Controllers
{
    public class CalculatorControllerTests
    {
        private readonly Mock<ICalculatorService> _mockCalculatorService;
        private readonly CalculatorController _controller;

        public CalculatorControllerTests()
        {
            _mockCalculatorService = new Mock<ICalculatorService>();
            _controller = new CalculatorController(_mockCalculatorService.Object);
        }

        [Fact]
        public void Add_ReturnsOkResult_WithCorrectValue()
        {
            // Arrange
            double a = 5, b = 3;
            _mockCalculatorService.Setup(s => s.Add(a, b)).Returns(8);

            // Act
            var result = _controller.Add(a, b) as OkObjectResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(8.0, result.Value);
        }

        [Fact]
        public void Subtract_ReturnsOkResult_WithCorrectValue()
        {
            double a = 10, b = 4;
            _mockCalculatorService.Setup(s => s.Subtract(a, b)).Returns(6);

            var result = _controller.Subtract(a, b) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(6.0, result.Value);
        }

        [Fact]
        public void Multiply_ReturnsOkResult_WithCorrectValue()
        {
            double a = 6, b = 7;
            _mockCalculatorService.Setup(s => s.Multiply(a, b)).Returns(42);

            var result = _controller.Multiply(a, b) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(42.0, result.Value);
        }

        [Fact]
        public void Divide_ReturnsOkResult_WithCorrectValue()
        {
            double a = 20, b = 4;
            _mockCalculatorService.Setup(s => s.Divide(a, b)).Returns(5);

            var result = _controller.Divide(a, b) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(5.0, result.Value);
        }

        [Fact]
        public void Divide_ReturnsBadRequest_WhenDividingByZero()
        {
            double a = 10, b = 0;
            _mockCalculatorService.Setup(s => s.Divide(a, b)).Throws(new DivideByZeroException());

            var result = _controller.Divide(a, b) as BadRequestObjectResult;

            Assert.NotNull(result);
            Assert.Equal(400, result.StatusCode);
            Assert.Equal("Cannot divide by zero.", result.Value);
        }
    }
}
