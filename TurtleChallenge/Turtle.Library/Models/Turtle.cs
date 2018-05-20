namespace Turtle.Library.Models
{
    public class Turtle : Element
    {
        #region Singleton
        /// <summary>
        /// Singleton implementation
        /// 
        /// Tutle can be one 
        /// </summary>
        private static Turtle _turtle;
        private Turtle(Point position) { Position = position; }
        public static Turtle Instance(Point position)
        {
            return _turtle ?? (_turtle = new Turtle(position));
        }
        #endregion

        public Directions Direction { get; set; }


        /// <summary>
        /// Move by Point
        /// </summary>
        public void Move()
        {
            switch (Direction)
            {
                case Directions.North:
                    Printer.Print(_turtle.Position, new Point { X = _turtle.Position.X - 1, Y = _turtle.Position.Y });
                    _turtle.Position = new Point { X = _turtle.Position.X - 1, Y = _turtle.Position.Y };
                    break;
                case Directions.South:
                    Printer.Print(_turtle.Position, new Point { X = _turtle.Position.X + 1, Y = _turtle.Position.Y });
                    _turtle.Position = new Point { X = _turtle.Position.X + 1, Y = _turtle.Position.Y };
                    break;
                case Directions.East:
                    Printer.Print(_turtle.Position, new Point { X = _turtle.Position.X, Y = _turtle.Position.Y + 1 });
                    _turtle.Position = new Point { X = _turtle.Position.X, Y = _turtle.Position.Y + 1 };
                    break;
                case Directions.West:
                    Printer.Print(_turtle.Position, new Point { X = _turtle.Position.X, Y = _turtle.Position.Y - 1 });
                    _turtle.Position = new Point { X = _turtle.Position.X, Y = _turtle.Position.Y - 1 };
                    break;
            }
        }

        /// <summary>
        /// rotate turtle
        /// </summary>
        public void Rotate()
        {
            switch (Direction)
            {
                case Directions.North:
                    Direction = Directions.East;
                    Printer.Print(Direction);
                    break;
                case Directions.South:
                    Direction = Directions.West;
                    Printer.Print(Direction);
                    break;
                case Directions.East:
                    Direction = Directions.South;
                    Printer.Print(Direction);
                    break;
                case Directions.West:
                    Direction = Directions.North;
                    Printer.Print(Direction);
                    break;
                default:
                    break;
            }
        }
    }
}
