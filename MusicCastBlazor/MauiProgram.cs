using Microsoft.AspNetCore.Components.Infrastructure;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using MusicCastBlazor.Services;
using MudBlazor.Services;
using MusicCast.UI.Services;
using MusicCast.UI;
using MusicCast.Shared.Service;


namespace MusicCastBlazor
{
    public static class MauiProgram
    {
        public static string BaseWeb = $"https://dotnetpodcasts.azurewebsites.net/";
        public static string APIUrl = $"https://podcastapica.ashyhill-df3dfdf5.eastus.azurecontainerapps.io";
        public static string ListenTogetherUrl = $"https://dotnetpodcasts-listentogether-hub.azurewebsites.net/listentogether";

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
        
#if WINDOWS
                    builder.Services.AddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.Windows.NativeAudioService>();
#elif ANDROID
            builder.Services.AddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.Android.NativeAudioService>();
#elif MACCATALYST
                    builder.Services.AddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.MacCatalyst.NativeAudioService>();
#elif IOS
                    builder.Services.AddSingleton<SharedMauiLib.INativeAudioService, SharedMauiLib.Platforms.iOS.NativeAudioService>();
#endif
            builder.Services.AddHttpClient();
            builder.Services.AddScoped<AppService>();

            builder.Services.AddScoped<ThemeInterop>();
            builder.Services.AddScoped<IAudioInterop, AudioInteropService>();
            //builder.Services.AddScoped<LocalStorageInterop>();
            //builder.Services.AddScoped<ClipboardInterop>();
            //builder.Services.AddScoped<SubscriptionsService>();
            //builder.Services.AddScoped<ListenLaterService>();
            builder.Services.AddSingleton<PlayerService>();
            //builder.Services.AddScoped<ListenTogetherHubClient>(_ =>
            //    new ListenTogetherHubClient(ListenTogetherUrl));
            builder.Services.AddScoped<ComponentStatePersistenceManager>();
            builder.Services.AddScoped<PersistentComponentState>(sp => sp.GetRequiredService<ComponentStatePersistenceManager>().State);




            #if DEBUG
                builder.Services.AddBlazorWebViewDeveloperTools();
    		    builder.Logging.AddDebug();
            #endif
            builder.Services.AddMudServices();

            return builder.Build();
        }
    }
}
