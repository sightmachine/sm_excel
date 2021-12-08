using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Response
{
    public class Where
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("op")]
        public string Op { get; set; }

        [JsonProperty("value")]
        public object Value { get; set; }
    }
}