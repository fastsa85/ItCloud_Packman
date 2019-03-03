using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packman.GameClasses
{
    public abstract class GameCreature
    {
        public GameCreature(Position position)
        {
            this.Position = position;
        }

        public Position Position { get; set; }

        public Direction Direction { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Speed { get; set; }

        public void Move(Direction direction)
        {
            this.Direction = direction;
            switch (direction)
            {
                case Direction.RIGHT:
                {
                    this.Position.X += Speed;
                    return;
                }
                case Direction.DOWN:
                {
                    this.Position.Y += Speed;
                    return;
                }
                case Direction.LEFT:
                {
                    this.Position.X -= Speed;
                    return;
                }
                case Direction.UP:
                {
                    this.Position.Y -= Speed;
                    return;
                }
            }
        }

        public abstract void DoLoop();

    }
}
