using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Geolocation
    {
        public string status { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string regionName { get; set; }
        public string city { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string timezone { get; set; }
        public string query { get; set; }

    }
}
