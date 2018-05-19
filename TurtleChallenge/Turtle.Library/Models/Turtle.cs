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

        public void Move(Directions direction)
        {
            switch (direction)
            {
                case Directions.North:
                    _turtle.Position = new Point { X = _turtle.Position.X - 1, Y = _turtle.Position.Y };
                    break;
                case Directions.South:
                    _turtle.Position = new Point { X = _turtle.Position.X + 1, Y = _turtle.Position.Y };
                    break;
                case Directions.East:
                    _turtle.Position = new Point { X = _turtle.Position.X, Y = _turtle.Position.Y + 1 };
                    break;
                case Directions.West:
                    _turtle.Position = new Point { X = _turtle.Position.X, Y = _turtle.Position.Y - 1};
                    break;
            }
        }
    }
}
