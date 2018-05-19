using System;
using Turtle.Library.Models;
using Turtle.Library.Strategy;

namespace Turtle.Library
{
    public static class Printer
    {
        private const string FacingSouth = "Turtle now facing South";
        private static string _movedFromTo = "Turtle moved from position {from} to {to}";
        private const string Danger = "Danger";
        private const string MineHit = "Mine Hit";
        private const string Exit = "Exit";

        public static void Print(Point pointFrom, Point pointTo, string text, string action = null)
        {
            var context=new ColorContext(new Yellow());
            context.ContextInterface();
            var combinePointFrom = $"({pointFrom.X},{pointFrom.Y})";
            var combinePointTo = $"({pointTo.X},{pointTo.Y})";
            var printText = text.Replace("{from}", combinePointFrom).Replace("{to}", combinePointTo);
            if (action != null) printText = $"{printText} - {action}";
            Console.WriteLine(printText);
            var contextCyan = new ColorContext(new White());
            contextCyan.ContextInterface();
            Console.WriteLine(new string('-',50));
        }

        public static void PrintSimple(string text)
        {
            var contextGreen = new ColorContext(new Green());
            contextGreen.ContextInterface();
            Console.WriteLine(text);
            var contextCyan = new ColorContext(new White());
            contextCyan.ContextInterface();
            Console.WriteLine(new string('-', 50));
        }
    }
}
