using Blazored.LocalStorage;
using BlazorWASM.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shop.Shared.Configuration;
using Shop.Shared.Services;
using Shop.Shared.Services.Auth;

namespace BlazorWASM.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");


            var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
            var appSettingsSection = appSettings.Get<AppSettings>();

            var uriBuilder = new UriBuilder(appSettingsSection.BaseApiUrl)
            {
                Path = appSettingsSection.ProductEndpoint.BaseUrl,
            };

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();


            //Microsoft.Extensions.Http 
            builder.Services.AddHttpClient<IProductService, ProductService>(c => c.BaseAddress = uriBuilder.Uri);
            builder.Services.Configure<AppSettings>(appSettings);
            builder.Services.AddHttpClient<IAuthService, AuthService>(c => c.BaseAddress = uriBuilder.Uri);


            await builder.Build().RunAsync();
        }
    }
}
