using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turtle.Console.Models
{
    class Game
    {
        private Game()
        {
            Initialize();
        }

        private Grid _grid = new Grid(5,4);

        public static Game CreateNewGame()
        {
            return new Game();
        }

        public void Start() {

        }

        private void Initialize()
        {
            SetTurtle();
            SetExit();
            SetMines();
        }

        private void SetMines()
        {

        }

        private void SetExit()
        {

        }

        private void SetTurtle()
        {

        }
    }
}
