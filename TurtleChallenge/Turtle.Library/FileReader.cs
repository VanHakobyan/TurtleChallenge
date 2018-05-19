using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Turtle.Library
{
    public class FileReader
    {
        public void GetSimpleSettings()
        {
            var moveExit = File.ReadAllText("\\Settings\\move-exit.csv");
            var moveHitMine = File.ReadAllText("\\Settings\\move-hit mine.csv");
            var moveNoEnd = File.ReadAllText("\\Settings\\move-no end.csv");
        }

        public void GetAdvanceSettings()
        {
            var settings = File.ReadAllText("\\Settings\\settings.csv");
        }
    }
}
