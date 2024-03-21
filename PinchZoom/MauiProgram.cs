using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
#if ANDROID
using PinchZoom.Platforms.Android;
#endif

namespace PinchZoom
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureMauiHandlers(handlers =>
                {
                    //handlers.AddHandler(typeof(PinchContainer), typeof(ContentViewHandlerEx));
#if ANDROID
                    handlers.AddHandler<PinchContainer,ContentViewHandlerEx>();
#endif
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
