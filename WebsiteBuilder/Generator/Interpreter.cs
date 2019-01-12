using Generator.Models;
using Luis;
using Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public class Interpreter
    {
        private LuisApi luisApi;
        private Website website;

        private async Task<string> SendMessage(string message)
        {
            string response;
            Response luisResponse;

            response = "";
            luisResponse = null;

            luisResponse = await luisApi.SendMessage(message);

            response = "ok";

            return response;
            
        }

        public Interpreter(LuisApi luisApi, Website website)
        {
            this.luisApi = luisApi;
            this.website = website;
        }
    }
}
