using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExcelAddIn.Models.MachineType
{
    public class MachineTypeResponse
    {
        [JsonProperty("capturetime")]
        public DateTime Capturetime { get; set; }

        [JsonProperty("capturetime_epoch")]
        public long CapturetimeEpoch { get; set; }

        [JsonProperty("updatetime")]
        public string Updatetime { get; set; }

        [JsonProperty("localtz")]
        public string Localtz { get; set; }

        [JsonProperty("updatelocation")]
        public string Updatelocation { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("tombstone")]
        public bool Tombstone { get; set; }

        [JsonProperty("tombstone_epoch")]
        public int TombstoneEpoch { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("schema_name")]
        public string SchemaName { get; set; }

        [JsonProperty("source_type_clean")]
        public string SourceTypeClean { get; set; }

        [JsonProperty("etlpluginmap")]
        public Etlpluginmap Etlpluginmap { get; set; }

        [JsonProperty("etlsettings")]
        public Etlsettings Etlsettings { get; set; }

        [JsonProperty("recipes")]
        public Recipes Recipes { get; set; }

        [JsonProperty("stats")]
        public List<Stat> Stats { get; set; }

        [JsonProperty("part_type")]
        public string PartType { get; set; }

        [JsonProperty("meta_assign")]
        public object MetaAssign { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("scaffold")]
        public object Scaffold { get; set; }

        [JsonProperty("cmdr_meta")]
        public object CmdrMeta { get; set; }

        [JsonProperty("analytics")]
        public Analytics Analytics { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}