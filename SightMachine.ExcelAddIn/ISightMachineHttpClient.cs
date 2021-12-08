using System.Collections.Generic;
using System.Threading.Tasks;
using ExcelAddIn.Models.DataTabCycle.Request;
using ExcelAddIn.Models.DataTabCycle.Response;
using ExcelAddIn.Models.MachineDetails;
using ExcelAddIn.Models.MachineType;

namespace ExcelAddIn
{
    public interface ISightMachineHttpClient
    {
        Task<DataTabCycleResponse> PostDataTabCycle(DataTabCycleRequest dataTabCycleRequest);
        Task<MachineTypeResponse[]> GetMachineType();
        Task<MachineDetailsResponse[]> GetMachineDetails(Dictionary<string, string> queryParams = null);
    }
}