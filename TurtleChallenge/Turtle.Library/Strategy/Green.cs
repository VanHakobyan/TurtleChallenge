using System;

namespace Turtle.Library.Strategy
{
    public class Green : Color
    {
        public override void ChangeColor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
