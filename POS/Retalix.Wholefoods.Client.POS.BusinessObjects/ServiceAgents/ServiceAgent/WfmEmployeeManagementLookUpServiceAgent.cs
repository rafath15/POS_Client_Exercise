using Retalix.Client.Common.ServiceAgents;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Builder;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Service;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Validator;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.ServiceAgent
{
    [Export(typeof(IServiceAgent))]
    public class WfmEmployeeManagementLookUpServiceAgent : IWfmEmployeeManagementLookUpServiceAgent
    {
        [Import]
        private IWfmEmployeeManagementLookUpService _wfmEmployeeManagementLookUpService;

        [Import]
        private IWfmEmployeeManagementLookUpValidator _wfmEmployeeManagementLookUpValidator;

        [Import]
        private IWfmEmployeeManagementLookUpRequestBuilder _wfmEmployeeManagementLookUpRequestBuilder;


        public WfmEmployeeManagementLookUpResponse Execute(string name)
        {
            var wfmEmployeeManagementLookUpRequest = _wfmEmployeeManagementLookUpRequestBuilder.BuildLookUpRequest(name);
            var wfmEmployeeManagementLookUpResponse = _wfmEmployeeManagementLookUpService.Execute(wfmEmployeeManagementLookUpRequest);
            _wfmEmployeeManagementLookUpValidator.Validate(wfmEmployeeManagementLookUpRequest, wfmEmployeeManagementLookUpResponse);
            // ClientLog.ClientBusinessFlows.Debug("Test Log {0}", new BusinessException());
            return wfmEmployeeManagementLookUpResponse;
        }
    }
}
