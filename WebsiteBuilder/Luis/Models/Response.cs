using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luis.Models
{
    public class Response
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("topScoringIntent")]
        public TopScoringIntent TopScoringIntent { get; set; }

        [JsonProperty("intents")]
        public IList<Intent> Intents { get; set; }

        [JsonProperty("entities")]
        public IList<Entity> Entities { get; set; }
    }
}
