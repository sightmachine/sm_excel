using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using ExcelAddIn.Forms;
using ExcelAddIn.Models.DataTabCycle.Request;
using ExcelAddIn.Models.DataTabCycle.Response;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using Newtonsoft.Json;

namespace ExcelAddIn
{
    public partial class SightMachineRibbon
    {
        private ISightMachineHttpClient _sightMachineHttpClient;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //_sightMachineHttpClient = new SightMachineHttpClient();
        }

        //private void smButton_Click(object sender, RibbonControlEventArgs e)
        //{
        //    var client = GetHttpClient();
        //    var dataCycle = GetDataCycleRequest();
        //    var json = JsonConvert.SerializeObject(dataCycle);
        //    var data = new StringContent(json, Encoding.UTF8, "application/json");
        //    data.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        //    var uri = client.BaseAddress + "v1/datatab/cycle";
        //    var response = client.PostAsync(uri, data).Result;
        //    var responseContent = response.Content.ReadAsStringAsync().Result;
        //    var dataCycleResponse = JsonConvert.DeserializeObject<DataTabCycleResponse>(responseContent);


        //    // Fill data to excel sheet
        //    var currentWorksheet = Globals.ThisAddIn.GetActiveWorksheet();
        //    var activeApp = Globals.ThisAddIn.GetActiveApp();
            
        //    var headers = dataCycleResponse?.Results[0]?.GetType().GetProperties();
            
        //    // Create headers
        //    for (int i = 0; i < headers?.Length; i++)
        //    {
        //        var gg = i + 1;
        //        currentWorksheet.Cells[1, gg] = headers[i].Name;
        //    }

        //    // Populate rows
        //    for (int i = 0; i < dataCycleResponse?.Results.Count; i++)
        //    {
        //        //var columnNo = currentWorksheet.Cells.Range["A1"].Rows.Find("Id", LookAt: XlLookAt.xlWhole)?.Column;
        //        //if (columnNo != null)
        //        //{
        //        //    currentWorksheet.Cells[i + 2, i + 1] = dataCycleResponse?.Results[i].Id;
        //        //}

        //        currentWorksheet.Cells[i + 2, 1] = dataCycleResponse?.Results[i].Id;
        //        currentWorksheet.Cells[i + 2, 2] = dataCycleResponse?.Results[i].Shift;
        //        currentWorksheet.Cells[i + 2, 3] = dataCycleResponse?.Results[i].Shiftid;
        //        currentWorksheet.Cells[i + 2, 4] = dataCycleResponse?.Results[i].MachineSource;
        //        currentWorksheet.Cells[i + 2, 5] = dataCycleResponse?.Results[i].MachineSourceType;
        //        currentWorksheet.Cells[i + 2, 6] = dataCycleResponse?.Results[i].MachineFactoryLocation;
        //        currentWorksheet.Cells[i + 2, 7] = dataCycleResponse?.Results[i].MachineFactoryPartner;
        //        currentWorksheet.Cells[i + 2, 8] = dataCycleResponse?.Results[i].Capturetime;
        //        currentWorksheet.Cells[i + 2, 9] = dataCycleResponse?.Results[i].Starttime;
        //        currentWorksheet.Cells[i + 2, 10] = dataCycleResponse?.Results[i].StarttimeLocal;
        //        currentWorksheet.Cells[i + 2, 11] = dataCycleResponse?.Results[i].StarttimeEpoch;
        //        currentWorksheet.Cells[i + 2, 12] = dataCycleResponse?.Results[i].Endtime;
        //        currentWorksheet.Cells[i + 2, 13] = dataCycleResponse?.Results[i].EndtimeLocal;
        //        currentWorksheet.Cells[i + 2, 14] = dataCycleResponse?.Results[i].EndtimeEpoch;
        //        currentWorksheet.Cells[i + 2, 15] = dataCycleResponse?.Results[i].Total;
        //        currentWorksheet.Cells[i + 2, 16] = dataCycleResponse?.Results[i].Idealcycle;
        //        currentWorksheet.Cells[i + 2, 17] = dataCycleResponse?.Results[i].ShiftDate;
        //        currentWorksheet.Cells[i + 2, 18] = dataCycleResponse?.Results[i].ProductionDate;
        //        currentWorksheet.Cells[i + 2, 19] = dataCycleResponse?.Results[i].RecordTime;
        //        currentWorksheet.Cells[i + 2, 20] = dataCycleResponse?.Results[i].Output;
        //        currentWorksheet.Cells[i + 2, 21] = dataCycleResponse?.Results[i].Cycleindex;
        //        currentWorksheet.Cells[i + 2, 22] = dataCycleResponse?.Results[i].Timezone;
        //        currentWorksheet.Cells[i + 2, 23] = dataCycleResponse?.Results[i].NG;
        //        currentWorksheet.Cells[i + 2, 24] = dataCycleResponse?.Results[i].GripperMake;
        //        currentWorksheet.Cells[i + 2, 25] = dataCycleResponse?.Results[i].GripperModel;
        //        currentWorksheet.Cells[i + 2, 26] = dataCycleResponse?.Results[i].RobotMake;
        //        currentWorksheet.Cells[i + 2, 27] = dataCycleResponse?.Results[i].RobotModel;
        //        currentWorksheet.Cells[i + 2, 28] = dataCycleResponse?.Results[i].ConveyorSpeed;
        //        currentWorksheet.Cells[i + 2, 29] = dataCycleResponse?.Results[i].LaserCurrent;
        //        currentWorksheet.Cells[i + 2, 30] = dataCycleResponse?.Results[i].LaserVoltage;
        //        currentWorksheet.Cells[i + 2, 31] = dataCycleResponse?.Results[i].RobotVelocityX;
        //        currentWorksheet.Cells[i + 2, 32] = dataCycleResponse?.Results[i].RobotVelocityY;
        //        currentWorksheet.Cells[i + 2, 33] = dataCycleResponse?.Results[i].RobotVelocityZ;
        //        currentWorksheet.Cells[i + 2, 34] = dataCycleResponse?.Results[i].ProductSKU;
        //        currentWorksheet.Cells[i + 2, 35] = dataCycleResponse?.Results[i].OperatorLoadTotalTime;
        //        currentWorksheet.Cells[i + 2, 36] = dataCycleResponse?.Results[i].ConveyorInputTotalTime;
        //        currentWorksheet.Cells[i + 2, 37] = dataCycleResponse?.Results[i].VisionSystemTotalTime;
        //        currentWorksheet.Cells[i + 2, 38] = dataCycleResponse?.Results[i].LaserCuttingTotalTime;
        //        currentWorksheet.Cells[i + 2, 39] = dataCycleResponse?.Results[i].ConveyorOutputTotalTime;
        //        currentWorksheet.Cells[i + 2, 40] = dataCycleResponse?.Results[i].OperatorUnloadTotalTime;
        //        currentWorksheet.Cells[i + 2, 41] = dataCycleResponse?.Results[i].StatsProductSkuVal;
                
