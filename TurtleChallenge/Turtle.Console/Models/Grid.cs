using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Console.Models
{
    class Grid
    {
        private List<Point> _points= new List<Point>();

        public Grid(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    _points.Add(new Point { X = i, Y = j });
                }
            }
        }
    }
}
