using Retalix.Client.Common.Handlers;
using Retalix.Client.POS.BusinessObjects.Factory;
using Retalix.Client.Presentation.Core.ViewModels;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using System.ComponentModel.Composition;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlers
{
    [Export(typeof(IExtendedCommand))]
    public class WfmEmployeeManagementExtendedCommand : IExtendedCommand
    {
        private const string WfmEmployeeManagementCommandName = "WfmEmployeeManagement";

        [Import]
        private ICommandHandlerFactory _commandHandlerFactory;
        public string CommandName { get { return WfmEmployeeManagementCommandName; } }

        public ICommandHandler GetCommandHandler(ViewModelBase viewModel)
        {
            var commandHandler = _commandHandlerFactory.Create<IWfmEmployeeManagementInputCommandHandler>();
            return commandHandler;
        }

    }
}
