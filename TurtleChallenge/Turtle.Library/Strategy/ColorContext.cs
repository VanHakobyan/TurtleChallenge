using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Library.Strategy
{
    public class ColorContext
    {
        private Color _color;

        public ColorContext(Color color)
        {
            _color = color;
        }

        public void ContextInterface()
        {
            _color.ChangeColor();;
        }
    }
}
