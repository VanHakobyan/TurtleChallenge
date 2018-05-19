using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Library.Models
{
    public class Game
    {
        private int _width = 4;
        private int _height = 5;
        private Grid _grid = new Grid(5, 4);

        private Game()
        {
            Initialize();
        }

        public static Game CreateNewGame()
        {
            return new Game();
        }

        public void Start()
        {

        }

        private void Initialize()
        {
            SetTurtle(new Point { Y = 0, X = 0 });
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
            _grid[turtlePosition] = new Turtle() { Position = turtlePosition };
        }
    }
}
