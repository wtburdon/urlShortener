namespace urlShortener.Core.Processors;

public interface IURLProcessor
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="shortenedUrl"></param>
    /// <returns></returns>
    public Task<string> GetURLAsync(string shortenedUrl);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public Task<PostURLResponse> PostURLAsync(PostURLRequest request);
}