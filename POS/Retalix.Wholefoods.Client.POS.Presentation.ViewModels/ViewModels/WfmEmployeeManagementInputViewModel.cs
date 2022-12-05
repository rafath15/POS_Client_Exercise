using Retalix.Client.POS.Presentation.ViewModels.ViewModels;
using Retalix.Client.Presentation.Core.Command;
using Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces;
using Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;
using System.Collections.Generic;
using System.Windows.Input;
using Retalix.Client.POS.BusinessObjects.Models;

namespace Retalix.Wholefoods.Client.POS.Presentation.ViewModels.ViewModels
{
    public class WfmEmployeeManagementInputViewModel : PosViewModelBase
    {
        public ICommand GetEmployeeManagementCommand { get; private set; }
        public ICommand BackCommand { get; private set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public WfmEmployeeManagementInputViewModel()
        {
            Init();
        }
        private void Init()
        {
            InitCommands();
        }

        private void InitCommands()
        {
            GetEmployeeManagementCommand = new CommandAction<object>(ExecuteGetCommand, CanExecuteGetCommand);
            BackCommand = new CommandAction<object>(ExecuteBackCommand, x => true);
        }
        private bool CanExecuteGetCommand(object obj)
        {
            return !string.IsNullOrWhiteSpace(Name);
        }
        protected virtual void ExecuteGetCommand(object obj)
        {
            ExecuteWfmEmployeeManagementLookUpCommandHandler(Name);
        }

        protected virtual void ExecuteBackCommand(object obj)
        {
            ExecuteBackCommandHandler();
        }
        protected virtual void ExecuteWfmEmployeeManagementLookUpCommandHandler(string name)
        {
            var command = CommandHandlerFactory.Create<IWfmEmployeeManagementLookUpCommandHandler>();
            command.Init(name);
            ExecuteCommandHandlerAndStartFlow(command);
        }
        protected virtual void ExecuteBackCommandHandler()
        {
            var command = CommandHandlerFactory.Create<IWfmEmployeeManagementBackCommandHandler>();
            ExecuteCommandHandlerAndStartFlow(command);
        }
    }
}
