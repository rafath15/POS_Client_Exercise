using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Service
{
    public interface IWfmEmployeeManagementLookUpService
    {
        WfmEmployeeManagementLookUpResponse Execute(WfmEmployeeManagementLookUpRequest request);
    }
}

