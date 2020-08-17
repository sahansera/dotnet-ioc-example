using System;
using Microsoft.Extensions.DependencyInjection;

namespace IoCTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register our types in the container
            var container = new ServiceCollection();
            container.AddScoped<IMyDependency, MyDependency>();
            container.AddScoped<IMyDependency, MyDependency2>();
            container.AddScoped<IMyService, MyService>();

            // Build the IoC container and get a provider
            var provider = container.BuildServiceProvider();

            // Get our service and call DoSomething()
            var myService = provider.GetService<IMyService>();
            myService.DoSomething();
        }
    }
}
