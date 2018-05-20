using System;
using Turtle.Library.Models;
using Turtle.Library.Strategy;

namespace Turtle.Library
{
    public static class Printer
    {
        
        public static string startString = "Starting Position of Turtle: ({x},{y}), Direction: {dir}";
        public static string movedFromTo = "Turtle moved from position {from} to {to}";
        public static string rotate = "Turned to {to}";
        public const string Dead = "Our poor turtle is dead";
        public const string Out = "Turtle went out of bounds";
        public const string IsNear = "Danger is near!";
        public const string Success = "Success";

        /// <summary>
        /// print turtle moved from point a to point b
        /// </summary>
        /// <param name="pointFrom"></param>
        /// <param name="pointTo"></param>
        public static void Print(Point pointFrom, Point pointTo)
        {
            var context = new ColorContext(new Yellow());
            context.ContextInterface();
            var combinePointFrom = $"({pointFrom.X},{pointFrom.Y})";
            var combinePointTo = $"({pointTo.X},{pointTo.Y})";
            var printText = movedFromTo.Replace("{from}", combinePointFrom).Replace("{to}", combinePointTo);
            //var printText = text.Replace("{from}", combinePointFrom).Replace("{to}", combinePointTo);
            //if (action != null) printText = $"{printText} - {action}";
            Console.WriteLine(printText);
            var contextWhite = new ColorContext(new White());
            contextWhite.ContextInterface();
            Console.WriteLine(new string('-', 50));
        }

        /// <summary>
        /// print a text
        /// </summary>
        /// <param name="text"></param>
        public static void Print(string text)
        {
            var contextGreen = new ColorContext(new Green());
            contextGreen.ContextInterface();
            Console.WriteLine(text);
            var contextWhite = new ColorContext(new White());
            contextWhite.ContextInterface();
            Console.WriteLine(new string('-', 50));
        }

        /// <summary>
        /// print turtle changed its direction
        /// </summary>
        /// <param name="dir"></param>
        public static void Print(Directions dir)
        {
            var contextGreen = new ColorContext(new Green());
            contextGreen.ContextInterface();
            Console.WriteLine(rotate.Replace("{to}", dir.ToString()));
            var contextWhite = new ColorContext(new White());
            contextWhite.ContextInterface();
            Console.WriteLine(new string('-', 50));
        }

        /// <summary>
        /// print turtle's starting state
        /// </summary>
        /// <param name="turtle"></param>
        public static void Print(Turtle.Library.Models.Turtle turtle)
        {
            var contextGreen = new ColorContext(new Green());
            contextGreen.ContextInterface();
            Console.WriteLine(startString.Replace("{x}", turtle.Position.X.ToString()).Replace("{y}", turtle.Position.Y.ToString()).Replace("{dir}", turtle.Direction.ToString()));
            var contextWhite = new ColorContext(new White());
            contextWhite.ContextInterface();
            Console.WriteLine(new string('-', 50));
        }
    }
}
