using Retalix.Client.POS.Presentation.ViewModels.ViewModels;
using Retalix.Client.Presentation.Core.Command;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;
using System.Collections.Generic;
using System.Windows.Input;

namespace Retalix.Wholefoods.Client.POS.Presentation.ViewModels.ViewModels
{
    public class WfmEmployeeManagementViewModel : PosViewModelBase
    {
        private IWfmEmployeeManagementDataModel _wfmEmployeeManagementDataModel;
        public ICommand BackCommand { get; private set; }

        private IList<EmployeeManagementType> _employeeManagement;
        public IList<EmployeeManagementType> employeeManagement
        {
            get { return _employeeManagement; }
            set
            {
                _employeeManagement = value;
            }
        }

        public WfmEmployeeManagementViewModel()
        {
            Init();
            InitCommands();
        }
        private void Init()
        {
            _wfmEmployeeManagementDataModel = _dataModelProvider.GetDataModel<IWfmEmployeeManagementDataModel>();
            employeeManagement = _wfmEmployeeManagementDataModel.wfmEmployeeManagementLookUpResponse.EmployeeManagement;
        }

        private void InitCommands()
        {
            BackCommand = new CommandAction<object>(ExecuteBackCommand, x => true);

        }

        protected virtual void ExecuteBackCommand(object obj)
        {

            ExecuteBackCommandHandler();
        }

        protected virtual void ExecuteBackCommandHandler()
        {
            var command = CommandHandlerFactory.Create<IWfmEmployeeManagementBackCommandHandler>();
            ExecuteCommandHandlerAndStartFlow(command);
        }
    }
}
