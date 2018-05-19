using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turtle.Library.Models;

namespace Turtle.Library
{
    public class Observer
    {
        private int _width;
        private int _height;
        private Grid _grid;

        public Observer(Grid grid)
        {
            _width = grid.Width;
            _height = grid.Height;
            _grid = grid;
        }

        public bool IsDanger(Point position)
        {
            var adjacentPoints = GetAdjacentPositions(position);
            return adjacentPoints.Any(x => _grid[position] is Mine);
        }

        public bool IsDead(Point position)
        {
            return _grid[position] is Mine;
        }

        public bool IsOutOfBounds(Point position)
        {
            return position.X < 0 || position.X >= _height || position.Y < 0 || position.Y >= _width;
        }

        public bool IsExit(Point position)
        {
            return _grid[position] is Exit;
        }

        private List<Point> GetAdjacentPositions(Point position)
        {
            var list = new List<Point>();

            if (position.X - 1 >= 0) list.Add(new Point { X = position.X - 1, Y = position.Y });
            if (position.X - 1 >= 0 && position.Y - 1 >= 0) list.Add(new Point { X = position.X - 1, Y = position.Y - 1 });
            if (position.X - 1 >= 0 && position.Y + 1 < _width) list.Add(new Point { X = position.X - 1, Y = position.Y + 1 });
            if (position.X + 1 < _height) list.Add(new Point { X = position.X + 1, Y = position.Y });
            if (position.X + 1 < _height && position.Y - 1 >= 0) list.Add(new Point { X = position.X + 1, Y = position.Y - 1 });
            if (position.X + 1 < _height && position.Y + 1 < _width) list.Add(new Point { X = position.X + 1, Y = position.Y + 1 });
            if (position.Y - 1 >= 0) list.Add(new Point { X = position.X, Y = position.Y - 1 });
            if (position.Y + 1 < _width) list.Add(new Point { X = position.X, Y = position.Y + 1 });

            return list;
        }
    }
}
