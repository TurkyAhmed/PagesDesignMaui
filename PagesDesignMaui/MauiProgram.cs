using Microsoft.Extensions.Logging;
using PagesDesignMaui.Pages.CoffeePages;
using PagesDesignMaui.Services;
using Syncfusion.Maui.Core.Hosting;

namespace PagesDesignMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("fontello.ttf", "Icons");
                    fonts.AddFont("fa-regular.ttf", "FaR");
                    fonts.AddFont("fa-solid.ttf", "FaB");
                });

#if DEBUG
    		builder.Logging.AddDebug();

            builder.Services.AddSingleton<CoffeeServices>();
#endif

            return builder.Build();
        }
    }
}
