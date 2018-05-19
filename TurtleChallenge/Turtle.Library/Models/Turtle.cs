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
        private Turtle() { }
        public static Turtle Instance()
        {
            if (_turtle != null)
                _turtle = new Turtle();
            return _turtle;
        }
        #endregion

        public void Move(Directions direction)
        {

        }
    }
}
