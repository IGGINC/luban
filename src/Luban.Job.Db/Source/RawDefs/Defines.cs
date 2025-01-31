using Luban.Job.Common.RawDefs;
using System.Collections.Generic;

namespace Luban.Job.Db.RawDefs
{
    public class Defines
    {
        public string TopModule { get; set; } = "";

        public List<Bean> Beans { get; set; } = new List<Bean>();

        public List<PEnum> Enums { get; set; } = new List<PEnum>();

        public List<Table> DbTables { get; set; } = new List<Table>();
    }
}
