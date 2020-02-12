using System;
using System.Threading.Tasks;
using NullableExamples.Caching.Abstractions;

namespace NullableExamples.NullableExamplesCli
{
    internal sealed class Startup
    {
        private readonly IAsyncCache _cache;

        public Startup(IAsyncCache cache)
        {
            _cache = cache;
        }
        
        public Task GoAsync()
        {
            // _cache.SetAsync()
            
            Console.WriteLine("Hello World");
            
            return Task.CompletedTask;
        }
    }
}