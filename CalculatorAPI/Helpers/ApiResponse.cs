using System.Text.Json.Serialization;

namespace CalculatorAPI.Helpers;

/// <summary>
/// Standardized API response wrapper for consistent JSON output.
/// Omits null values to keep responses clean.
/// </summary>
/// <typeparam name="T">The type of the result object.</typeparam>
public class ApiResponse<T>
{
    /// <summary>
    /// Success result. Present only when the operation succeeds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public T? Result { get; set; }
    
    /// <summary>
    /// Error message. Present only when an error occurs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string? Error { get; set; }

    private ApiResponse(T result)
    {
        Result = result;
    }

    private ApiResponse(string error)
    {
        Error = error;
    }

    /// <summary>
    /// Creates a successful response with the result.
    /// </summary>
    /// <param name="result">The successful result.</param>
    public static ApiResponse<T> Success(T result) => new(result);

    /// <summary>
    /// Creates an error response with a given message.
    /// </summary>
    /// <param name="error">The error message.</param>
    public static ApiResponse<T> Fail(string error) => new(error);
}