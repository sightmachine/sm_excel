using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Response
{
    public class Meta
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("where")]
        public List<Where> Where { get; set; }

        [JsonProperty("order_by")]
        public List<OrderBy> OrderBy { get; set; }
    }
}