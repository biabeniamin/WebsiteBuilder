using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luis.Models
{
    public class TopScoringIntent
    {

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }
}
