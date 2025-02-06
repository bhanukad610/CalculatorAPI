namespace CalculatorAPI.Services;

/// <summary>
/// Defines operations for basic arithmetic calculations.
/// </summary>
public interface ICalculatorService
{
    /// <summary>
    /// Adds two numbers and returns the result.
    /// </summary>
    /// <param name="a">First number.</param>
    /// <param name="b">Second number.</param>
    /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
    double Add(double a, double b);

    /// <summary>
    /// Subtracts the second number from the first and returns the result.
    /// </summary>
    /// <param name="a">First number.</param>
    /// <param name="b">Second number.</param>
    /// <returns>The difference between <paramref name="a"/> and <paramref name="b"/>.</returns>
    double Subtract(double a, double b);

    /// <summary>
    /// Multiplies two numbers and returns the result.
    /// </summary>
    /// <param name="a">First number.</param>
    /// <param name="b">Second number.</param>
    /// <returns>The product of <paramref name="a"/> and <paramref name="b"/>.</returns>
    double Multiply(double a, double b);

    /// <summary>
    /// Divides the first number by the second and returns the result.
    /// </summary>
    /// <param name="a">Dividend.</param>
    /// <param name="b">Divisor.</param>
    /// <returns>The quotient of <paramref name="a"/> divided by <paramref name="b"/>.</returns>
    /// <exception cref="DivideByZeroException">Thrown when <paramref name="b"/> is zero.</exception>
    double Divide(double a, double b);
}

/// <summary>
/// Implements <see cref="ICalculatorService"/> to perform basic arithmetic calculations.
/// </summary>
public class CalculatorService : ICalculatorService
{
    /// <inheritdoc/>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <inheritdoc/>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <inheritdoc/>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <inheritdoc/>
    /// <exception cref="DivideByZeroException">Thrown when divisor is zero.</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Error: Cannot divide by zero.");

        return a / b;
    }
}