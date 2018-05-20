using System.Threading;
using Turtle.Library.Models;

namespace Turtle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = Game.CreateNewGame();
            game.Start();

            Thread.Sleep(60000);
            System.Console.ReadKey();
        }
    }
}
