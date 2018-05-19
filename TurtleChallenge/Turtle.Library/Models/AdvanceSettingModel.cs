using System.Collections.Generic;
using System.Drawing;

namespace Turtle.Library.Models
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
