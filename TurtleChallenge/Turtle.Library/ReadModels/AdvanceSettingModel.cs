using System.Collections.Generic;
using Turtle.Library.Models;

namespace Turtle.Library.ReadModels
{
    public class AdvanceSettingModel
    {
        public Point Size { get; set; }
        public Point StartPoint { get; set; }
        public Point ExitPoint { get; set; }
        public List<Point> MinePoints { get; set; } = new List<Point>();
        public string Directory { get; set; }
    }
}
