using Turtle.Library.Models;
using Turtle.Library;

namespace Turtle.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader=new FileReader();
            var simpleSettingsModel = fileReader.GetAdvanceSettings();
            var game = Game.CreateNewGame();
            game.Start();
        }
    }
}
