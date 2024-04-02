using Microsoft.Extensions.Logging;

namespace Sliding_Puzzle_Game;
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
                fonts.AddFont("ionicons.ttf", "IonIcons");
            });
        // Register the data layer.
        builder.Services.AddSingleton<Context>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
