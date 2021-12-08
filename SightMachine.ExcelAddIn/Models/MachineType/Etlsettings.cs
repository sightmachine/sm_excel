using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Etlsettings
    {
        [JsonProperty("down_fields")]
        public List<string> DownFields { get; set; }

        //[JsonProperty("merge_downtimes")]
        //public bool[] MergeDowntimes { get; set; }

        [JsonProperty("modules")]
        public Modules Modules { get; set; }
    }
}