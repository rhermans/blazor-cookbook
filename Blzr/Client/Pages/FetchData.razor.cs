using Blzr.Client.Services;
using Blzr.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace Blzr.Client.Pages
{
    public partial class FetchData
    {

        public List<WeatherForecast> AllWeatherForecasts { get; set; }

        [Inject]
        public IWeatherForecastService WeatherForecastService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            AllWeatherForecasts = (await WeatherForecastService.GetWeatherForecasts()).ToList();
        }

    }
}
