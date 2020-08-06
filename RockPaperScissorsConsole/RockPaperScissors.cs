using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissor.Models;

namespace RockPaperScissorsConsole
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            //Initialize Game
            Game game = new Game();
            //Game game = new Game();
            game.init(); //Starts Game
            //Prompt Replay
            game.promptReplay();
            while (game.replay)
            {
                game.init(); //Restarts Game
            }
            game.stopGame(); //Stops Game
            Console.ReadKey();
        }
    }
}