        //        FormatDateTime((Range) currentWorksheet.Cells[i + 2, 8]);
        //        FormatDateTime((Range)currentWorksheet.Cells[i + 2, 9]);
        //        FormatDateTime((Range)currentWorksheet.Cells[i + 2, 10]);
        //        FormatDateTime((Range)currentWorksheet.Cells[i + 2, 12]);
        //        FormatDateTime((Range)currentWorksheet.Cells[i + 2, 13]);

        //        FormatEpoch(currentWorksheet.Cells[i + 2, 11]);
        //        FormatEpoch(currentWorksheet.Cells[i + 2, 14]);
        //    }
            

        //    //var rowCount = currentWorksheet.UsedRange.Rows.Count;

        //    //Range serialNumbers = currentWorksheet.Range["A2:A" + rowCount];
        //    //Range dataCells = currentWorksheet.Range["B2:B" + rowCount];

        //    //Object[,] originalData = dataCells.Value2;

        //    //var elementCount = 0;
        //    //double[] originalDataArr = new double[rowCount - 1];
        //    //string[] serialNumberArr = new string[rowCount - 1];

        //    //foreach (var element in originalData)
        //    //{
        //    //    originalDataArr[elementCount] = Convert.ToDouble(element.ToString());
        //    //    elementCount++;
        //    //}

        //    //foreach (var element in serialNumbers)
        //    //{
        //    //    serialNumberArr[elementCount] = Convert.ToString(element.ToString());
        //    //    elementCount++;
        //    //}

        //    //var standardDev = activeApp.WorksheetFunction.StDev(dataCells.Cells);
        //    //var averageA = originalDataArr.Average();
        //    //var threeStd = 3 * standardDev;

        //    //var columnsTitles = new[] {"MEAN", "StdDev", "3StdDev"};
        //    //var columnsResults = new[] {averageA.ToString(), standardDev.ToString(), threeStd.ToString()};

        //    //for (int i = 0; i < columnsTitles.Length; i++)
        //    //{
        //    //    var titleRange = currentWorksheet.Range["D" + (i + 3)];
        //    //    titleRange.Value2 = columnsTitles[i];
        //    //    var valueRange = currentWorksheet.Range["E" + (i + 3)];
        //    //    valueRange.Value2 = columnsResults[i];
        //    //}

        //    //Range borderStats = currentWorksheet.Range["D3:E" + (columnsTitles.Length + 2)];
        //    //borderStats.BorderAround2(XlLineStyle.xlDouble, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic,
        //    //    XlThemeColor.xlThemeColorLight2);
        //}

        //private static void FormatEpoch(Range range)
        //{
        //    range.EntireColumn.NumberFormat = "#####";
        //}

        //private static void FormatDateTime(Range range)
        //{
        //    range.EntireColumn.NumberFormat = "mm-d-yy h:mm:ss AM/PM";
        //}

        //private static DataTabCycleRequest GetDataCycleRequest()
        //{
        //    return new DataTabCycleRequest()
        //    {
        //        AssetSelection = new AssetSelection()
        //        {
        //            MachineSource = new List<string>() { "JB_CA_Lasercut_1", "JB_CA_Lasercut_4" },
        //            MachineType = "Lasercut"
        //        },
        //        TimeSelection = new TimeSelection()
        //        {
        //            EndTime = new DateTime(2021, 10, 15),
        //            StartTime = new DateTime(2021, 10, 14),
        //            TimeType= "absolute"
        //        },
        //        DbMode = "sql",
        //        Limit = 3000,
        //        Offset = 0
        //    };
        //}

        //private static HttpClient GetHttpClient()
        //{
        //    var client = new HttpClient()
        //    {
        //        BaseAddress = new Uri("https://demo-excelplugin-test-env.sightmachine.io"),
        //    };

        //    client.DefaultRequestHeaders.Add("X-SM-API-Key-Id", "c3d80723-1310-43e5-8efa-26e68a15f0cf");
        //    client.DefaultRequestHeaders.Add("X-SM-API-Secret", "5F-Sh2Yg6X3FFDJiElDsa_D2yADtEeDPYiJk_hhVIms");
        //    ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
        //    return client;
        //}

        private void Configuration_Click(object sender, RibbonControlEventArgs e)
        {
            var configurationForm = new Configuration();
            configurationForm.ShowDialog();
        }

        private void DataTabCycleButton_Click(object sender, RibbonControlEventArgs e)
        {
            var dataCycleForm = new DataCycle();
            dataCycleForm.ShowDialog();
        }
    }
}
