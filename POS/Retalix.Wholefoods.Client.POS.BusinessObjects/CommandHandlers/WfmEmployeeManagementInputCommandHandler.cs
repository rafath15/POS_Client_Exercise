using Retalix.Client.POS.BusinessObjects.CommandHandlers;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IWfmEmployeeManagementInputCommandHandler))]
    public class WfmEmployeeManagementInputCommandHandler : PosCommandHandlerBase, IWfmEmployeeManagementInputCommandHandler
    {
        private const string WfmEmployeeManagementInputOutcome = "WfmEmployeeManagementInputOutcome";

        protected override string ExecuteLogic()
        {
            return WfmEmployeeManagementInputOutcome;
        }

    }
}