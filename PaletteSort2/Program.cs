using System;
using System.Collections.Generic;
using System.Drawing;

namespace PaletteSort2
{
    class Program
    {
        public List<Ramp> BuildRamps(int nRamps, List<PaletteColor> colors)
        {
            List<Ramp> ret = new List<Ramp>();

            float divisions = Consts.MAX_HUE / nRamps;
            float currentMaxHue = divisions;
            float currentMinHue = 0;

            while (currentMinHue < Consts.MAX_HUE)
            {
                Ramp toAdd = new Ramp(currentMinHue, currentMaxHue);
                toAdd.AddColors(colors);

                ret.Add(toAdd);
            }

            return ret;
        }

        static void Main(string[] args)
        {
            int nRamps = 6;



            FileManagement fm = new FileManagement("Palettes/edg32.png");
            List<PaletteColor> colors = fm.GetColorList();

            fm.ExportPalette("sorted.bmp", colors);
        }
    }
}
