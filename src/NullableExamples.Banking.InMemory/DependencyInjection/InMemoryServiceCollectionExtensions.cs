using System;
using Microsoft.Extensions.DependencyInjection;

namespace NullableExamples.Banking.InMemory.DependencyInjection
{
    public static class InMemoryServiceCollectionExtensions
    {
        public static IServiceCollection AddInMemoryBanks(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }
            
            

            return services;
        }
    }
}