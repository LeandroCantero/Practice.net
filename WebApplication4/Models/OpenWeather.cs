namespace WebApplication4.Models
{
    public class OpenWeather
    {
        public float lat { get; set; }
        public float lon { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public Current current  { get; set; }

    }
}
