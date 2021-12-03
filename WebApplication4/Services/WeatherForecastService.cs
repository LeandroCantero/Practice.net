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

        public HttpClient client = new HttpClient();

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
            this.client.BaseAddress = new Uri("http://ip-api.com/json/");

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
            this.client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");

            using (HttpResponseMessage response = client.GetAsync($"onecall?lat={lat}&lon={lon}& exclude=hourly,daily,minutely&appid={apiKey}").Result)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<OpenWeather>(responseContent);
                return obj;
            }
        }

        public OpenWeather GetWeatherByIp(string ip)
        {
            this.client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
            var lat = this.GetGeolocation(ip).lat;
            var lon = this.GetGeolocation(ip).lon;
            

            using (HttpResponseMessage response = client.GetAsync($"onecall?lat={lat}&lon={lon}& exclude=hourly,daily,minutely&appid={apiKey}").Result)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<OpenWeather>(responseContent);
                return obj;
            };
        }
    }
}
