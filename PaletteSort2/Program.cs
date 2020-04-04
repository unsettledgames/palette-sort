using System;
using System.Collections.Generic;
using System.Drawing;

namespace PaletteSort
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagement fm = new FileManagement("Palettes/edg32.png");
            List<PaletteColor> colors = fm.GetColorList();

            fm.ExportPalette("sorted.bmp", colors);
        }
    }
}
