using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class DEFAULT
    {
        [JsonProperty("cycle_finished_product_ratio")]
        public decimal CycleFinishedProductRatio { get; set; }

        [JsonProperty("cycle_ideal")]
        public int CycleIdeal { get; set; }

        [JsonProperty("cycle_threshold")]
        public int CycleThreshold { get; set; }
    }
}