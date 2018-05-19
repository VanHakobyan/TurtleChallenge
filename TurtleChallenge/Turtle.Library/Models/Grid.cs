using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Library.Models
{
    class Grid
    {
        private List<Element> _points = new List<Element>();

        public Grid(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    _points.Add(new Element() { Position = new Point { X = i, Y = j } });
                }
            }
        }

        public Element this[int index]
        {
            get { return _points[index]; }
            set { _points[index] = value; }
        }
    }
}
