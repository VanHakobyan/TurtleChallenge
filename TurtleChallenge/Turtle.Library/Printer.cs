using System;
using Turtle.Library.Models;

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
            var combinePointFrom = $"({pointFrom.X},{pointFrom.Y})";
            var combinePointTo = $"({pointTo.X},{pointTo.Y})";
            var printText = text.Replace("{from}", combinePointFrom).Replace("{to}", combinePointTo);
            if (action != null) printText = $"{printText} - {action}";
            Console.WriteLine(printText);
        }

        public static void PrintSimple(string text) => Console.WriteLine(text);
    }
}
