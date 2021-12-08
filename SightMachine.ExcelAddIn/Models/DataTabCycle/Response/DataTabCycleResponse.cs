using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Response
{
    public class DataTabCycleResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }
    }
}