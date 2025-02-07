using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Shop.Shared.Configuration;
using Shop.Shared.Services;

namespace MauiApp1
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif



            ConfigureServices(builder.Services);

            return builder.Build();


        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            var appSettings = ConfigureAppSettings(serviceCollection);
            ConfigureViewModels(serviceCollection);
            ConfigureViews(serviceCollection);
            ConfigureAppServices(serviceCollection);
            ConfigureHttpClients(serviceCollection, appSettings);
        }

        private static AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            var appSettingsSection = new AppSettings()
            {
                BaseApiUrl = "http://localhost:5010",
                ProductEndpoint = new ProductEndpoint()
                {
                    BaseUrl = "/api/product/",
                    GetProducts = "",
                    CreateProduct = "",
                }
            };
            services.Configure<AppSettings>(options =>
            {
                options.BaseApiUrl = appSettingsSection.BaseApiUrl;
                options.ProductEndpoint = appSettingsSection.ProductEndpoint;
            });
            return appSettingsSection;
        }

        private static void ConfigureHttpClients(IServiceCollection serviceCollection, AppSettings appSettings)
        {
            var uriBuilder = new UriBuilder(appSettings.BaseApiUrl)
            {
                Path = appSettings.ProductEndpoint.BaseUrl,
            };

            serviceCollection.AddHttpClient<IProductService, ProductService>(c => c.BaseAddress = uriBuilder.Uri);
        }

        private static void ConfigureAppServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IProductService, ProductService>();
        }

        private static void ConfigureViews(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<MainPage>();
        }

        private static void ConfigureViewModels(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ProductViewModel>();
        }
    }
}
