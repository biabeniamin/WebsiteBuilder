﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Models
{
    public class Image
    {
        private string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public Image(string path)
        {
            this.path = path;
        }

    }
}
