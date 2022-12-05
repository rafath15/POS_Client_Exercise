using Retalix.Client.Common.DataModels;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels
{
    [Export(typeof(IDataModel))]
    public class WfmEmployeeManagementDataModel : IWfmEmployeeManagementDataModel
    {
        public WfmEmployeeManagementLookUpResponse wfmEmployeeManagementLookUpResponse { get; set; }

        public void Clear()
        {
            wfmEmployeeManagementLookUpResponse = null;
        }

    }
}
