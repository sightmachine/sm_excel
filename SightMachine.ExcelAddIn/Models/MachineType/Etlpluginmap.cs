using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Etlpluginmap
    {
        [JsonProperty("cycle")]
        public string Cycle { get; set; }

        [JsonProperty("defect")]
        public string Defect { get; set; }

        [JsonProperty("downtime")]
        public string Downtime { get; set; }
    }
}