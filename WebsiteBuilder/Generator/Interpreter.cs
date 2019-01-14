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

        private Response ChangeBackgroundColor(LuisResponse luisResponse)
        {
            Response response;

            response = new Response("The color was changed successfully!");

            if (0 == luisResponse.Entities.Count)
            {
                response.TextResponse = "Sorry, i don't understand the question.";

                return response;
            }

            website.Background.BackgroundColor = Color.FromString(luisResponse.Entities[0].Name);

            return response;
        }

        private Response AddPage(LuisResponse luisResponse)
        {
            Response response;
            string pageName;

            response = new Response("The page was created!");
            pageName = "Test";

            //to implement for name
            /*if (0 == luisResponse.Entities.Count)
            {
                return "Sorry, i don't can't create the page right now.";
            }*/

            website.Pages.Add(new Page(pageName));

            return response;
        }

        public async Task<Response> SendMessage(string message)
        {
            Response response;
            LuisResponse luisResponse;

            luisResponse = null;
            response = new Response("ok");

            luisResponse = await luisApi.SendMessage(message);

            if ("backgroundColor" == luisResponse.TopScoringIntent.Intent)
            {
                response = ChangeBackgroundColor(luisResponse);
            }
            else if ("addPage" == luisResponse.TopScoringIntent.Intent)
            {
                response = AddPage(luisResponse);
            }


            return response;
            
        }

        public Interpreter(LuisApi luisApi, Website website)
        {
            this.luisApi = luisApi;
            this.website = website;
        }
    }
}
