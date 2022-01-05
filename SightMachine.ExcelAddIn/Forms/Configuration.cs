using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelAddIn.Exception;
using ExcelAddIn.Helper;

namespace ExcelAddIn.Forms
{
    public partial class Configuration : Form
    {
        public const string Https = "https://";
        public const string SightMachineUrlSuffix = ".sightmachine.io";

        public Configuration()
        {
            InitializeComponent();
        }

        internal void Configuration_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Cursor = Cursors.Default;
            ApiBaseUrlTextBox.Text = ConfigurationSettings.Default.ApiBaseUrl;
            APIKeyIdTextBox.Text = ConfigurationSettings.Default.APIKey;
            ApiSecretTextBox.Text = ConfigurationSettings.Default.APISecret;
            PageSizeTextBox.Text = ConfigurationSettings.Default.PageSize.ToString();
            DateTimeFormatTextBox.Text = ConfigurationSettings.Default.OutputDateTimeFormat;
        }

        internal async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Application.UseWaitCursor = true;
                SaveButton.Enabled = false;
                var saved = await SaveConfiguration();
                if (saved)
                {
                    MessageBox.Show($@"Connection Successful!!!", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show($@"Could not able to authenticate!!!! Please fix the inputs and try again..",
                        @"Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ValidationException validationException)
            {
                MessageBox.Show(validationException.Message, @"Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (System.Exception exception)
            {
                MessageBox.Show(exception.Message, @"Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SaveButton.Enabled = true;
            Application.UseWaitCursor = false;
        }

        internal async Task<bool> SaveConfiguration()
        {
            // Validate input
            Validator.HandleNullOrWhiteSpaceRequired(ApiBaseUrlTextBox, ApiBaseUrlLabel.Text);
            Validator.HandleNullOrWhiteSpaceRequired(APIKeyIdTextBox, APIKeyIdLabel.Text);
            Validator.HandleNullOrWhiteSpaceRequired(ApiSecretTextBox, ApiSecretLabel.Text);

            string fullUrl = string.Empty;
            if (!ApiBaseUrlTextBox.Text.ToLower().StartsWith("https"))
            {
                fullUrl = Https;
            }

            if (!ApiBaseUrlTextBox.Text.ToLower().EndsWith($"{SightMachineUrlSuffix.ToLower()}"))
            {
                fullUrl = fullUrl + ApiBaseUrlTextBox.Text + SightMachineUrlSuffix;
            }

            if (string.IsNullOrWhiteSpace(fullUrl))
            {
                fullUrl = ApiBaseUrlTextBox.Text;
            }

            var result = Uri.TryCreate(fullUrl, UriKind.Absolute, out var uriResult)
                         && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!result)
            {
                throw new ValidationException($@"Please enter valid url for {ApiBaseUrlLabel.Text}");
            }

            // Save values into configuration
            ConfigurationSettings.Default.ApiBaseUrl = fullUrl;
            ConfigurationSettings.Default.APIKey = APIKeyIdTextBox.Text;
            ConfigurationSettings.Default.APISecret = ApiSecretTextBox.Text;
            ConfigurationSettings.Default.IsApiReadyAndValidated = true;
            int.TryParse(PageSizeTextBox.Text, out var defaultPageSize);
            ConfigurationSettings.Default.PageSize = defaultPageSize == 0 ? 40 : defaultPageSize;
            ConfigurationSettings.Default.OutputDateTimeFormat = DateTimeFormatTextBox.Text;
            ConfigurationSettings.Default.Save();

            // Make api call to ensure input values are correct
            ISightMachineHttpClient sightMachineHttpClient = new SightMachineHttpClient();
            var response = await sightMachineHttpClient.GetMachineDetails();

            if (response == null)
            {
                ConfigurationSettings.Default.ApiBaseUrl = string.Empty;
                ConfigurationSettings.Default.APIKey = string.Empty;
                ConfigurationSettings.Default.APISecret = string.Empty;
                ConfigurationSettings.Default.IsApiReadyAndValidated = false;
                ConfigurationSettings.Default.Save();
                return false;
            }

            return true;
        }

        internal void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
