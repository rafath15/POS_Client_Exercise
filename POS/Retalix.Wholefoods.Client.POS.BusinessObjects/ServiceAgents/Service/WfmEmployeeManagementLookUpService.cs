using Retalix.Client.Net;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Service
{
    [Export(typeof(IWfmEmployeeManagementLookUpService))]
    public class WfmEmployeeManagementLookUpService : ServiceBase, IWfmEmployeeManagementLookUpService
    {
        private const string ServiceName = "WfmEmployeeManagementLookUp";
        public WfmEmployeeManagementLookUpResponse Execute(WfmEmployeeManagementLookUpRequest request)
        {
            return Execute<WfmEmployeeManagementLookUpRequest, WfmEmployeeManagementLookUpResponse>(request, ServiceName);
        }
    }
}
