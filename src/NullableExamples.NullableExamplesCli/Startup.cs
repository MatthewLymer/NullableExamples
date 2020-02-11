using System;
using System.Threading.Tasks;

namespace NullableExamples.NullableExamplesCli
{
    internal sealed class Startup
    {
        public Task GoAsync()
        {
            Console.WriteLine("Hello World");
            
            return Task.CompletedTask;
        }
    }
}