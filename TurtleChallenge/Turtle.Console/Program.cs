using Turtle.Library.Models;
using Turtle.Library;

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
        }
    }
}
