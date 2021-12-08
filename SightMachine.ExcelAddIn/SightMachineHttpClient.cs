using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelAddIn.Exception;
using ExcelAddIn.Logging;
using ExcelAddIn.Models.DataTabCycle.Request;
using ExcelAddIn.Models.DataTabCycle.Response;
using ExcelAddIn.Models.MachineDetails;
using ExcelAddIn.Models.MachineType;
using Newtonsoft.Json;

namespace ExcelAddIn
{
    public class SightMachineHttpClient : ISightMachineHttpClient
    {
        private readonly HttpClient _httpClient;
        public SightMachineHttpClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(ConfigurationSettings.Default.ApiBaseUrl)
                //BaseAddress = new Uri("https://demo-excelplugin-test-env.sightmachine.io")
            };

            //_httpClient.DefaultRequestHeaders.Add("X-SM-API-Key-Id", "c3d80723-1310-43e5-8efa-26e68a15f0cf");
            //_httpClient.DefaultRequestHeaders.Add("X-SM-API-Secret", "5F-Sh2Yg6X3FFDJiElDsa_D2yADtEeDPYiJk_hhVIms");

            _httpClient.DefaultRequestHeaders.Add("X-SM-API-Key-Id", ConfigurationSettings.Default.APIKey);
            _httpClient.DefaultRequestHeaders.Add("X-SM-API-Key", ConfigurationSettings.Default.APISecret);

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        }

        /// <summary>
        /// Fetch data tab cycles HLO's
        /// </summary>
        /// <param name="dataTabCycleRequest"></param>
        /// <returns></returns>
        public async Task<DataTabCycleResponse> PostDataTabCycle(DataTabCycleRequest dataTabCycleRequest)
        {
            try
            {
                if (_httpClient.DefaultRequestHeaders.Contains("X-SM-API-Key"))
                {
                    _httpClient.DefaultRequestHeaders.Remove("X-SM-API-Key");
                }
                
                if (!_httpClient.DefaultRequestHeaders.Contains("X-SM-API-Secret"))
                {
                    _httpClient.DefaultRequestHeaders.Add("X-SM-API-Secret", ConfigurationSettings.Default.APISecret);
                }
                
                var uri = _httpClient.BaseAddress + "v1/datatab/cycle";

                var json = JsonConvert.SerializeObject(dataTabCycleRequest);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                data.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await _httpClient.PostAsync(uri, data);

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApiException($@"Fetching Machine Details API call failed : {await response.Content.ReadAsStringAsync()}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<DataTabCycleResponse>(responseContent);
            }
            catch (System.Exception exception)
            {
                LogHelper.Log($"{exception.Message} : {exception.StackTrace}");
                return null;
            }
        }

        /// <summary>
        /// Get Machine Types
        /// </summary>
        /// <returns></returns>
        public async Task<MachineTypeResponse[]> GetMachineType()
        {
            try
            {
                var uri = _httpClient.BaseAddress + "api/machinetype";
                var response = await _httpClient.GetAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApiException($@"Fetching Machine Types API call failed : {response.Content.ReadAsStringAsync()}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MachineTypeResponse[]>(responseContent);
            }
            catch (System.Exception exception)
            {
                LogHelper.Log($"{exception.Message} : {exception.StackTrace}");
                return null;
            }
        }

        /// <summary>
        /// Get Machine Details
        /// </summary>
        /// <returns></returns>
        public async Task<MachineDetailsResponse[]> GetMachineDetails(Dictionary<string, string> queryParams = null)
        {
            try
            {
                var endpoint = new StringBuilder("api/machine");
                if (queryParams?.Any() == true)
                {
                    int index = 0;
                    foreach (var param in queryParams)
                    {
                        if (index == 0)
                        {
                            endpoint.Append("?");
                        }
                        else
                        {
                            endpoint.Append("&");
                        }

                        endpoint.Append($"{param.Key}={param.Value}");
                        index++;
                    }
                }

                var uri = _httpClient.BaseAddress + endpoint.ToString();
                var response = await _httpClient.GetAsync(uri);

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApiException($@"Fetching Machine Details API call failed : {await response.Content.ReadAsStringAsync()}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<MachineDetailsResponse[]>(responseContent);
            }
            catch (System.Exception exception)
            {
                LogHelper.Log($"{exception.Message} : {exception.StackTrace}");
                return null;
            }
        }
    }
}