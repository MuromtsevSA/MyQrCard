﻿using MyQrCard.View;
using MyQrCard.ViewModel;

namespace MyQrCard;

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

		builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddTransient<EmailPageViewModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<EmailPage>();

		return builder.Build();
	}
}
