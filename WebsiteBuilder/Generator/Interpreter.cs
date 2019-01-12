using Generator.Models;
using Luis;
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

        public Interpreter(LuisApi luisApi, Website website)
        {
            this.luisApi = luisApi;
            this.website = website;
        }
    }
}
