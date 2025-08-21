namespace urlShortener.Core.Repositories;

/// <inheritdoc/>
public class URLRepository: IURLRepository
{
    public Task<URLDocument> GetShortenedURLAsync(string originalUrl)
    {
        throw new NotImplementedException();
    }

    public Task<URLDocument> GetOriginalURLAsync(string shortenedUrl)
    {
        throw new NotImplementedException();
    }

    public Task UploadURLDocument(string originalUrl, string shortenedUrl)
    {
        throw new NotImplementedException();
    }
}