using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class Analytics
    {
        [JsonProperty("columns")]
        public List<Column> Columns { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("schema_name")]
        public object SchemaName { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("extra_indexes")]
        public List<object> ExtraIndexes { get; set; }

        [JsonProperty("update_range_require_delete")]
        public bool UpdateRangeRequireDelete { get; set; }

        [JsonProperty("extra_columns")]
        public List<object> ExtraColumns { get; set; }
    }
}