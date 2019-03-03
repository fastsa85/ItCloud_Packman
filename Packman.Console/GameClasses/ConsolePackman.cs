using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Packman.ConsoleApp.PixelMaps;
using Packman.ConsoleGraphic;
using Packman.ConsoleGraphic.ConsoleGraphic;
using Packman.GameClasses;

namespace Packman.ConsoleApp.GameClasses
{
    public class ConsolePackman : Packman.GameClasses.Packman, IConsoleRenderable
    {
        public readonly static int CONSOLE_PACKMAN_WIDTH = 12;
        public readonly static int CONSOLE_PACKMAN_HEIGHT = 6;
        public readonly static int CONSOLE_PACKMAN_SPEED = 3;

        private readonly ConsolePackmanPixelMap consolePackmanPixelMap;

        public ConsolePackman(Position position) : base(position)
        {
            Width = CONSOLE_PACKMAN_WIDTH;
            Height = CONSOLE_PACKMAN_HEIGHT;
            Speed = CONSOLE_PACKMAN_SPEED;
            consolePackmanPixelMap = new ConsolePackmanPixelMap();
        }
        
        public List<ConsolePixel> GetConsolePixels()
        {
            var pixelsToReturn = new List<ConsolePixel>();
            foreach (var pixel in consolePackmanPixelMap.GetPixelMap(this.Direction, IsMouthClosed))
            {
                pixelsToReturn.Add(new ConsolePixel(pixel.X + this.Position.X, pixel.Y + this.Position.Y, pixel.Color));
            }

            return pixelsToReturn;
        }
    }
}
