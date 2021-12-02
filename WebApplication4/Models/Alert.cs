using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Alert
    {
        public string sender_name { get; set; }
        public string _event { get; set; }
        public int start { get; set; }
        public int end { get; set; }
        public string description { get; set; }
        public object[] tags { get; set; }
    }
}
