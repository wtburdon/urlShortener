namespace urlShortener.Contracts.Contracts;

/// <summary>
/// Represents a request to shorten a URL.
/// </summary>
public record PostURLRequest
{
    string OriginalUrl { get; init; } = string.Empty;
}