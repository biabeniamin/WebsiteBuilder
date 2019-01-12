using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteBuilder.Enums;

namespace WebsiteBuilder.Models
{
    public class Website
    {
        private string name;
        private Background background;
        private List<Page> pages;
        private WebsiteType type;

        public WebsiteType Type
        {
            get { return type; }
            set { type = value; }
        }


        public List<Page> Pages
        {
            get { return pages; }
            set { pages = value; }
        }


        public Background Background
        {
            get { return background; }
            set { background = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Website(string name,Background background, List<Page> pages, WebsiteType type)
        {
            this.name = name;
            this.background = background;
            this.pages = pages;
            this.type = type;
        }

        public Website(string name, Background background, WebsiteType type)
            :this(name,background, new List<Page>(), type)
        {

        }

        public Website(string name, WebsiteType type)
            :this(name, new Background(Color.White), type)
        {

        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
