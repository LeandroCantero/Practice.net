using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Swashbuckle.AspNetCore.Annotations;
using WebApplication4.Models;
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

        [Route("Geolocation")]
        [HttpGet]
        public ActionResult Geolocation(string ip)
        {
            return Ok(_weatherForecast.GetGeolocation(ip));            
        }

        [Route("Weather")]
        [HttpGet]
        public ActionResult Weather(float lat, float lon)
        {
            return Ok(_weatherForecast.GetWeather(lat, lon));
        }

        [Route("WeatherByIp")]
        [HttpGet]
        public ActionResult WeatherByIp(string ip)
        {
            return Ok(_weatherForecast.GetWeatherByIp(ip));
        }

        [Route("GetStudents")]
        [HttpGet]
        public ActionResult GetStudents()
        {
            return Ok(_weatherForecast.GetStudents());
        }

        [Route("GetStudentsById")]
        [HttpGet]
        public ActionResult GetStudentsById(int id)
        {
            return Ok(_weatherForecast.GetStudentsById(id));
        }

        [Route("SaveStudent")]
        [HttpPost]
        public ActionResult SaveStudent(string name, string lastName, int courseId)
        {
            _weatherForecast.SaveStudent(name, lastName, courseId);
            return Ok(_weatherForecast.GetStudents());
        }
    }
}
