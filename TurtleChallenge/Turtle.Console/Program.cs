using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Turtle.Library;
using Turtle.Library.Models;

namespace Turtle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader = FileReader.Instance();
            var simpleSettingsModel = fileReader.GetAdvanceSettings();
            var game = Game.CreateNewGame();
            game.Start();

            Thread.Sleep(60000);
        }
    }
}
