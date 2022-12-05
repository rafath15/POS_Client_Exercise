using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Builder
{
    public interface IWfmEmployeeManagementLookUpRequestBuilder
    {
        WfmEmployeeManagementLookUpRequest BuildLookUpRequest(string name);

    }
}
