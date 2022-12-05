using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IWfmEmployeeManagementBackCommandHandler))]

    public class WfmEmployeeManagementBackCommandHandler : PosCommandHandlerBase, IWfmEmployeeManagementBackCommandHandler
    {
        private const string WfmEmployeeManagementOutcome = "WfmEmployeeManagementBackOutcome";

        protected override string ExecuteLogic()
        {
            return WfmEmployeeManagementOutcome;
        }

    }
}