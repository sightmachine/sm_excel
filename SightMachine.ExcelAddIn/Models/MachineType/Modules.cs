using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Modules
    {
        [JsonProperty("get_group_record_by_index")]
        public string GetGroupRecordByIndex { get; set; }

        [JsonProperty("get_record_groups")]
        public string GetRecordGroups { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("process_record")]
        public string ProcessRecord { get; set; }

        [JsonProperty("update_machinestate")]
        public string UpdateMachinestate { get; set; }
    }
}