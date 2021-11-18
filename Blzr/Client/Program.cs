using Blzr.Client;
using Blzr.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

void RegisterTypedClient<TClient, TImplementation>(Uri apiBaseUrl)
    where TClient : class where TImplementation : class, TClient =>
    builder.Services.AddHttpClient<TClient, TImplementation>(client =>
    {
        client.BaseAddress = apiBaseUrl;
    });
Uri localUri = new Uri(builder.HostEnvironment.BaseAddress);

RegisterTypedClient<IUserService, UserService>(localUri);
RegisterTypedClient<IWeatherForecastService, WeatherForecastService>(localUri);

builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
await builder.Build().RunAsync();
