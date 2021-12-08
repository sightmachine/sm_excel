using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class DowntimeClassifier
    {
        [JsonProperty("code_map")]
        public CodeMap CodeMap { get; set; }

        [JsonProperty("coefs")]
        public object Coefs { get; set; }

        [JsonProperty("rev_mapping")]
        public object RevMapping { get; set; }

        [JsonProperty("use_previous_cycle")]
        public bool UsePreviousCycle { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}