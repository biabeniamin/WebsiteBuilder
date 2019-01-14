using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Models
{
    public class Response
    {
        private string textResponse;

        public string TextResponse
        {
            get { return textResponse; }
            set { textResponse = value; }
        }

        public Response(string textResponse)
        {
            this.textResponse = textResponse;
        }
    }
}
