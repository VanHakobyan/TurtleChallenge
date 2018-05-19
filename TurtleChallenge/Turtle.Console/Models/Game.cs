using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Console.Models
{
    class Game
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
            //SetTurtle();
            //SetExit();
            //SetMines();
        }

        private void SetMines(List<Point> mines)
        {
            foreach (var minePosition in mines)
            {
                _grid[GetGridPosition(minePosition)] = new Mine() { Position = minePosition };
            }
        }

        private void SetExit(Point exitPosition)
        {
            _grid[GetGridPosition(exitPosition)] = new Exit() { Position = exitPosition };
        }

        private void SetTurtle(Point turtlePosition)
        {
            _grid[GetGridPosition(turtlePosition)] = new Turtle() { Position = turtlePosition };
        }

        private int GetGridPosition(Point p)
        {
            return p.Y - 1 + p.X * _width;
        }
    }
}
