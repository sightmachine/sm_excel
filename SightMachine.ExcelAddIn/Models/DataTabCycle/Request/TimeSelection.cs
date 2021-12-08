using System;
using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Request
{
    public class TimeSelection
    {
        [JsonProperty("time_type")]
        public string TimeType { get; set; }

        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty("end_time")]
        public DateTime EndTime { get; set; }
    }
}