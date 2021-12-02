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

        public Geolocation GetGeolocation()
        {
            this.client.BaseAddress = new Uri("http://ip-api.com/json/");

            using (HttpResponseMessage response = client.GetAsync($"186.129.251.128?fields=status,message,country,countryCode,regionName,city,lat,lon,timezone,query").Result)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                response.EnsureSuccessStatusCode();
                var obj = JsonConvert.DeserializeObject<Geolocation>(responseContent);
                Console.WriteLine(obj.query);
                return obj;
            }
        }

        public async Task<OpenWeather> GetWeather(double lat, double lon, string apiKey)
        {
            client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");

            using (HttpResponseMessage response = await client.GetAsync($"onecall?lat={lat}&lon={lon}&exclude=hourly,daily,minutely&appid={apiKey}"))
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                response.EnsureSuccessStatusCode();
                var obj = JsonConvert.DeserializeObject<OpenWeather>(responseContent);
                return obj;
            }
        }
    }
}
