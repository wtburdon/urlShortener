namespace urlShortener.Core.Models;

public record URLDocument
{
    public required string originalUrl;

    public required string shortenedUrl;
}