using HttpClientExtensions.Extensions;
using HttpClientExtensions.Models;

namespace HttpClientExtensions.Services;
public class PostService : IPostService
{
    private readonly HttpClient _client;

    public PostService(HttpClient client)
    {
        _client = client;
    }

    public async Task Create(Post model, CancellationToken cancellationToken)
    {
        var response = await _client.PostAsJson($"/posts/create", model);
        if (response.IsSuccessStatusCode)
        {
            //
        }
        else
        {
            throw new Exception("Something went wrong when calling api.");
        }
    }

    public async Task<IEnumerable<Post>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _client.GetAsync("/posts", cancellationToken);
        return await response.ReadContentAs<List<Post>>();
    }

    public async Task<Post> Get(int id, CancellationToken cancellationToken)
    {
        var response = await _client.GetAsync($"/posts/{id}", cancellationToken);
        return await response.ReadContentAs<Post>();
    }
}
