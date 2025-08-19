namespace urlShortener.Contracts.Contracts;

/// <summary>
/// Represents the response after posting a URL to be shortened.
/// </summary>
public record PostURLResponse
{
    /// <summary>
    /// Shortened URL
    /// </summary>
    public string ShortenedUrl { get; init; } = string.Empty;

    /// <summary>
    /// Original URL to be shortened
    /// </summary>
    public string OriginalUrl { get; init; } = string.Empty;
}