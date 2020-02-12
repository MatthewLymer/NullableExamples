using System;
using Microsoft.Extensions.DependencyInjection;
using NullableExamples.Caching.Abstractions;

namespace NullableExamples.Caching.InMemory.DependencyInjection
{
    public static class InMemoryServiceCollectionExtensions
    {
        public static IServiceCollection AddInMemoryAsyncCache(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddSingleton<IAsyncCache, InMemoryAsyncCache>();

            return services;
        }
    }
}