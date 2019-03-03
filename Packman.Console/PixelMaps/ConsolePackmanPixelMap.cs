using Packman.ConsoleGraphic.ConsoleGraphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Packman.GameClasses;

namespace Packman.ConsoleApp.PixelMaps
{
    internal class ConsolePackmanPixelMap
    {
        private const ConsoleColor PACKMAN_COLOR = ConsoleColor.DarkYellow;

        public List<ConsolePixel> GetPixelMap(Direction direction, bool isMouthClosed)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                {
                    if (isMouthClosed) return ConsolePixelsRightDirectionClosed;
                    else return ConsolePixelsRightDirectionOpen;
                };
                case Direction.DOWN:
                {
                    if (isMouthClosed) return ConsolePixelsDownDirectionClosed;
                    else return ConsolePixelsDownDirectionOpen;
                };
                case Direction.LEFT:
                {
                    if (isMouthClosed) return ConsolePixelsLeftDirectionClosed;
                    else return ConsolePixelsLeftDirectionOpen;
                };
                case Direction.UP:
                {
                    if (isMouthClosed) return ConsolePixelsUpDirectionClosed;
                    else return ConsolePixelsUpDirectionOpen;
                };
            }

            return ConsolePixelsRightDirectionOpen;
        }

        private List<ConsolePixel> ConsolePixelsRightDirectionOpen = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR), new ConsolePixel(5, 0, PACKMAN_COLOR), new ConsolePixel(6, 0, PACKMAN_COLOR), new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),   new ConsolePixel(4, 1, PACKMAN_COLOR), new ConsolePixel(5, 1, PACKMAN_COLOR),                                                                               new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),   new ConsolePixel(2, 2, PACKMAN_COLOR), new ConsolePixel(3, 2, PACKMAN_COLOR),   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(5, 2, PACKMAN_COLOR), new ConsolePixel(6, 2, PACKMAN_COLOR), new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
            new ConsolePixel(0, 3, PACKMAN_COLOR), new ConsolePixel(1, 3, PACKMAN_COLOR),   new ConsolePixel(2, 3, PACKMAN_COLOR), new ConsolePixel(3, 3, PACKMAN_COLOR),   new ConsolePixel(4, 3, PACKMAN_COLOR), new ConsolePixel(5, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(4, 3, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR), new ConsolePixel(5, 4, PACKMAN_COLOR), new ConsolePixel(6, 4, PACKMAN_COLOR), new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR), new ConsolePixel(5, 5, PACKMAN_COLOR), new ConsolePixel(6, 5, PACKMAN_COLOR), new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

        private List<ConsolePixel> ConsolePixelsRightDirectionClosed = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR), new ConsolePixel(5, 0, PACKMAN_COLOR), new ConsolePixel(6, 0, PACKMAN_COLOR), new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),   new ConsolePixel(4, 1, PACKMAN_COLOR), new ConsolePixel(5, 1, PACKMAN_COLOR),                                                                               new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),   new ConsolePixel(2, 2, PACKMAN_COLOR), new ConsolePixel(3, 2, PACKMAN_COLOR),   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(5, 2, PACKMAN_COLOR), new ConsolePixel(6, 2, PACKMAN_COLOR), new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
            new ConsolePixel(0, 3, PACKMAN_COLOR), new ConsolePixel(1, 3, PACKMAN_COLOR),   new ConsolePixel(2, 3, PACKMAN_COLOR), new ConsolePixel(3, 3, PACKMAN_COLOR),   new ConsolePixel(4, 3, PACKMAN_COLOR), new ConsolePixel(5, 3, PACKMAN_COLOR), new ConsolePixel(6, 3, PACKMAN_COLOR), new ConsolePixel(7, 3, PACKMAN_COLOR), new ConsolePixel(8, 3, PACKMAN_COLOR), new ConsolePixel(9, 3, PACKMAN_COLOR), new ConsolePixel(10, 3, PACKMAN_COLOR), new ConsolePixel(11, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR), new ConsolePixel(5, 4, PACKMAN_COLOR), new ConsolePixel(6, 4, PACKMAN_COLOR), new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR), new ConsolePixel(5, 5, PACKMAN_COLOR), new ConsolePixel(6, 5, PACKMAN_COLOR), new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

        private List<ConsolePixel> ConsolePixelsDownDirectionOpen = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR), new ConsolePixel(5, 0, PACKMAN_COLOR), new ConsolePixel(6, 0, PACKMAN_COLOR), new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),   new ConsolePixel(4, 1, PACKMAN_COLOR), new ConsolePixel(5, 1, PACKMAN_COLOR), new ConsolePixel(6, 1, PACKMAN_COLOR), new ConsolePixel(7, 1, PACKMAN_COLOR), new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),                                                                                   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(5, 2, PACKMAN_COLOR), new ConsolePixel(6, 2, PACKMAN_COLOR), new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
            new ConsolePixel(0, 3, PACKMAN_COLOR), new ConsolePixel(1, 3, PACKMAN_COLOR),   new ConsolePixel(2, 3, PACKMAN_COLOR), new ConsolePixel(3, 3, PACKMAN_COLOR),   new ConsolePixel(4, 3, PACKMAN_COLOR),                                                                               new ConsolePixel(7, 3, PACKMAN_COLOR), new ConsolePixel(8, 3, PACKMAN_COLOR), new ConsolePixel(9, 3, PACKMAN_COLOR), new ConsolePixel(10, 3, PACKMAN_COLOR), new ConsolePixel(11, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR),                                                                               new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR),                                                                               new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

        private List<ConsolePixel> ConsolePixelsDownDirectionClosed = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR), new ConsolePixel(5, 0, PACKMAN_COLOR), new ConsolePixel(6, 0, PACKMAN_COLOR), new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),   new ConsolePixel(4, 1, PACKMAN_COLOR), new ConsolePixel(5, 1, PACKMAN_COLOR), new ConsolePixel(6, 1, PACKMAN_COLOR), new ConsolePixel(7, 1, PACKMAN_COLOR), new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),                                                                                   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(5, 2, PACKMAN_COLOR), new ConsolePixel(6, 2, PACKMAN_COLOR), new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
            new ConsolePixel(0, 3, PACKMAN_COLOR), new ConsolePixel(1, 3, PACKMAN_COLOR),   new ConsolePixel(2, 3, PACKMAN_COLOR), new ConsolePixel(3, 3, PACKMAN_COLOR),   new ConsolePixel(4, 3, PACKMAN_COLOR), new ConsolePixel(5, 3, PACKMAN_COLOR), new ConsolePixel(6, 3, PACKMAN_COLOR), new ConsolePixel(7, 3, PACKMAN_COLOR), new ConsolePixel(8, 3, PACKMAN_COLOR), new ConsolePixel(9, 3, PACKMAN_COLOR), new ConsolePixel(10, 3, PACKMAN_COLOR), new ConsolePixel(11, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR), new ConsolePixel(5, 4, PACKMAN_COLOR), new ConsolePixel(6, 4, PACKMAN_COLOR), new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR), new ConsolePixel(5, 5, PACKMAN_COLOR), new ConsolePixel(6, 5, PACKMAN_COLOR), new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

        private List<ConsolePixel> ConsolePixelsLeftDirectionOpen = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR), new ConsolePixel(5, 0, PACKMAN_COLOR), new ConsolePixel(6, 0, PACKMAN_COLOR), new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),                                                                                 new ConsolePixel(6, 1, PACKMAN_COLOR), new ConsolePixel(7, 1, PACKMAN_COLOR), new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),   new ConsolePixel(2, 2, PACKMAN_COLOR), new ConsolePixel(3, 2, PACKMAN_COLOR),   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(5, 2, PACKMAN_COLOR), new ConsolePixel(6, 2, PACKMAN_COLOR), new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
                                                                                                                                                                                                                                                          new ConsolePixel(6, 3, PACKMAN_COLOR), new ConsolePixel(7, 3, PACKMAN_COLOR), new ConsolePixel(8, 3, PACKMAN_COLOR), new ConsolePixel(9, 3, PACKMAN_COLOR), new ConsolePixel(10, 3, PACKMAN_COLOR), new ConsolePixel(11, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR), new ConsolePixel(5, 4, PACKMAN_COLOR), new ConsolePixel(6, 4, PACKMAN_COLOR), new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR), new ConsolePixel(5, 5, PACKMAN_COLOR), new ConsolePixel(6, 5, PACKMAN_COLOR), new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

        private List<ConsolePixel> ConsolePixelsLeftDirectionClosed = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR), new ConsolePixel(5, 0, PACKMAN_COLOR), new ConsolePixel(6, 0, PACKMAN_COLOR), new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),                                                                                 new ConsolePixel(6, 1, PACKMAN_COLOR), new ConsolePixel(7, 1, PACKMAN_COLOR), new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),   new ConsolePixel(2, 2, PACKMAN_COLOR), new ConsolePixel(3, 2, PACKMAN_COLOR),   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(5, 2, PACKMAN_COLOR), new ConsolePixel(6, 2, PACKMAN_COLOR), new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
            new ConsolePixel(0, 3, PACKMAN_COLOR), new ConsolePixel(1, 3, PACKMAN_COLOR),   new ConsolePixel(2, 3, PACKMAN_COLOR), new ConsolePixel(3, 3, PACKMAN_COLOR),   new ConsolePixel(4, 3, PACKMAN_COLOR), new ConsolePixel(5, 3, PACKMAN_COLOR), new ConsolePixel(6, 3, PACKMAN_COLOR), new ConsolePixel(7, 3, PACKMAN_COLOR), new ConsolePixel(8, 3, PACKMAN_COLOR), new ConsolePixel(9, 3, PACKMAN_COLOR), new ConsolePixel(10, 3, PACKMAN_COLOR), new ConsolePixel(11, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR), new ConsolePixel(5, 4, PACKMAN_COLOR), new ConsolePixel(6, 4, PACKMAN_COLOR), new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR), new ConsolePixel(5, 5, PACKMAN_COLOR), new ConsolePixel(6, 5, PACKMAN_COLOR), new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

        private List<ConsolePixel> ConsolePixelsUpDirectionOpen = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR), new ConsolePixel(5, 0, PACKMAN_COLOR), new ConsolePixel(6, 0, PACKMAN_COLOR), new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),   new ConsolePixel(4, 1, PACKMAN_COLOR), new ConsolePixel(5, 1, PACKMAN_COLOR), new ConsolePixel(6, 1, PACKMAN_COLOR), new ConsolePixel(7, 1, PACKMAN_COLOR), new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),   new ConsolePixel(2, 2, PACKMAN_COLOR), new ConsolePixel(3, 2, PACKMAN_COLOR),   new ConsolePixel(4, 2, PACKMAN_COLOR), new ConsolePixel(5, 2, PACKMAN_COLOR), new ConsolePixel(6, 2, PACKMAN_COLOR), new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
            new ConsolePixel(0, 3, PACKMAN_COLOR), new ConsolePixel(1, 3, PACKMAN_COLOR),                                                                                   new ConsolePixel(4, 3, PACKMAN_COLOR), new ConsolePixel(5, 3, PACKMAN_COLOR), new ConsolePixel(6, 3, PACKMAN_COLOR), new ConsolePixel(7, 3, PACKMAN_COLOR), new ConsolePixel(8, 3, PACKMAN_COLOR), new ConsolePixel(9, 3, PACKMAN_COLOR), new ConsolePixel(10, 3, PACKMAN_COLOR), new ConsolePixel(11, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR), new ConsolePixel(5, 4, PACKMAN_COLOR), new ConsolePixel(6, 4, PACKMAN_COLOR), new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR), new ConsolePixel(5, 5, PACKMAN_COLOR), new ConsolePixel(6, 5, PACKMAN_COLOR), new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

        private List<ConsolePixel> ConsolePixelsUpDirectionClosed = new List<ConsolePixel>()
        {
                                                                                                                                                                            new ConsolePixel(4, 0, PACKMAN_COLOR),                                                                               new ConsolePixel(7, 0, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 1, PACKMAN_COLOR), new ConsolePixel(3, 1, PACKMAN_COLOR),   new ConsolePixel(4, 1, PACKMAN_COLOR),                                                                               new ConsolePixel(7, 1, PACKMAN_COLOR), new ConsolePixel(8, 1, PACKMAN_COLOR), new ConsolePixel(9, 1, PACKMAN_COLOR),
            new ConsolePixel(0, 2, PACKMAN_COLOR), new ConsolePixel(1, 2, PACKMAN_COLOR),   new ConsolePixel(2, 2, PACKMAN_COLOR), new ConsolePixel(3, 2, PACKMAN_COLOR),   new ConsolePixel(4, 2, PACKMAN_COLOR),                                                                               new ConsolePixel(7, 2, PACKMAN_COLOR), new ConsolePixel(8, 2, PACKMAN_COLOR), new ConsolePixel(9, 2, PACKMAN_COLOR), new ConsolePixel(10, 2, PACKMAN_COLOR), new ConsolePixel(11, 2, PACKMAN_COLOR),
            new ConsolePixel(0, 3, PACKMAN_COLOR), new ConsolePixel(1, 3, PACKMAN_COLOR),                                                                                   new ConsolePixel(4, 3, PACKMAN_COLOR), new ConsolePixel(5, 3, PACKMAN_COLOR), new ConsolePixel(6, 3, PACKMAN_COLOR), new ConsolePixel(7, 3, PACKMAN_COLOR), new ConsolePixel(8, 3, PACKMAN_COLOR), new ConsolePixel(9, 3, PACKMAN_COLOR), new ConsolePixel(10, 3, PACKMAN_COLOR), new ConsolePixel(11, 3, PACKMAN_COLOR),
                                                                                            new ConsolePixel(2, 4, PACKMAN_COLOR), new ConsolePixel(3, 4, PACKMAN_COLOR),   new ConsolePixel(4, 4, PACKMAN_COLOR), new ConsolePixel(5, 4, PACKMAN_COLOR), new ConsolePixel(6, 4, PACKMAN_COLOR), new ConsolePixel(7, 4, PACKMAN_COLOR), new ConsolePixel(8, 4, PACKMAN_COLOR), new ConsolePixel(9, 4, PACKMAN_COLOR),
                                                                                                                                                                            new ConsolePixel(4, 5, PACKMAN_COLOR), new ConsolePixel(5, 5, PACKMAN_COLOR), new ConsolePixel(6, 5, PACKMAN_COLOR), new ConsolePixel(7, 5, PACKMAN_COLOR)
        };

    }
}
