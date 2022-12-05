using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherForecasts1.Core; 
using WeatherForecasts1.Application;

namespace WeatherForecasts1.Infrastructure
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing","Chilly","Cool","Mild","Warm","Balmy","Hot","Sweltering","Scorching"
        };
        public WeatherForecast[] GetForecasts()
        {
            var rang = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now,
                TempratureC = rang.Next(-20, 55),
                Summary = Summaries[rang.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}
