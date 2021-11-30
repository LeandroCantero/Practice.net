using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using WebApplication4.Models.Dtos;
using WebApplication4.Services.Interfaces;

namespace WebApplication4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecast _weatherForecast;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecast weatherForecast)
        {
            _logger = logger;
            _weatherForecast = weatherForecast;
        }

        [SwaggerOperation(Summary = "Get current day and month", Description = "Get string for day name and month name")]
        [HttpGet]
        public ActionResult<WeatherForecastDTO> Get()
        {
            return Ok(_weatherForecast.GetDayAndMonth());
        }
    }
}
