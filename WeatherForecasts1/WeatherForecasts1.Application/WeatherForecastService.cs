using System;
using System.Collections.Generic;
using System.Text;

using WeatherForecasts1.Core;

namespace WeatherForecasts1.Application
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _repo;
        public WeatherForecastService(IWeatherForecastRepository repo)
        {
            _repo = repo;
        }
        public List<WeatherForecast> ProcessFTemprature()
        {
            var forecasts = _repo.GetForecasts();
            var processed = new List<WeatherForecast>();
            foreach (var f in forecasts)
            {
                f.TempratureF = 32 + (int)(f.TempratureC / 0.5556);
                processed.Add(f);
            }
            return processed;
        }
    }
}
