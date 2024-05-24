using App.ViewModels;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MauiListviewTest;

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
			});

		RegisterPresentationLayer(builder);

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	    private static void RegisterPresentationLayer(MauiAppBuilder builder) {
        	builder.Services.AddSingleton<MainPage>();
			builder.Services.AddSingleton<MyListView>();

			builder.Services.AddTransient<MainPageViewModel>();
			builder.Services.AddTransient<MyListviewViewModel>();

		}
}
