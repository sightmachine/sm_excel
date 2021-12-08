using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineDetails
{
    public class Metadata
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}