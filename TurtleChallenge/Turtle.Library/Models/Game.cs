using System.Collections.Generic;
using System.Threading;
using Turtle.Library.ReadModels;

namespace Turtle.Library.Models
{
    public class Game
    {
        private Point _turtleStartPoint;
        private FileReader _fileReader;
        private AdvanceSettingModel _advancedSettings;
        private SimpleSettingsModel _simpleSettings;
        private Grid _grid;
        private Observer _observer;

        private Game()
        {
            _fileReader = FileReader.Instance();
            _advancedSettings = _fileReader.GetAdvanceSettings();
            _simpleSettings = _fileReader.GetSimpleSettings();
            _turtleStartPoint = _advancedSettings.StartPoint;
            _grid = new Grid(_advancedSettings.Size.Y, _advancedSettings.Size.X);
            _observer = new Observer(_grid);
            Initialize();
        }

        public static Game CreateNewGame()
        {
            return new Game();
        }

        public void Start()
        {
            var moves = _simpleSettings.MoveExit;
            var turtle = _grid[_turtleStartPoint] as Turtle;
            if (System.Enum.TryParse<Directions>(_advancedSettings.Direction, out var dir)) turtle.Direction = dir;
            Printer.Print(turtle);
            for (int i = 0; i < moves.Count; i++)
            {
                if (moves[i] == "r") turtle.Rotate();
                else if (moves[i] == "m") turtle.Move();
            }
        }

        private void Initialize()
        {
            SetTurtle(_turtleStartPoint);
            SetExit(_advancedSettings.ExitPoint);
            SetMines(_advancedSettings.MinePoints);
        }

        private void SetMines(List<Point> mines)
        {
            foreach (var minePosition in mines)
            {
                try
                {
                    _grid[minePosition] = new Mine() { Position = minePosition };
                }
                catch
                {/*ignore*/ }
            }
        }

        private void SetExit(Point exitPosition)
        {
            try
            {
                _grid[exitPosition] = new Exit() { Position = exitPosition };
            }
            catch
            {/*ignore*/}
        }

        private void SetTurtle(Point turtlePosition)
        {
            try
            {
                _grid[turtlePosition] = Turtle.Instance(turtlePosition);
            }
            catch
            {/*ignore*/}
        }
    }
}
