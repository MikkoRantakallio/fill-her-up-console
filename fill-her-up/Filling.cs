using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillHerUp
{
    public class Filling
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("car")]
        public string license { get; set; }

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("amount")]
        public double amount { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("mileage")]
        public int mileage { get; set; }

        public Filling()
        {
        }
    }
}
