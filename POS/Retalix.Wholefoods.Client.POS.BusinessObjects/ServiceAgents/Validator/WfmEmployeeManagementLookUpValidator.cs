using Retalix.Client.POS.BusinessObjects.ServiceAgents.Validations;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Validator
{
    [Export(typeof(IWfmEmployeeManagementLookUpValidator))]
    public class WfmEmployeeManagementLookUpValidator : RetalixValidatorBase, IWfmEmployeeManagementLookUpValidator
    {
        public void Validate(WfmEmployeeManagementLookUpRequest request, WfmEmployeeManagementLookUpResponse response)
        {
            ValidateResponseError(response.Header);
        }
    }
}

