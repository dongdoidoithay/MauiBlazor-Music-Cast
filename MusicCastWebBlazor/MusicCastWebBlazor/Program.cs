using MusicCast.Components;
using MusicCast.Pages.Data;
using MusicCast.Shared;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddHttpClient<PodcastService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["PodcastApi:BaseAddress"]!);
    client.DefaultRequestHeaders.Add("api-supported-versions", "1.0,2.0");
});
builder.Services.AddScoped<ThemeInterop>();
builder.Services.AddScoped<IAudioInterop, AudioInterop>();
builder.Services.AddScoped<LocalStorageInterop>();
builder.Services.AddScoped<ClipboardInterop>();
builder.Services.AddScoped<SubscriptionsService>();
builder.Services.AddScoped<ListenLaterService>();
builder.Services.AddSingleton<PlayerService>();
//builder.Services.AddScoped<ListenTogetherHubClient>(_ =>
//    new ListenTogetherHubClient(builder.Configuration["ListenTogetherHub"]!));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToPage("{*path:nonfile}", "/_Host");
app.MapFallbackToPage("/", "/Landing");


//// Add services to the container.
//builder.Services.AddRazorComponents()
//    .AddInteractiveServerComponents()
//    .AddInteractiveWebAssemblyComponents();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseWebAssemblyDebugging();
//}
//else
//{
//    app.UseExceptionHandler("/Error", createScopeForErrors: true);
//}

//app.UseStaticFiles();
//app.UseAntiforgery();

//app.MapRazorComponents<App>()
//    .AddInteractiveServerRenderMode()
//    .AddInteractiveWebAssemblyRenderMode()
//    .AddAdditionalAssemblies(typeof(MusicCastWebBlazor.Client._Imports).Assembly);

app.Run();
