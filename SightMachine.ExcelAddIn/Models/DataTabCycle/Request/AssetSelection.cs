using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Request
{
    public class AssetSelection
    {
        [JsonProperty("machine_source")]
        public List<string> MachineSource { get; set; }

        [JsonProperty("machine_type")]
        public string MachineType { get; set; }
    }
}