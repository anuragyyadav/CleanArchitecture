using System;
using System.Collections.Generic;
using System.Text;

using WeatherForecasts1.Core;

namespace WeatherForecasts1.Application
{
    public interface IWeatherForecastRepository
    {
        WeatherForecast[] GetForecasts();
    }
}
