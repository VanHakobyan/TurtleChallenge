using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Library.Models
{
    public enum Directions
    {
        North,
        South,
        East,
        West
    }

    public enum State
    {
        IsDead,
        Normal,
        IsOutOfBounds,
        IsExit,
        IsDanger
    }
}
