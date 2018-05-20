using System.IO;
using Turtle.Library.Models;
using Turtle.Library.ReadModels;

namespace Turtle.Library
{
    public class FileReader
    {
        #region Singleton
        /// <summary>
        /// Singleton implementation
        /// 
        /// File reader must be one 
        /// </summary>
        private static FileReader _fileReader;
        private FileReader() { }
        public static FileReader Instance()
        {
            return _fileReader ?? (_fileReader = new FileReader());
        }
        #endregion

        private string[] GetMoves()
        {
            var moveNoEnd = File.ReadAllText("..\\..\\Settings\\moves.csv");
            return moveNoEnd.Split(',');
        }

        /// <summary>
        /// get move sequence from csv file
        /// </summary>
        /// <returns></returns>
        public SimpleSettingsModel GetSimpleSettings() => new SimpleSettingsModel { Moves = GetMoves() };

        /// <summary>
        /// Advance setting reader 
        /// </summary>
        /// <returns></returns>
        public AdvancedSettingsModel GetAdvanceSettings()
        {
            var settingString = File.ReadAllLines("..\\..\\Settings\\settings.csv");
            var settings = new AdvancedSettingsModel();

            var sizeStrings = settingString[0].Split(',');
            int.TryParse(sizeStrings[1], out var sizeX);
            int.TryParse(sizeStrings[2], out var sizeY);
            settings.Size = new Point(sizeX, sizeY);

            var startPositionStrings = settingString[1].Split(',');
            int.TryParse(startPositionStrings[2], out var posX);
            int.TryParse(startPositionStrings[4], out var posY);
            settings.StartPoint = new Point(posX, posY);
            settings.Direction = startPositionStrings[6];

            var exitPointStrings = settingString[2].Split(',');
            int.TryParse(exitPointStrings[2], out var exitX);
            int.TryParse(exitPointStrings[4], out var exitY);
            settings.ExitPoint = new Point(exitX, exitY);

            for (int i = 3; i < 6; i++)
            {
                var minePointStrings = settingString[i].Split(',');
                int.TryParse(minePointStrings[2], out var mineX);
                int.TryParse(minePointStrings[4], out var mineY);
                settings.MinePoints.Add(new Point(mineX, mineY));
            }
            return settings;
        }
    }
}
