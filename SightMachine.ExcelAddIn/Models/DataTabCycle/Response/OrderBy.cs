using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Response
{
    public class OrderBy
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }
    }
}