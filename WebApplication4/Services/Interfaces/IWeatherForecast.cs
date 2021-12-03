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
        OpenWeather GetWeather(float lat, float lon);
        Geolocation GetGeolocation(string ip);
        OpenWeather GetWeatherByIp (string ip);
    }
}
