using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteBuilder.Models
{
    public class Intent
    {
        [JsonProperty("intent")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }
}
