using urlShortener.Core.Repositories;

namespace urlShortener.Core.Processors;

/// </inheritdoc>
public class URLProcessor:IURLProcessor
{
    private readonly IURLRepository repository;
    URLProcessor(IURLRepository urlRepository)
    {
        repository = urlRepository;
    }

    public async Task<string> GetOriginalURLAsync(string shortenedUrl)
    {
        URLDocument doc = await repository.GetOriginalURLAsync(shortenedUrl);


    }

    public async Task<PostURLResponse> PostURLAsync(PostURLRequest request)
    {

    }
}