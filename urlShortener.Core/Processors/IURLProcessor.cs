namespace urlShortener.Core.Processors;

public interface IURLProcessor
{
    /// <summary>
    /// Retrieves the original URL from the shortened URL.
    /// </summary>
    /// <param name="shortenedUrl">Shortened URL</param>
    /// <returns>String of the original URL</returns>
    public Task<string> GetOriginalURLAsync(string shortenedUrl);

    /// <summary>
    /// Uploads a a URL to the service
    /// </summary>
    /// <param name="request">Request containing original URL</param>
    /// <returns>Response contract with shortened URL</returns>
    public Task<PostURLResponse> PostURLAsync(PostURLRequest request);
}