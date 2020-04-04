using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteSort2
{
    class Ramp
    {
        private float m_minHue;
        private float m_maxHue;
        private List<PaletteColor> m_colors;
        
        public Ramp(float minHue, float maxHue)
        {
            m_minHue = minHue;
            m_maxHue = maxHue;

            m_colors = new List<PaletteColor>();
        }

        public List<PaletteColor> colors
        {
            get { return m_colors; }
        }

        public float minHue
        {
            get { return m_minHue; }
            set { m_minHue = value; }
        }

        public float maxHue
        {
            get { return m_maxHue; }
            set { m_maxHue = value; }
        }

        public void AddColors(List<PaletteColor> colors)
        {
            for (int i=0; i<colors.Count; i++)
            {
                HSVColor hsvColor = Converter.RGBToHSV(colors[i].hexColor);

                if (hsvColor.H <= maxHue && hsvColor.H >= minHue)
                {
                    this.colors.Add(colors[i]);
                }
            }
        }
    }
}
