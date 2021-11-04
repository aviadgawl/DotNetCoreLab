using System;
using InversionOfControl.Console;
using Microsoft.Extensions.DependencyInjection;

namespace InversionOfControle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register our types in the container
            ServiceCollection container = new ServiceCollection();
            container.AddScoped<LosslyCoupled>();
            container.AddScoped<IWork,Work>();

            // Build the IoC and get a provider
            ServiceProvider provider = container.BuildServiceProvider();

            // Get our service and call DoSomething()
            var myService = provider.GetService<LosslyCoupled>();
            string msg = myService.DoSomeWork();

            System.Console.WriteLine(msg);
        }
    }
}
