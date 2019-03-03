using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packman.ConsoleGraphic.ConsoleGraphic
{
    public class ConsolePixel
    {
        private const char PIXEL_SYMBOL = (char)9608;
        //private const char PIXEL_SYMBOL = (char)9626;

        private int x;
        private int y;
        private ConsoleColor color;

        public ConsolePixel(int x, int y, ConsoleColor color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public char Symbol
        {
            get { return PIXEL_SYMBOL; }            
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }



    }
}
