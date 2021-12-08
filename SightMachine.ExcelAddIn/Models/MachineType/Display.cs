using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Display
    {
        [JsonProperty("title_prefix")]
        public string TitlePrefix { get; set; }
    }
}