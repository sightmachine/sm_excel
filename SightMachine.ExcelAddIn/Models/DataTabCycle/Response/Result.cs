using Newtonsoft.Json;

namespace ExcelAddIn.Models.DataTabCycle.Response
{
    public class Result
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("shift")]
        public string Shift { get; set; }

        [JsonProperty("shiftid")]
        public string Shiftid { get; set; }

        [JsonProperty("machine__source")]
        public string MachineSource { get; set; }

        [JsonProperty("machine__source_type")]
        public string MachineSourceType { get; set; }

        [JsonProperty("machine__factory_location")]
        public string MachineFactoryLocation { get; set; }

        [JsonProperty("machine__factory_partner")]
        public string MachineFactoryPartner { get; set; }

        [JsonProperty("capturetime")]
        public string Capturetime { get; set; }

        [JsonProperty("starttime")]
        public string Starttime { get; set; }

        [JsonProperty("starttime_local")]
        public string StarttimeLocal { get; set; }

        [JsonProperty("starttime_epoch")]
        public object StarttimeEpoch { get; set; }

        [JsonProperty("endtime")]
        public string Endtime { get; set; }

        [JsonProperty("endtime_local")]
        public string EndtimeLocal { get; set; }

        [JsonProperty("endtime_epoch")]
        public object EndtimeEpoch { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("idealcycle")]
        public int Idealcycle { get; set; }

        [JsonProperty("shift_date")]
        public string ShiftDate { get; set; }

        [JsonProperty("production_date")]
        public string ProductionDate { get; set; }

        [JsonProperty("record_time")]
        public int RecordTime { get; set; }

        [JsonProperty("output")]
        public double Output { get; set; }

        [JsonProperty("cycleindex")]
        public int Cycleindex { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("NG")]
        public bool NG { get; set; }

        [JsonProperty("Gripper Make")]
        public string GripperMake { get; set; }

        [JsonProperty("Gripper Model")]
        public string GripperModel { get; set; }

        [JsonProperty("Robot Make")]
        public string RobotMake { get; set; }

        [JsonProperty("Robot Model")]
        public string RobotModel { get; set; }

        [JsonProperty("Conveyor Speed")]
        public double? ConveyorSpeed { get; set; }

        [JsonProperty("Laser Current")]
        public double? LaserCurrent { get; set; }

        [JsonProperty("Laser Voltage")]
        public double? LaserVoltage { get; set; }

        [JsonProperty("Robot Velocity (x)")]
        public double? RobotVelocityX { get; set; }

        [JsonProperty("Robot Velocity (y)")]
        public double? RobotVelocityY { get; set; }

        [JsonProperty("Robot Velocity (z)")]
        public double? RobotVelocityZ { get; set; }

        [JsonProperty("Product SKU")]
        public string ProductSKU { get; set; }

        [JsonProperty("Operator Load - Total Time")]
        public double OperatorLoadTotalTime { get; set; }

        [JsonProperty("Conveyor Input - Total Time")]
        public double ConveyorInputTotalTime { get; set; }

        [JsonProperty("Vision System - Total Time")]
        public double VisionSystemTotalTime { get; set; }

        [JsonProperty("Laser Cutting - Total Time")]
        public double LaserCuttingTotalTime { get; set; }

        [JsonProperty("Conveyor Output - Total Time")]
        public double ConveyorOutputTotalTime { get; set; }

        [JsonProperty("Operator Unload - Total Time")]
        public double OperatorUnloadTotalTime { get; set; }

        [JsonProperty("stats__ProductSku__val")]
        public string StatsProductSkuVal { get; set; }
    }
}