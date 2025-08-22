namespace urlShortener.Core.Repositories;

/// <inheritdoc/>
public class URLRepository: IURLRepository
{
    private readonly Container container;
    public URLRepository(Container container1)
    {
        container = container1;
    }

    public async Task<URLDocument> GetShortenedURLAsync(string originalUrl)
    {
        throw new NotImplementedException();
    }

    public async Task<URLDocument> GetOriginalURLAsync(string shortenedUrl)
    {
        throw new NotImplementedException();
    }

    public async Task UploadURLDocumentAsync(string originalUrl, string shortenedUrl)
    {
        await container.UpsertItemAsync<URLDocument>(new URLDocument
        {
            originalUrl = originalUrl,
            shortenedUrl = shortenedUrl
        });
    }
}