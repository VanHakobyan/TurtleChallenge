using System.Collections.Generic;
using System.Threading;
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
            _grid = new Grid(advanceSettings.Size.Y, advanceSettings.Size.X);
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
                else Printer.PrintSimple("Turtle moved, it's alive!");
                Thread.Sleep(1500);
                turtle.Move(Directions.East);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                else Printer.PrintSimple("Turtle moved, it's alive!");
                Thread.Sleep(1500);
                turtle.Move(Directions.South);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                else Printer.PrintSimple("Turtle moved, it's alive!");
                Thread.Sleep(1500);
                turtle.Move(Directions.South);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                else Printer.PrintSimple("Turtle moved, it's alive!");
                Thread.Sleep(1500);
                turtle.Move(Directions.East);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                else Printer.PrintSimple("Turtle moved, it's alive!");
                Thread.Sleep(1500);
                turtle.Move(Directions.North);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                else Printer.PrintSimple("Turtle moved, it's alive!");
                Thread.Sleep(1500);
                turtle.Move(Directions.West);
                if (_observer.IsDanger(turtle.Position)) Printer.PrintSimple("Danger!!!");
                else Printer.PrintSimple("Turtle moved, it's alive!");
                Thread.Sleep(1500);
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
            try {
                _grid[turtlePosition] = Turtle.Instance(turtlePosition);
            }
            catch
            {/*ignore*/}
        }
    }
}
