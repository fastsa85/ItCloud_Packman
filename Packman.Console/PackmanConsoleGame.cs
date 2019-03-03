using Packman.ConsoleGraphic.ConsoleGraphic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Packman.ConsoleApp.GameClasses;
using Packman.ConsoleGraphic;
using Packman.GameClasses;
using System.Diagnostics;

namespace Packman.ConsoleApp
{
    class PackmanConsoleApp
    {
        private const int GAME_TIMEOUT = 500; //milliseconds
        private const int GAME_WIDTH = 140;
        private const int GAME_HEIGHT = 60;

        private ConsoleRenderer renderer;


        static void Main(string[] args)
        {
            //Setup Game
            Console.WindowWidth = GAME_WIDTH;
            Console.WindowHeight = GAME_HEIGHT;
            ConsoleRenderer renderer = new ConsoleRenderer();

            ConsolePackman packman = new ConsolePackman(new Position(GAME_WIDTH / 2 - ConsolePackman.CONSOLE_PACKMAN_WIDTH / 2, GAME_HEIGHT / 2 - ConsolePackman.CONSOLE_PACKMAN_HEIGHT / 2 ));
            List<ConsoleMonster> monstersList = new List<ConsoleMonster>();
            monstersList.Add(new ConsoleMonster(new Position(0, 0), ConsoleColor.Red));
            monstersList.Add(new ConsoleMonster(new Position(GAME_WIDTH - ConsoleMonster.CONSOLE_MONSTER_WIDTH, GAME_HEIGHT - ConsoleMonster.CONSOLE_MONSTER_HEIGHT), ConsoleColor.Cyan));
            monstersList.Add(new ConsoleMonster(new Position(0, GAME_HEIGHT - ConsoleMonster.CONSOLE_MONSTER_HEIGHT), ConsoleColor.Blue));
            monstersList.Add(new ConsoleMonster(new Position(GAME_WIDTH - ConsoleMonster.CONSOLE_MONSTER_WIDTH, 0), ConsoleColor.Magenta));

            PackmanGame game = new PackmanGame(packman);

            foreach (var monster in monstersList)
            {
                game.AddMonster(monster);
            }

            game.SetGameBoard(new GameBoard(GAME_WIDTH, GAME_HEIGHT));

            //Game Loop
            while (game.continueGame)
            {
                game.DoLoop();
                renderer.AddToCanvas(packman);
                foreach (var monster in monstersList)
                {
                    renderer.AddToCanvas(monster);
                }
                renderer.RenderAll();
                Thread.Sleep(GAME_TIMEOUT);
                renderer.ClearCanvas();
            }

            //Game Over
            Console.SetCursorPosition(GAME_WIDTH / 2, GAME_HEIGHT / 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }
    }
}
