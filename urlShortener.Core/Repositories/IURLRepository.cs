namespace urlShortener.Core.Repositories;

/// <summary>
/// Interface for the repository that contains URL data.
/// </summary>
public interface IURLRepository
{
    /// <summary>
    /// Fetches repository for the shortend version of a URL
    /// </summary>
    /// <param name="originalUrl"></param>
    /// <returns></returns>
    public Task<string> GetShortenedURLAsync(string originalUrl);

    /// <summary>
    /// Fetches repository for the original url with shortend version as key.
    /// </summary>
    /// <param name="shortenedUrl"></param>
    /// <returns></returns>
    public Task<string> GetOriginalURLAsync(string shortenedUrl);

    public Task UploadURLDocument(string url);
}
