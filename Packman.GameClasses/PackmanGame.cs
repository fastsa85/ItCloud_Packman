using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Packman.GameClasses
{
    public class PackmanGame
    {
        private Packman packman;
        private List<Monster> monstersList;
        private GameBoard gameBoard;

        public bool continueGame = true;

        public PackmanGame(Packman packman)
        {
            this.packman = packman;

            monstersList = new List<Monster>();
        }

        public void AddMonster(Monster monster)
        {
            this.monstersList.Add(monster);
        }

        public void SetGameBoard(GameBoard gameBoard)
        {
            this.gameBoard = gameBoard;
        }
        
        public void DoLoop()
        {
            ReadUserKeys();
            packman.DoLoop();
            moveMonsters();
            checkPackmanDamage();
        }

        private void ReadUserKeys()
        {
            if (Console.KeyAvailable)
            {
                var keyinfo = Console.ReadKey(true);
                
                switch (keyinfo.Key)
                    {
                        case
                            ConsoleKey.Escape:
                            continueGame = false;
                            break;
                        case ConsoleKey.RightArrow:
                        {
                            if (gameBoard.CheckBorder(Direction.RIGHT, packman))
                            {
                                packman.Move(Direction.RIGHT);
                            }

                            break;
                        }
                        case ConsoleKey.DownArrow:
                        {
                            if (gameBoard.CheckBorder(Direction.DOWN, packman))
                            {
                                packman.Move(Direction.DOWN);
                            }

                            break;
                        }
                        case ConsoleKey.LeftArrow:
                        {
                            if (gameBoard.CheckBorder(Direction.LEFT, packman))
                            {
                                packman.Move(Direction.LEFT);
                            }

                            break;
                        }
                        case ConsoleKey.UpArrow:
                        {
                            if (gameBoard.CheckBorder(Direction.UP, packman))
                            {
                                packman.Move(Direction.UP);
                            }

                            break;
                        }
                    }
            }
        }

        private void checkPackmanDamage()
        {
            foreach (var monster in monstersList)
            {
                if (packman.Position.X >= monster.Position.X && packman.Position.X <= monster.Position.X + monster.Width
                    && packman.Position.Y >= monster.Position.Y && packman.Position.Y <= monster.Position.Y + monster.Height)
                {
                    packman.Life--;
                    continueGame = packman.Life > 0;
                    break;
                }

                if (Math.Abs((packman.Position.X + packman.Width/2) - (monster.Position.X + monster.Width/2) ) < packman.Width/2 + monster.Width/2 &&
                    Math.Abs((packman.Position.Y + packman.Height / 2) - (monster.Position.Y + monster.Height / 2)) < packman.Height/2 + monster.Height/2)
                { 
                    packman.Life--;
                    continueGame = packman.Life > 0;
                    break;
                }
            }
        }

        public void moveMonsters()
        {
            foreach (var monster in monstersList)
            {
                monster.huntPackman(packman, gameBoard);
            }
        }

        
    }
}
