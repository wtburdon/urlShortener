namespace urlShortener.Contracts.Contracts;

/// <summary>
/// Represents a request to shorten a URL.
/// </summary>
public record PostURLRequest
{
    /// <summary>
    /// URL to be shortened
    /// </summary>
    string OriginalUrl { get; init; } = string.Empty;
}