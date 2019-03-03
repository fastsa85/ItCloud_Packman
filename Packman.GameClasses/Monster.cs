using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packman.GameClasses
{
    public class Monster : GameCreature
    {
        private Random rnd;

        public Monster(Position position) : base(position)
        {
            rnd = new Random();
            this.Direction = Direction.RIGHT;
        }
        
        public override void DoLoop()
        {
            
        }
        
        private Direction GenerateRandomDirection(GameBoard gameBoard)
        {
            Direction newDirection;
            do
            {
                newDirection = (Direction) rnd.Next(0, Enum.GetValues(typeof(Direction)).Length);
            } while (!gameBoard.CheckBorder(newDirection, this));

            return newDirection;
        }

        public void huntPackman(Packman packman, GameBoard gameBoard)
        {
            int currentDistanceToPackman = this.Position + packman.Position;
            int newDistanceToPackman;
            Direction direction;
            int counter = 0;
            do
            {
                direction = GenerateRandomDirection(gameBoard);
                newDistanceToPackman = (this.Position + direction) + packman.Position;
                counter++;
            } while (newDistanceToPackman > currentDistanceToPackman && counter < Enum.GetValues(typeof(Direction)).Length);

            Move(direction);
        }
    }
}
