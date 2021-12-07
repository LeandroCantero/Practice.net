using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApplication4.Models;
using WebApplication4.Models.Dtos;
using WebApplication4.Services.Interfaces;

namespace WebApplication4.Services
{
    public class WeatherForecastService : IWeatherForecast
    {
        public WeatherForecastDTO forecast = new WeatherForecastDTO();

        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherForecastService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        const string apiKey = "46314bde5ac1bbe1e85b0b5ec363c959";

        public WeatherForecastDTO GetDayAndMonth()
        {
            DateTime now = DateTime.UtcNow;
            forecast.Day = now.ToString("dddd");
            forecast.Month = now.ToString("MMMM");
            return forecast;
        }

        public Geolocation GetGeolocation(string ip)
        {
            var client = _httpClientFactory.CreateClient("Geolocation");

            using (HttpResponseMessage response = client.GetAsync($"{ip}?fields=status,message,country,countryCode,regionName,city,lat,lon,timezone,query").Result)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                response.EnsureSuccessStatusCode();
                var obj = JsonConvert.DeserializeObject<Geolocation>(responseContent);
                return obj;
            }
        }

        public OpenWeather GetWeather(float lat, float lon)
        {
            var client = _httpClientFactory.CreateClient("OpenWeather");

            using (HttpResponseMessage response = client.GetAsync($"onecall?lat={lat}&lon={lon}& exclude=hourly,daily,minutely&appid={apiKey}").Result)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<OpenWeather>(responseContent);
                return obj;
            }
        }

        public OpenWeather GetWeatherByIp(string ip)
        {
            var client = _httpClientFactory.CreateClient("OpenWeather");
            float lat = this.GetGeolocation(ip).lat;
            float lon = this.GetGeolocation(ip).lon;
            

            using (HttpResponseMessage response = client.GetAsync($"onecall?lat={lat}&lon={lon}& exclude=hourly,daily,minutely&appid={apiKey}").Result)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<OpenWeather>(responseContent);
                return obj;
            };
        }
    }
}
