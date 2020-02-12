using System.Threading;
using System.Threading.Tasks;

namespace NullableExamples.Caching.Abstractions
{
    public interface IAsyncCache
    {
        Task<(bool WasFound, string Value)> GetAsync(string key, CancellationToken token);

        Task SetAsync(string key, string value, CancellationToken token);

        Task DeleteAsync(string key, CancellationToken token);
    }
}