using Generator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Models
{
    public class Color
    {
        private byte r;
        private byte g;
        private byte b;

        public byte B
        {
            get { return b; }
            set { b = value; }
        }


        public byte G
        {
            get { return g; }
            set { g = value; }
        }


        public byte R
        {
            get { return r; }
            set { r = value; }
        }

        public string HexColor
        {
            get
            {
                return string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
            }
        }

        public Color(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static Color Red
        {
            get
            {
                return new Color(255, 0, 0);
            }
        }

        public static Color Green
        {
            get
            {
                return new Color(0, 255, 0);
            }
        }

        public static Color Blue
        {
            get
            {
                return new Color(0, 0, 255);
            }
        }

        public static Color White
        {
            get
            {
                return new Color(255, 255, 255);
            }
        }

        public static Color FromString(string colorName)
        {
            Color color;
            Colors colorEnum;

            color = Color.White;
            colorEnum = Colors.White;

            try
            {
                int r, g, b;
                int colorValue;

                r = 0;
                g = 0;
                b = 0;
                colorValue = 0;

                colorEnum = (Colors)Enum.Parse(typeof(Colors), colorName, true);
                colorValue = (int)colorEnum;

                r = (colorValue >> 0x10) & 0xFF;
                g = (colorValue >> 0x08) & 0xFF;
                b = (colorValue >> 0x00) & 0xFF;

                color = new Color((byte)r, (byte)g, (byte)b);
            }
            catch (Exception ee)
            {
            }


            return color;
        }
    }
}
