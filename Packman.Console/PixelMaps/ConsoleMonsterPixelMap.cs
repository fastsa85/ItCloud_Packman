using Packman.ConsoleGraphic.ConsoleGraphic;
using System;
using System.Collections.Generic;

namespace Packman.ConsoleApp.PixelMaps
{
    class ConsoleMonsterPixelMap
    {
        private List<ConsolePixel> ConsolePixels;

        public ConsoleMonsterPixelMap(ConsoleColor color)
        {
            ConsolePixels = new List<ConsolePixel>()
            {
                                                                                                                                                new ConsolePixel(4, 0, color), new ConsolePixel(5, 0, color), new ConsolePixel(6, 0, color), new ConsolePixel(7, 0, color),
                                                                                new ConsolePixel(2, 1, color), new ConsolePixel(3, 1, color),   new ConsolePixel(4, 1, color), new ConsolePixel(5, 1, color), new ConsolePixel(6, 1, color), new ConsolePixel(7, 1, color), new ConsolePixel(8, 1, color), new ConsolePixel(9, 1, color),
                new ConsolePixel(0, 2, color), new ConsolePixel(1, 2, color),                                                                   new ConsolePixel(4, 2, color), new ConsolePixel(5, 2, color), new ConsolePixel(6, 2, color), new ConsolePixel(7, 2, color),                                                               new ConsolePixel(10, 2, color), new ConsolePixel(11, 2, color),
                new ConsolePixel(0, 3, color), new ConsolePixel(1, 3, color),   new ConsolePixel(2, 3, color), new ConsolePixel(3, 3, color),   new ConsolePixel(4, 3, color), new ConsolePixel(5, 3, color), new ConsolePixel(6, 3, color), new ConsolePixel(7, 3, color), new ConsolePixel(8, 3, color), new ConsolePixel(9, 3, color), new ConsolePixel(10, 3, color), new ConsolePixel(11, 3, color),
                                                                                new ConsolePixel(2, 4, color), new ConsolePixel(3, 4, color),                                                                                                                               new ConsolePixel(8, 4, color), new ConsolePixel(9, 4, color),
                                                                                new ConsolePixel(2, 5, color), new ConsolePixel(3, 5, color),                                                                                                                               new ConsolePixel(8, 5, color), new ConsolePixel(9, 5, color)
            };
        }

        public List<ConsolePixel> GetPixelMap()
        {
            return ConsolePixels;
        }
    }
}
