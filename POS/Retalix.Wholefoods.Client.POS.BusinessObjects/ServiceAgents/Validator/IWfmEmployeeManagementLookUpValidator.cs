using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Validator
{
    public interface IWfmEmployeeManagementLookUpValidator
    {
        void Validate(WfmEmployeeManagementLookUpRequest request, WfmEmployeeManagementLookUpResponse response);
    }
}
