using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models.Dtos;
using WebApplication4.Services.Interfaces;

namespace WebApplication4.Services
{
    public class WeatherForecastService : IWeatherForecast
    {
        public WeatherForecastDTO forecast = new WeatherForecastDTO();

        public WeatherForecastDTO GetDayAndMonth()
        {
            DateTime now = DateTime.UtcNow;
            forecast.Day = now.ToString("dddd");
            forecast.Month = now.ToString("MMMM");
            return forecast;
        }
    }
}
