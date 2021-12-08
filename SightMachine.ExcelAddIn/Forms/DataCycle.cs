using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelAddIn.Exception;
using ExcelAddIn.Helper;
using ExcelAddIn.Logging;
using ExcelAddIn.Models.DataTabCycle.Request;
using ExcelAddIn.Models.DataTabCycle.Response;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

namespace ExcelAddIn.Forms
{
    public partial class DataCycle : Form
    {
        private ISightMachineHttpClient _sightMachineHttpClient;

        public DataCycle()
        {
            InitializeComponent();
        }

        private void SelectMachineListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal List<string> GetSelectedMachineTypes()
        {
            var selectedMachines = new List<string>();
            foreach (var selectedItem in SelectMachineListBox.SelectedItems)
            {
                selectedMachines.Add((string)selectedItem);
            }

            return selectedMachines;
        }

        private async void LoadDataTabCyclesButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoadDataTabCyclesButton.Enabled = false;
                Application.UseWaitCursor = true;

                // Validate
                Validator.HandleNullOrWhiteSpaceRequired(MachineTypeComboBox, MachineTypeLabel.Text);
                ValidateInputDetails();

                await LoadDataTabCycles();
            }
            catch (ValidationException validationException)
            {
                LogHelper.Log($"{validationException.Message} : {validationException.StackTrace}");
                MessageBox.Show(validationException.Message, @"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (DataNotFoundException dataNotFoundException)
            {
                LogHelper.Log($"{dataNotFoundException.Message} : {dataNotFoundException.StackTrace}");
                MessageBox.Show(dataNotFoundException.Message, @"Data not found", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (System.Exception exception)
            {
                LogHelper.Log($"{exception.Message} : {exception.StackTrace}");
                MessageBox.Show(exception.Message, @"Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadDataTabCyclesButton.Enabled = true;
            Application.UseWaitCursor = false;
        }

        internal async Task LoadDataTabCycles()
        {
            var selectedMachineType = ((ComboBoxItem) MachineTypeComboBox.SelectedItem).Value.ToString();
            var selectedMachines = GetSelectedMachineTypes();
            var dataCycleRequest = GetDataCycleRequest(selectedMachineType, selectedMachines, StartDateTimePicker.Value,
                EndDateTimePicker.Value);
            var dataCycleResponse = await _sightMachineHttpClient.PostDataTabCycle(dataCycleRequest);

            if (dataCycleResponse?.Results.Any() == true)
            {
                // Fill data to excel sheet
                await PopulateDataInRows(dataCycleResponse, dataCycleRequest);
            }
            else
            {
                throw new DataNotFoundException("There are no records found for the selected filter criteria");
            }
        }

        internal void ValidateInputDetails()
        {
            if (SelectMachineListBox.SelectedItems.Count < 1)
            {
                SelectMachineListBox.Focus();
                throw new ValidationException("Please select at-least one machine from Machine list.");
            }

            if (StartDateTimePicker.Value > EndDateTimePicker.Value)
            {
                StartDateTimePicker.Focus();
                throw new ValidationException("End date time should be greater than start date time.");
            }
        }

        private async Task PopulateDataInRows(DataTabCycleResponse dataCycleResponse, DataTabCycleRequest dataCycleRequest)
        {
            // Fill data to excel sheet
            var currentWorksheet = Globals.ThisAddIn.GetActiveWorksheet();
            if (IsCellHasValue(currentWorksheet))
            {
                var messageBoxResult = MessageBox.Show(
                    @"Current worksheet already have some data." +
                    @"Do you want to create new worksheet and load the data into new tab ?",
                    @"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (messageBoxResult == DialogResult.No)
                {
                    return;
                }

                currentWorksheet = (Worksheet)Globals.ThisAddIn.Application.Worksheets.Add();
            }

            Close();
            var headers = dataCycleResponse?.Results[0]?.GetType().GetProperties();

            // Create headers
            for (int i = 0; i < headers?.Length; i++)
            {
                currentWorksheet.Cells[1, i + 1] = headers[i].Name;
            }

            var record = 2;
            while (true)
            {
                if (dataCycleResponse?.Results.Any() == true)
                {
                    // Populate rows
                    for (int row = 0; row < dataCycleResponse?.Results.Count; row++)
                    {
                        try
                        {
                            currentWorksheet.Cells[record, 1] = dataCycleResponse?.Results[row].Id;
                            currentWorksheet.Cells[record, 2] = dataCycleResponse?.Results[row].Shift;
                            currentWorksheet.Cells[record, 3] = dataCycleResponse?.Results[row].Shiftid;
                            currentWorksheet.Cells[record, 4] = dataCycleResponse?.Results[row].MachineSource;
                            currentWorksheet.Cells[record, 5] = dataCycleResponse?.Results[row].MachineSourceType;
                            currentWorksheet.Cells[record, 6] = dataCycleResponse?.Results[row].MachineFactoryLocation;
                            currentWorksheet.Cells[record, 7] = dataCycleResponse?.Results[row].MachineFactoryPartner;
                            currentWorksheet.Cells[record, 8] = dataCycleResponse?.Results[row].Capturetime;
                            currentWorksheet.Cells[record, 9] = dataCycleResponse?.Results[row].Starttime;
                            currentWorksheet.Cells[record, 10] = dataCycleResponse?.Results[row].StarttimeLocal;
                            currentWorksheet.Cells[record, 11] = dataCycleResponse?.Results[row].StarttimeEpoch;
                            currentWorksheet.Cells[record, 12] = dataCycleResponse?.Results[row].Endtime;
                            currentWorksheet.Cells[record, 13] = dataCycleResponse?.Results[row].EndtimeLocal;
                            currentWorksheet.Cells[record, 14] = dataCycleResponse?.Results[row].EndtimeEpoch;
                            currentWorksheet.Cells[record, 15] = dataCycleResponse?.Results[row].Total;
                            currentWorksheet.Cells[record, 16] = dataCycleResponse?.Results[row].Idealcycle;
                            currentWorksheet.Cells[record, 17] = dataCycleResponse?.Results[row].ShiftDate;
                            currentWorksheet.Cells[record, 18] = dataCycleResponse?.Results[row].ProductionDate;
                            currentWorksheet.Cells[record, 19] = dataCycleResponse?.Results[row].RecordTime;
                            currentWorksheet.Cells[record, 20] = dataCycleResponse?.Results[row].Output;
                            currentWorksheet.Cells[record, 21] = dataCycleResponse?.Results[row].Cycleindex;
                            currentWorksheet.Cells[record, 22] = dataCycleResponse?.Results[row].Timezone;
                            currentWorksheet.Cells[record, 23] = dataCycleResponse?.Results[row].NG;
                            currentWorksheet.Cells[record, 24] = dataCycleResponse?.Results[row].GripperMake;
                            currentWorksheet.Cells[record, 25] = dataCycleResponse?.Results[row].GripperModel;
                            currentWorksheet.Cells[record, 26] = dataCycleResponse?.Results[row].RobotMake;
                            currentWorksheet.Cells[record, 27] = dataCycleResponse?.Results[row].RobotModel;
                            currentWorksheet.Cells[record, 28] = dataCycleResponse?.Results[row].ConveyorSpeed;
                            currentWorksheet.Cells[record, 29] = dataCycleResponse?.Results[row].LaserCurrent;
                            currentWorksheet.Cells[record, 30] = dataCycleResponse?.Results[row].LaserVoltage;
                            currentWorksheet.Cells[record, 31] = dataCycleResponse?.Results[row].RobotVelocityX;
                            currentWorksheet.Cells[record, 32] = dataCycleResponse?.Results[row].RobotVelocityY;
                            currentWorksheet.Cells[record, 33] = dataCycleResponse?.Results[row].RobotVelocityZ;
                            currentWorksheet.Cells[record, 34] = dataCycleResponse?.Results[row].ProductSKU;
                            currentWorksheet.Cells[record, 35] = dataCycleResponse?.Results[row].OperatorLoadTotalTime;
                            currentWorksheet.Cells[record, 36] = dataCycleResponse?.Results[row].ConveyorInputTotalTime;
                            currentWorksheet.Cells[record, 37] = dataCycleResponse?.Results[row].VisionSystemTotalTime;
                            currentWorksheet.Cells[record, 38] = dataCycleResponse?.Results[row].LaserCuttingTotalTime;
                            currentWorksheet.Cells[record, 39] =
                                dataCycleResponse?.Results[row].ConveyorOutputTotalTime;
                            currentWorksheet.Cells[record, 40] =
                                dataCycleResponse?.Results[row].OperatorUnloadTotalTime;
                            currentWorksheet.Cells[record, 41] = dataCycleResponse?.Results[row].StatsProductSkuVal;

                            FormatDateTime((Range) currentWorksheet.Cells[row + 2, 8]);
                            FormatDateTime((Range) currentWorksheet.Cells[row + 2, 9]);
                            FormatDateTime((Range) currentWorksheet.Cells[row + 2, 10]);
                            FormatDateTime((Range) currentWorksheet.Cells[row + 2, 12]);
                            FormatDateTime((Range) currentWorksheet.Cells[row + 2, 13]);

                            FormatEpoch(currentWorksheet.Cells[row + 2, 11]);
                            FormatEpoch(currentWorksheet.Cells[row + 2, 14]);
                            record++;
                        }
                        catch (COMException exception)
                        {
                            var range = currentWorksheet.Cells[record, 41];
                            currentWorksheet.Cells.Delete(range);
                        }
                    }
                }
                else
                {
                    break;
                }

                dataCycleRequest.Offset += dataCycleResponse.Results.Count;
                dataCycleRequest.Limit = ConfigurationSettings.Default.PageSize;
                dataCycleResponse = await _sightMachineHttpClient.PostDataTabCycle(dataCycleRequest);
            }

            MessageBox.Show($@"Successfully loaded all data.", @"Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public bool IsCellHasValue(Worksheet worksheet)
        {
            //Get the used Range
           var usedRange = worksheet.UsedRange;

            //Iterate the rows in the used range
            foreach (Range row in usedRange.Rows)
            {
                //Do something with the row.

                //Ex. Iterate through the row's data and put in a string array
                //string[] rowData = new string[row.Columns.Count];

                for (int i = 0; i < row.Columns.Count; i++)
                {
                    string cellValue = Convert.ToString(row.Cells[1, i + 1].Value2);

                    if (!string.IsNullOrWhiteSpace(cellValue))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static void FormatEpoch(Range range)
        {
            range.EntireColumn.NumberFormat = "#####";
        }

        private static void FormatDateTime(Range range)
        {
            range.EntireColumn.NumberFormat = "mm-d-yy h:mm:ss AM/PM";
        }

        private static DataTabCycleRequest GetDataCycleRequest(string machineType, List<string> machineSources, DateTime startDateTime, DateTime endDateTime)
        {
            return new DataTabCycleRequest()
            {
                AssetSelection = new AssetSelection()
                {
                    MachineSource = machineSources,
                    MachineType = machineType
                },
                TimeSelection = new TimeSelection()
                {
                    EndTime = DateTime.Parse(endDateTime.ToString("yyyy-MM-ddTHH:mm:ss")),
                    StartTime = DateTime.Parse(startDateTime.ToString("yyyy-MM-ddTHH:mm:ss")),
                    TimeType = "absolute"
                },
                DbMode = "sql",
                Limit = ConfigurationSettings.Default.PageSize == 0 ? 100 : ConfigurationSettings.Default.PageSize,
                Offset = 0
            };
        }

        private async void DataCycle_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.Cursor = Cursors.Default;

                EndDateTimePicker.Format = DateTimePickerFormat.Custom;
                EndDateTimePicker.CustomFormat = @"dddd, dd MMMM yyyy hh:mm:ss tt";

                StartDateTimePicker.Format = DateTimePickerFormat.Custom;
                StartDateTimePicker.CustomFormat = @"dddd, dd MMMM yyyy hh:mm:ss tt";

                if (!ConfigurationSettings.Default.IsApiReadyAndValidated)
                {
                    MessageBox.Show($@"Configuration is missing or invalid, please first provide the configuration data in order to use the add-in.", @"Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    new Configuration().ShowDialog();
                    Close();
                }
                else
                {
                    _sightMachineHttpClient = new SightMachineHttpClient();
                    var machineTypes = await _sightMachineHttpClient.GetMachineType();
                    if (machineTypes == null)
                    {
                        MessageBox.Show($@"Failed to load Machine Types.", @"Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        foreach (var machineType in machineTypes)
                        {
                            var item = new ComboBoxItem
                            {
                                Text = machineType.SourceTypeClean,
                                Value = machineType.SourceType
                            };

                            MachineTypeComboBox.Items.Add(item);
                        }
                    }
                }
            }
            catch (System.Exception exception)
            {
                LogHelper.Log($"{exception.Message} : {exception.StackTrace}");
                MessageBox.Show(exception.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void MachineTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectMachineListBox.Items.Clear();
                var selectedMachineType = ((ComboBoxItem)MachineTypeComboBox.SelectedItem).Value.ToString();
                if (!string.IsNullOrWhiteSpace(selectedMachineType))
                {
                    var queryParam = new Dictionary<string, string> { { "source_type", selectedMachineType } };
                    _sightMachineHttpClient = new SightMachineHttpClient();
                    var machineDetails = await _sightMachineHttpClient.GetMachineDetails(queryParam);
                    if (machineDetails.Any())
                    {
                        foreach (var machineDetail in machineDetails)
                        {
                            SelectMachineListBox.Items.Add(machineDetail.Source);
                        }
                    }
                }
            }
            catch (System.Exception exception)
            {
                LogHelper.Log($"{exception.Message} : {exception.StackTrace}");
                MessageBox.Show(exception.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
