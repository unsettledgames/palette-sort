using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaletteSort2
{
    class HSVColor
    {
        private float m_H;
        private float m_S;
        private float m_V;

        public float H
        {
            get { return m_H; }
            set { m_H = value; }
        }
        public float S
        {
            get { return m_S; }
            set { m_S = value; }
        }

        public float V
        {
            get { return m_V; }
            set { m_V = value; }
        }

        public HSVColor (float H, float S, float V)
        {
            m_H = H;
            m_S = S;
            m_V = V;
        }
    }

    class Converter
    {
        public static HSVColor RGBToHSV(Color rgb)
        {
            // RGB components
            float r = rgb.R;
            float g = rgb.G;
            float b = rgb.B;

            // HSV components
            float h;
            float s;
            float v;

            // Values used for the conversion
            float cMax;
            float cMin;
            float delta;

            // Setting values between 0 and 1 instead of between 0 and 255
            r /= 255;
            g /= 255;
            b /= 255;

            cMax = Math.Max(Math.Max(r, g), b);
            cMin = Math.Min(Math.Min(r, g), b);
            delta = cMax - cMin;

            // Computing hue
            if (delta == 0)
            {
                h = 0;
            }
            else
            {
                if ((cMax > r - 0.01) && (cMax < r + 0.01))
                {
                    h = 60 * ((Math.Abs(g - b) / delta) % 6);
                }
                else if ((cMax > g - 0.01) && (cMax < g + 0.01))
                {
                    h = 60 * ((Math.Abs(b - r) / delta) + 2);
                }
                else
                {
                    h = 60 * ((Math.Abs(r - g) / delta) + 4);
                }
            }

            // Computing saturation
            if (cMax == 0)
            {
                s = 0;
            }
            else
            {
                s = delta / cMax;
            }

            // Computing value
            v = cMax;

            return new HSVColor(h, s, v);
        }
    }
}
