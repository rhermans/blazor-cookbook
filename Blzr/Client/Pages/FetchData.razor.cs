using Blzr.Client.Services;
using Blzr.Shared;
using Microsoft.AspNetCore.Components;

namespace Blzr.Client.Pages
{
    public partial class FetchData
    {
        public List<WeatherForecast>? AllWeatherForecasts { get; set; }

        [Inject] public IWeatherForecastService? WeatherForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AllWeatherForecasts = (await WeatherForecastService.GetWeatherForecasts()).ToList();
        }
    }
}