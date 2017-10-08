using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FillHerUp
{
    public class Car
    {
        [JsonProperty("license")]
        public string license { get; set; }

        [JsonProperty("descr")]
        public string description { get; set; }
        
        public Car()
        {
        }
    }
}
