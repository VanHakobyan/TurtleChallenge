using System;

namespace Turtle.Library.Strategy
{
    public class White : Color
    {
        public override void ChangeColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
