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
        private List<string> GetListMoveExit()
        {
            var moveExit = File.ReadAllText("..\\..\\Settings\\move-exit.csv");
            return moveExit.Split(',').ToList();
        }

        private List<string> GetListMoveHitMine()
        {
            var moveHitMine = File.ReadAllText("..\\..\\Settings\\move-hit mine.csv");
            return  moveHitMine.Split(',').ToList();
        }

        private List<string> GetListMoveNoEnd()
        {
            var moveNoEnd = File.ReadAllText("..\\..\\Settings\\move-no end.csv");
            return moveNoEnd.Split(',').ToList();
        }


        public SimpleSettingsModel GetSimpleSettings()=> new SimpleSettingsModel{MoveExit = GetListMoveExit(),MoveHitMine = GetListMoveHitMine(),MoveMoveNoEnd = GetListMoveNoEnd()};
        

        public void GetAdvanceSettings()
        {
            var settings = File.ReadAllText("..\\..\\Settings\\settings.csv");
        }
    }
}
