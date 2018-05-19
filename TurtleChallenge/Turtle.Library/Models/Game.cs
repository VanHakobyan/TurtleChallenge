using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Turtle.Library.Models
{
    public class Game
    {
        private int _width = 4;
        private int _height = 5;
        private Point _turtleStartPoint = new Point { Y = 0, X = 0 };
        private Grid _grid;
        private Observer _observer;

        private Game()
        {
            _grid = new Grid(5, 4);
            _observer = new Observer(_grid);
            Initialize();
        }

        public static Game CreateNewGame()
        {
            return new Game();
        }

        public void Start()
        {
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
            SetExit(new Point {X = 3, Y = 3 });
            SetMines(new List<Point> { new Point { X = 0, Y = 1 } , new Point { X = 1, Y = 1 } , new Point { X = 3, Y = 2 } });
            
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
