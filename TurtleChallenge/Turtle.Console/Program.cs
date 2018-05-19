using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Turtle.Console.Models;
using Turtle.Library;

namespace Turtle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader=new FileReader();
            var simpleSettingsModel = fileReader.GetAdvanceSettings();
            var game = Game.CreateNewGame();
            game.Start();

            Thread.Sleep(60000);
        }
    }
}
