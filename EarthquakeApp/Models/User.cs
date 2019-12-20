using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarthquakeApp.Models
{
    public class User:Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
