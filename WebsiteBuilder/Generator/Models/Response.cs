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
        private bool requireResponse;

        public bool RequireResponse
        {
            get { return requireResponse; }
            set { requireResponse = value; }
        }


        public string TextResponse
        {
            get { return textResponse; }
            set { textResponse = value; }
        }

        public Response(string textResponse, bool requireResponse)
        {
            this.textResponse = textResponse;
            this.requireResponse = requireResponse;
        }

        public Response(string textResponse)
            : this(textResponse, false)
        {
        }
    }
}
