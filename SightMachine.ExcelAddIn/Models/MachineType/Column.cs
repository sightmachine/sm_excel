using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Column
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("source_field")]
        public string SourceField { get; set; }

        [JsonProperty("stat_type")]
        public string StatType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}