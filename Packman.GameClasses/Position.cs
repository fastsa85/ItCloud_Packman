using System;
using System.CodeDom;

namespace Packman.GameClasses
{
    public class Position
    {
        private int x;
        private int y;
        

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
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

        public static bool operator ==(Position pos1, Position pos2)
        {
            return pos1.X == pos2.X && pos1.Y == pos2.Y;
        }

        public static bool operator !=(Position pos1, Position pos2)
        {
            return pos1.X != pos2.X && pos1.Y != pos2.Y;
        }

        public static int operator +(Position pos1, Position pos2)
        {
            return (int)Math.Sqrt((pos1.X - pos2.X)*(pos1.X - pos2.X) + (pos1.Y - pos2.Y)* (pos1.Y - pos2.Y));
        }

        public static Position operator +(Position pos, Direction dir)
        {
            switch (dir)
                {
                    case Direction.RIGHT:
                        return new Position(pos.X + 1, pos.Y);
                    case Direction.DOWN:
                        return new Position(pos.X, pos.Y + 1);
                    case Direction.LEFT:
                        return new Position(pos.X - 1, pos.Y);
                    case Direction.UP:
                        return new Position(pos.X, pos.Y - 1);
                }

            return pos;
        }
    }
}