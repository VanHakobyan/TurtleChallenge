using System.Collections.Generic;
using Turtle.Library.ReadModels;

namespace Turtle.Library.Models
{
    public class Game
    {
        private Point _turtleStartPoint;
        private FileReader _fileReader;
        private AdvanceSettingModel advanceSettings;
        private Grid _grid;
        private Observer _observer;

        private Game()
        {
            _fileReader = FileReader.Instance();
            advanceSettings = _fileReader.GetAdvanceSettings();
            _turtleStartPoint = advanceSettings.StartPoint;
            _grid = new Grid(advanceSettings.Size.X, advanceSettings.Size.Y);
            _observer = new Observer(_grid);
            Initialize();
        }

        public static Game CreateNewGame()
        {
            return new Game();
        }

        public void Start()
        {
            Printer.PrintSimple(Printer.FacingSouth);
            while (true)
            {
                var turtle = _grid[_turtleStartPoint] as Turtle;
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                turtle.Move(Directions.East);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                turtle.Move(Directions.South);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                turtle.Move(Directions.South);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                turtle.Move(Directions.East);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                turtle.Move(Directions.North);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                turtle.Move(Directions.West);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
            }
        }

        private void Initialize()
        {
            SetTurtle(_turtleStartPoint);
            SetExit(advanceSettings.ExitPoint);
            SetMines(advanceSettings.MinePoints);
            
        }

        private void SetMines(List<Point> mines)
        {
            foreach (var minePosition in mines)
            {
                _grid[minePosition] = new Mine() { Position = minePosition };
            }
        }

        private void SetExit(Point exitPosition)
        {
            _grid[exitPosition] = new Exit() { Position = exitPosition };
        }

        private void SetTurtle(Point turtlePosition)
        {
            _grid[turtlePosition] = Turtle.Instance(turtlePosition);
        }
    }
}
