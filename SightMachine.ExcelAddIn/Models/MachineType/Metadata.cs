using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Metadata
    {
        [JsonProperty("downtime_classifier")]
        public DowntimeClassifier DowntimeClassifier { get; set; }
    }
}