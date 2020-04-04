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

                currentMinHue += divisions;
                currentMaxHue += divisions;
            }

            return ret;
        }

        static void Main(string[] args)
        {
            int nRamps = 6;
            Program p = new Program();

            FileManagement fm = new FileManagement("Palettes/vinik.png");
            List<PaletteColor> colors = fm.GetColorList();

            List<Ramp> ramps = p.BuildRamps(nRamps, colors);
            List<PaletteColor> sortedList = new List<PaletteColor>();
        
            for (int i=0; i<ramps.Count; i++)
            {
                sortedList.AddRange(ramps[i].colors);
            }

            fm.ExportPalette("sorted.bmp", sortedList);
        }
    }
}
