using HttpClientExtensions.Models;

namespace HttpClientExtensions.Services;
public interface IPostService
{
    Task Create(Post model, CancellationToken cancellationToken);
    Task<IEnumerable<Post>> GetAll(CancellationToken cancellationToken);
    Task<Post> Get(int id, CancellationToken cancellationToken);

}