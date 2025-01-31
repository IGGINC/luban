using Luban.Job.Common.RawDefs;
using System.Collections.Generic;

namespace Luban.Job.Proto.RawDefs
{
    public class Defines
    {
        public string TopModule { get; set; } = "";

        public List<Service> ProtoServices { get; set; } = new List<Service>();

        public List<Bean> Beans { get; set; } = new List<Bean>();

        public List<PEnum> Enums { get; set; } = new List<PEnum>();

        public List<PProto> Protos { get; set; } = new List<PProto>();

        public List<PRpc> Rpcs { get; set; } = new List<PRpc>();
    }
}
