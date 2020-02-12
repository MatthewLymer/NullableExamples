using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NullableExamples.Caching.Abstractions;

namespace NullableExamples.Caching.InMemory
{
    internal sealed class InMemoryAsyncCache : IAsyncCache
    {
        private readonly Dictionary<string, string> _store = new Dictionary<string, string>();
        
        public Task<(bool WasFound, string Value)> GetAsync(string key, CancellationToken token)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            var found = _store.TryGetValue(key, out var value);

            return Task.FromResult((found, value));
        }

        public Task SetAsync(string key, string value, CancellationToken token)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            _store[key] = value;

            return Task.CompletedTask;
        }

        public Task DeleteAsync(string key, CancellationToken token)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            _store.Remove(key);

            return Task.CompletedTask;
        }
    }
}