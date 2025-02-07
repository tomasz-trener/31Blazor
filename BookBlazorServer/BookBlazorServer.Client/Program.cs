using BookBlazorServer.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BookBlazorServer.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);


            builder.Services.AddScoped(http => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
            });

            builder.Services.AddScoped<IBookService, ClientBookService>();

            await builder.Build().RunAsync();
        }
    }
}
