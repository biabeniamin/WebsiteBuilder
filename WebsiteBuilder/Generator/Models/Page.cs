using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Models
{
    public class Page
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Page(string name)
        {
            this.name = name;
        }
    }
}
