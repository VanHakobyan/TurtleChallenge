using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turtle.Console.Models;

namespace Turtle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = Game.CreateNewGame();
            game.Start();
        }
    }
}
