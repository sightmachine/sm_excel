using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExcelAddIn;
using ExcelAddIn.Forms;
using ExcelAddIn.Helper;
using NUnit.Framework;

namespace SightMachine.ExcelAddIn.Test
{
    [TestFixture]
    public class DataCycleTests
    {
        private DataCycle _dataCycleForm;

        [SetUp]
        public void Setup()
        {
            _dataCycleForm = new DataCycle();
        }

        [TestCase]
        public void GetSelectedMachineTypes_ShouldReturnSelectedMachines()
        {
            //Arrange
            for (int i = 1; i <= 10; i++)
            {
                _dataCycleForm.SelectMachineListBox.Items.Add($"Test {i}");
            }
            _dataCycleForm.SelectMachineListBox.SetSelected(1, true);
            _dataCycleForm.SelectMachineListBox.SetSelected(2, true);
            _dataCycleForm.SelectMachineListBox.SetSelected(4, true);

            //Act
            var selectedValues = _dataCycleForm.GetSelectedMachineTypes();

            //Assert
            Assert.True(selectedValues.Contains($"Test 2"));
            Assert.True(selectedValues.Contains($"Test 3"));
            Assert.True(selectedValues.Contains($"Test 5"));
        }

        [TestCase]
        public async Task LoadDataTabCycles_ShouldReturn_InvalidOperationException()
        {
            //Arrange
            ConfigurationSettings.Default.APIKey = "c3d80723-1310-43e5-8efa-26e68a15f0cf";
            ConfigurationSettings.Default.APISecret = "5F-Sh2Yg6X3FFDJiElDsa_D2yADtEeDPYiJk_hhVIms";
            ConfigurationSettings.Default.ApiBaseUrl = "https://demo-excelplugin-test-env.sightmachine.io";
            ConfigurationSettings.Default.PageSize = 100;

            var sightMachineHttpClient = new SightMachineHttpClient();
            var machines = await sightMachineHttpClient.GetMachineType();
            var queryParam = new Dictionary<string, string> { { "source_type", machines[0].SourceType } };
            var machineTypes = await sightMachineHttpClient.GetMachineDetails(queryParam);

            _dataCycleForm.MachineTypeComboBox.Items.Add(new ComboBoxItem
            {
                Text = machines[0].SourceTypeClean,
                Value = machines[0].SourceType
            });
            _dataCycleForm.MachineTypeComboBox.SelectedIndex = 0;
            _dataCycleForm.SelectMachineListBox.Items.Add(machineTypes[0].Source);
            _dataCycleForm.SelectMachineListBox.SetSelected(0,true);

            //Act
            //Assert
            Assert.ThrowsAsync<InvalidOperationException>(async () => await _dataCycleForm.LoadDataTabCycles());
        }
    }
}