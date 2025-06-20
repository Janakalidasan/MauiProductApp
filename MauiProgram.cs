﻿using Microsoft.Extensions.Logging;

namespace MauiProductApp;

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
        builder.Services.AddSingleton<Views.ProductListPage>();
        builder.Services.AddTransient<Views.ProductDetailPage>();

#endif

        return builder.Build();
	}
}
