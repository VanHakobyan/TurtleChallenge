using System;
using Turtle.Library.Models;
using Turtle.Library.Strategy;

namespace Turtle.Library
{
    public static class Printer
    {
        public const string FacingSouth = "Turtle now facing South";
        public static string startString = "Starting Position of Turtle: ({x},{y}), Direction: {dir}";
        public static string movedFromTo = "Turtle moved from position {from} to {to}";
        public static string rotate = "Turned to {to}";
        public const string Danger = "Danger";
        public const string MineHit = "Mine Hit";
        public const string Exit = "Exit";

        //public static void Print(Point pointFrom, Point pointTo, string text, string action = null)
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
            var contextCyan = new ColorContext(new White());
            contextCyan.ContextInterface();
            Console.WriteLine(new string('-', 50));
        }

        public static void Print(string text)
        {
            var contextGreen = new ColorContext(new Green());
            contextGreen.ContextInterface();
            Console.WriteLine(text);
            var contextCyan = new ColorContext(new White());
            contextCyan.ContextInterface();
            Console.WriteLine(new string('-', 50));
        }

        public static void Print(Directions dir)
        {
            Console.WriteLine(rotate.Replace("{to}", dir.ToString()));
        }

        public static void Print(Turtle.Library.Models.Turtle turtle)
        {
            Console.WriteLine(startString.Replace("{x}", turtle.Position.X.ToString()).Replace("{y}", turtle.Position.Y.ToString()).Replace("{dir}", turtle.Direction.ToString()));
        }
    }
}
