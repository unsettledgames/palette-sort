using System.Text;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace PaletteSort
{
    class FileManagement
    {
        private string m_path;
        private Bitmap m_paletteBitmap;

        public string path
        {
            get { return m_path; }
        }

        public Bitmap bitmap
        {
            get { return m_paletteBitmap; }
        }

        public FileManagement(string path)
        {
            m_paletteBitmap = new Bitmap(path);
        }

        public List<PaletteColor> GetColorList()
        {
            List<PaletteColor> ret = new List<PaletteColor>();

            for (int i=0; i<m_paletteBitmap.Width; i++)
            {
                for (int j=0; j<m_paletteBitmap.Height; j++)
                {
                    // Getting the color at i, j position
                    Color currentColor = m_paletteBitmap.GetPixel(i, j);
                    PaletteColor toAdd = new PaletteColor(currentColor);
                    
                    // If it's not in list, I create a palette color and add it
                    if (!ret.Contains(toAdd))
                    {
                        ret.Add(toAdd);
                    }
                }
            }

            return ret;
        }

        public void ExportPalette(string path, List<PaletteColor> colors)
        {
            Bitmap exported = new Bitmap(colors.Count, 1);

            for (int i = 0; i < colors.Count; i++)
            {
                exported.SetPixel(i, 0, colors[i].hexColor);
            }

            exported.Save(path);
        }
    }
}
