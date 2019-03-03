using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packman.GameClasses
{
    public class GameBoard
    {
        public readonly int Width;
        public readonly int Height;

        public GameBoard(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool CheckBorder(Direction direction, GameCreature creature)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    return creature.Position.X + creature.Speed + creature.Width < Width;

                case Direction.DOWN:
                    return creature.Position.Y + creature.Speed + creature.Height < Height;

                case Direction.LEFT:
                    return creature.Position.X - creature.Speed > 0;

                case Direction.UP:
                    return creature.Position.Y - creature.Speed > 0;
            }

            return false;
        }
        
    }
}
