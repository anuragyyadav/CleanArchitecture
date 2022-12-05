using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeatherForecasts1.Application;

namespace WeatherForecasts1.Web.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWeatherForecastService _service;
        public WeatherForecastController(IWeatherForecastService service)
        {
            _service = service;
        }

        public IActionResult GetWeatherForecast()
        {
            var result = _service.ProcessFTemprature();
            return View(result);
        }
    }
}
