using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteBuilder.Models
{
    public class Website
    {
        private string name;
        private Background background;
        private List<Page> pages;

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

        public Website(string name,Background background, List<Page> pages)
        {
            this.name = name;
            this.background = background;
            this.pages = pages;
        }

        public Website(string name, Background background)
            :this(name,background, new List<Page>())
        {

        }

        public Website(string name)
            :this(name, new Background(Color.White))
        {

        } 

    }
}
