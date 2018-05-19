using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Library.Models
{
    public class Grid
    {
        private Element[][] _elements;
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Grid(int x, int y)
        {
            Width = y;
            Height = x;

            _elements = new Element[x][];
            for (int i = 0; i < x; i++)
            {
                _elements[i] = new Element[y];
                for (int j = 0; j < y; j++)
                {
                    _elements[i][j] = new Element() { Position = new Point { X = i, Y = j } };
                }
            }
        }

        public Element this[int index1, int index2]
        {
            get { return _elements[index1][index2]; }
            set { _elements[index1][index2] = value; }
        }

        public Element this[Point p]
        {
            get { return _elements[p.X][p.Y]; }
            set { _elements[p.X][p.Y] = value; }
        }
    }
}
