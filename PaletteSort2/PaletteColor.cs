using System.Drawing;
using Color = System.Drawing.Color;

namespace PaletteSort
{
    class PaletteColor
    {
        private Color m_hexColor;

        public PaletteColor(Color hex)
        {
            m_hexColor = hex;
        }

        public Color hexColor
        {
            get { return m_hexColor; }
            set { m_hexColor = value;}
        }
    }
}
