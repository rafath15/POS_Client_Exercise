using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels;
using Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.ServiceAgent;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IWfmEmployeeManagementLookUpCommandHandler))]

    public class WfmEmployeeManagementLookupCommandHandler : PosCommandHandlerBase, IWfmEmployeeManagementLookUpCommandHandler
    {
        private string _name;
        private const string WfmEmployeeManagementLookupOutcome = "WfmEmployeeManagementLookupOutcome";

        public void Init(string name)
        {
            _name = name;
        }

        protected override string ExecuteLogic()
        {
            var wfmEmployeeManagementLookupResponse = ExecuteEmployeeManagementLookupServiceAgent();
            SetupWfmEmployeeManagementDataModel(wfmEmployeeManagementLookupResponse);
            return WfmEmployeeManagementLookupOutcome;
        }
        private void SetupWfmEmployeeManagementDataModel(WfmEmployeeManagementLookUpResponse wfmEmployeeManagementLookUpResponse)
        {
            var wfmEmployeeManagementDataModel = GetDataModel<IWfmEmployeeManagementDataModel>();
            wfmEmployeeManagementDataModel.wfmEmployeeManagementLookUpResponse = wfmEmployeeManagementLookUpResponse;
        }
        private WfmEmployeeManagementLookUpResponse ExecuteEmployeeManagementLookupServiceAgent()
        {
            var employeeManagementLookupServiceAgent = GetServiceAgent<IWfmEmployeeManagementLookUpServiceAgent>();
            return employeeManagementLookupServiceAgent.Execute(_name);
        }
    }
}
