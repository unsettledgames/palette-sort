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
        
        public Ramp(float minHue, float maxHue)
        {
            m_minHue = minHue;
            m_maxHue = maxHue;
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

        }
    }
}
