using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NullableExamples.NullableExamplesCli
{
    internal static class Program
    {
        private static async Task Main()
        {
            var builder = new HostBuilder()
                .ConfigureServices(ConfigureServices);

            var host = builder.Build();

            var services = host.Services;

            using var scope = services.CreateScope();

            var startup = ActivatorUtilities.CreateInstance<Startup>(scope.ServiceProvider);

            await startup.GoAsync();
        }

        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            
        }
    }
}