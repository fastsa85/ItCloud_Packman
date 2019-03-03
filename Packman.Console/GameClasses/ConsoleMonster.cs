using Packman.ConsoleApp.PixelMaps;
using Packman.ConsoleGraphic;
using Packman.ConsoleGraphic.ConsoleGraphic;
using Packman.GameClasses;
using System;
using System.Collections.Generic;

namespace Packman.ConsoleApp.GameClasses
{
    internal class ConsoleMonster : Monster, IConsoleRenderable
    {
        public readonly static int CONSOLE_MONSTER_WIDTH = 12;
        public readonly static int CONSOLE_MONSTER_HEIGHT = 6;
        public readonly static int CONSOLE_MONSTER_SPEED = 2;

        private readonly ConsoleMonsterPixelMap consoleMonsterPixelMap;

        public ConsoleMonster(Position position) : base(position)
        {
            Width = CONSOLE_MONSTER_WIDTH;
            Height = CONSOLE_MONSTER_HEIGHT;
            Speed = CONSOLE_MONSTER_SPEED;
            
        }

        public ConsoleMonster(Position position, ConsoleColor color) : this(position)
        {
            consoleMonsterPixelMap = new ConsoleMonsterPixelMap(color);
        }

        public List<ConsolePixel> GetConsolePixels()
        {
            var pixelsToReturn = new List<ConsolePixel>();
            foreach (var pixel in consoleMonsterPixelMap.GetPixelMap())
            {
                pixelsToReturn.Add(new ConsolePixel(pixel.X + this.Position.X, pixel.Y + this.Position.Y, pixel.Color));
            }

            return pixelsToReturn;
        }
    }
}
