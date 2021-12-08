using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Stat
    {
        [JsonProperty("analytics")]
        public Analytics Analytics { get; set; }

        [JsonProperty("display")]
        public Display Display { get; set; }

        [JsonProperty("func")]
        public string Func { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("var")]
        public string Var { get; set; }

        [JsonProperty("variance")]
        public double? Variance { get; set; }

        [JsonProperty("in_timeline")]
        public bool? InTimeline { get; set; }
    }
}