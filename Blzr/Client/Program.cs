using Blzr.Client;
using Blzr.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Fluxor;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddFluxor(config =>
{
    config
        .ScanAssemblies(typeof(Program).Assembly)
        .UseReduxDevTools();
});

builder.Services.AddMudServices();
await builder.Build().RunAsync();