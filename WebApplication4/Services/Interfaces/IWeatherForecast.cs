using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;
using WebApplication4.Models.Dtos;

namespace WebApplication4.Services.Interfaces
{
    public interface IWeatherForecast
    {
        WeatherForecastDTO GetDayAndMonth();
        Task<OpenWeather> GetWeather(double lat, double lon, string apiKey);
        Geolocation GetGeolocation();
    }
}
