namespace urlShortener.Core.Repositories;

/// <summary>
/// Interface for the repository that contains URL data.
/// </summary>
public interface IURLRepository
{
    public Task<string> GetShortenedURLAsync(string originalUrl);


}
