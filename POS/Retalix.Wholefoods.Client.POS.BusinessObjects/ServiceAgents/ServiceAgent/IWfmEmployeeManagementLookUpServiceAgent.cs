using Retalix.Client.Common.ServiceAgents;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.ServiceAgent
{
    public interface IWfmEmployeeManagementLookUpServiceAgent : IServiceAgent
    {
        WfmEmployeeManagementLookUpResponse Execute(string name);
    }
}

