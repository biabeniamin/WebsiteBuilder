using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Luis.Models;

namespace Luis
{
    public class Luis
    {
        public async Task<Response> SendMessage(string question)
        {
            Response response;
            HttpClient client;
            HttpResponseMessage responseHttp;
            string endpointUri;
            string responseJson;

            response = null;
            client = new HttpClient();
            endpointUri = "";
            responseJson = "";

            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // The request header contains your subscription key
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", LuisCredentials.EndpointKey);

            // The "q" parameter contains the utterance to send to LUIS
            queryString["q"] = question;

            // These optional request parameters are set to their default values
            queryString["timezoneOffset"] = "0";
            queryString["verbose"] = "false";
            queryString["spellCheck"] = "false";
            queryString["staging"] = "false";

            endpointUri = $"https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/{LuisCredentials.AppId}?{queryString}";
            responseHttp = await client.GetAsync(endpointUri);

            responseJson = await responseHttp.Content.ReadAsStringAsync();

            response = JsonConvert.DeserializeObject<Response>(responseJson.ToString());

            return response;
        }
    }
}
