using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Request
{
    public class DataTabCycleRequest
    {
        [JsonProperty("asset_selection")]
        public AssetSelection AssetSelection { get; set; }

        [JsonProperty("time_selection")]
        public TimeSelection TimeSelection { get; set; }

        [JsonProperty("db_mode")]
        public string DbMode { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }
}