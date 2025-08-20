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
    public Task<URLDocument> GetShortenedURLAsync(string originalUrl);

    /// <summary>
    /// Fetches repository for the original url with shortend version as key.
    /// </summary>
    /// <param name="shortenedUrl"></param>
    /// <returns></returns>
    public Task<URLDocument> GetOriginalURLAsync(string shortenedUrl);

    /// <summary>
    /// Uploads a document from the specified URL to the system.
    /// </summary>
    /// <param name="originalUrl">Original URL</param>
    /// <param name="shortenedUrl">Shortened URL</param>
    /// <returns>Nothing.</returns>
    public Task UploadURLDocument(string originalUrl, string shortenedUrl);
}
