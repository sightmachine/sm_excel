using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class CodeMap
    {
        [JsonProperty("000")]
        public string _000 { get; set; }

        [JsonProperty("011")]
        public string _011 { get; set; }

        [JsonProperty("012")]
        public string _012 { get; set; }

        [JsonProperty("021")]
        public string _021 { get; set; }
    }
}