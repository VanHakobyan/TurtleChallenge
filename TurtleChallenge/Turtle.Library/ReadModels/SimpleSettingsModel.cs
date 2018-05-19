using System.Collections.Generic;

namespace Turtle.Library.ReadModels
{
    public class SimpleSettingsModel
    {
        public List<string> MoveExit { get; set; }
        public List<string> MoveHitMine { get; set; }
        public List<string> MoveMoveNoEnd { get; set; }
    }
}
