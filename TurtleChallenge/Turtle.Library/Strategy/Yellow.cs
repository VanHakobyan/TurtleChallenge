using System;

namespace Turtle.Library.Strategy
{
    /// <inheritdoc />
    public class Yellow : Color
    {
        public override void ChangeColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
