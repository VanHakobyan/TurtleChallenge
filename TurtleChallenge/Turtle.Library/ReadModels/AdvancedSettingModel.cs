using System.Collections.Generic;
using Turtle.Library.Models;

namespace Turtle.Library.ReadModels
{
    public class AdvancedSettingsModel
    {
        public Point Size { get; set; }
        public Point StartPoint { get; set; }
        public Point ExitPoint { get; set; }
        public List<Point> MinePoints { get; set; } = new List<Point>();
        public string Direction { get; set; }
    }
}
