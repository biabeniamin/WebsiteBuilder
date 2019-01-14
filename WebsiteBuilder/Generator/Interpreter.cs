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

        private string ChangeBackgroundColor(LuisResponse luisResponse)
        {
            string response;

            response = "The color was changed successfully!";

            if (0 == luisResponse.Entities.Count)
            {
                return "Sorry, i don't understand the question.";
            }

            website.Background.BackgroundColor = Color.FromString(luisResponse.Entities[0].Name);

            return response;
        }

        private string AddPage(LuisResponse luisResponse)
        {
            string response;
            string pageName;

            response = "The page was created!";
            pageName = "Test";

            //to implement for name
            /*if (0 == luisResponse.Entities.Count)
            {
                return "Sorry, i don't can't create the page right now.";
            }*/

            website.Pages.Add(new Page(pageName));

            return response;
        }

        public async Task<string> SendMessage(string message)
        {
            string response;
            LuisResponse luisResponse;

            response = "";
            luisResponse = null;
            response = "ok";

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
