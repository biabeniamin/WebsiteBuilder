using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Models
{
    public class Background
    {
        private Color backgroundColor;
        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public Color BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        public bool HasImageAsBackground
        {
            get
            {
                return !(image.Path == "no_image"
                    || !String.IsNullOrEmpty(image.Path));
            }
        }

        public Background(Color color)
        {
            backgroundColor = color;
            image = new Image("no_image");
        }

        public Background(Image image)
        {
            backgroundColor = Color.White;
            this.image = image;
        }
    }
}
