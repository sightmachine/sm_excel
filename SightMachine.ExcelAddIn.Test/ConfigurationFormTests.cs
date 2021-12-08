using System.Threading.Tasks;
using ExcelAddIn;
using ExcelAddIn.Exception;
using ExcelAddIn.Forms;
using NUnit.Framework;

namespace SightMachine.ExcelAddIn.Test
{
    [TestFixture]
    public class ConfigurationFormTests
    {
        private Configuration _configuration;

        [SetUp]
        public void Setup()
        {
            _configuration = new Configuration();
        }

        [TestCase]
        public void Configuration_Load_WithDefaultSettings_ShouldPass()
        {
            // Arrange
            ConfigurationSettings.Default.ApiBaseUrl = string.Empty;
            ConfigurationSettings.Default.APIKey = string.Empty;
            ConfigurationSettings.Default.APISecret = string.Empty;
            ConfigurationSettings.Default.PageSize = 10;
            ConfigurationSettings.Default.OutputDateTimeFormat = "dddd, dd MMMM yyyy hh:mm:ss tt";
            ConfigurationSettings.Default.IsApiReadyAndValidated = false;

            // Act
            _configuration.Configuration_Load(null, null);

            // Assert
            Assert.AreEqual(ConfigurationSettings.Default.ApiBaseUrl, _configuration.ApiBaseUrlTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.APIKey, _configuration.APIKeyIdTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.APISecret, _configuration.ApiSecretTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.PageSize.ToString(), _configuration.PageSizeTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.OutputDateTimeFormat, _configuration.DateTimeFormatTextBox.Text);
        }

        [TestCase]
       //[ExpectedException(typeof(ValidationException), "Please enter valid url for API BASE URL :")]
        public async Task SaveButton_Click_ShouldThrowException_WhenInvalidBaseApiUrl()
        {
            // Arrange
            ConfigurationSettings.Default.APIKey = "API KEY ID";
            ConfigurationSettings.Default.APISecret = "API SECRET KEY ID";
            ConfigurationSettings.Default.ApiBaseUrl = "some invalid api url";
            
            // Act
            _configuration.Configuration_Load(null, null);
            Assert.ThrowsAsync<ValidationException>(async () => await _configuration.SaveConfiguration());
        }

        [TestCase]
        public async Task SaveButton_Click_WithValidInput_ShouldSaveConfiguration()
        {
            // Arrange
            _configuration.APIKeyIdTextBox.Text = "c3d80723-1310-43e5-8efa-26e68a15f0cf";
            _configuration.ApiBaseUrlTextBox.Text = "https://demo-excelplugin-test-env.sightmachine.io";
            _configuration.ApiSecretTextBox.Text = "5F-Sh2Yg6X3FFDJiElDsa_D2yADtEeDPYiJk_hhVIms";
            _configuration.PageSizeTextBox.Text = "100";
            _configuration.DateTimeFormatTextBox.Text = "dddd, dd MMMM yyyy hh:mm:ss tt";

            // Act
            var result = await _configuration.SaveConfiguration();

            // Asserts
            Assert.True(result);
            Assert.AreEqual(ConfigurationSettings.Default.ApiBaseUrl, _configuration.ApiBaseUrlTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.APIKey, _configuration.APIKeyIdTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.APISecret, _configuration.ApiSecretTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.PageSize.ToString(), _configuration.PageSizeTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.OutputDateTimeFormat, _configuration.DateTimeFormatTextBox.Text);
            Assert.AreEqual(ConfigurationSettings.Default.IsApiReadyAndValidated, true);
        }

        [TestCase]
        public async Task SaveButton_Click_With_InvalidDetails_ShouldNotSaveConfiguration()
        {
            // Arrange
            _configuration.APIKeyIdTextBox.Text = "c3d80723-1310-43e5-8efa-26e68a15f0cf";
            _configuration.ApiBaseUrlTextBox.Text = "https://demo-excelplugin-test-env.sightmachine.io";
            _configuration.ApiSecretTextBox.Text = "Invalid";
            _configuration.PageSizeTextBox.Text = "100";
            _configuration.DateTimeFormatTextBox.Text = "dddd, dd MMMM yyyy hh:mm:ss tt";

            // Act
            var result = await _configuration.SaveConfiguration();

            // Asserts
            Assert.False(result);
            Assert.AreEqual(ConfigurationSettings.Default.ApiBaseUrl, string.Empty);
            Assert.AreEqual(ConfigurationSettings.Default.APIKey, string.Empty);
            Assert.AreEqual(ConfigurationSettings.Default.APISecret, string.Empty);
            Assert.AreEqual(ConfigurationSettings.Default.IsApiReadyAndValidated, false);
        }
    }
}