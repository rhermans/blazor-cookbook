using Blzr.Shared;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace Blzr.Client.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<WeatherForecast>> GetWeatherForecasts()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("sample-data/weather.json");
        }
    }
}
