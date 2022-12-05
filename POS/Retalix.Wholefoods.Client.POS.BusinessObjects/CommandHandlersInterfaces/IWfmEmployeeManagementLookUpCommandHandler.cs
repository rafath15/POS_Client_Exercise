using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Retalix.Client.Common.Handlers;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.CommandHandlersInterfaces
{
    public interface IWfmEmployeeManagementLookUpCommandHandler : ICommandHandler
    {
        void Init(string name);
    }
}