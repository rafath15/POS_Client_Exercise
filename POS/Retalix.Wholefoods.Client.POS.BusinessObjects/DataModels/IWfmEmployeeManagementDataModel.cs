using Retalix.Client.Common.DataModels;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.DataModels
{
    public interface IWfmEmployeeManagementDataModel : IDataModel
    {
        WfmEmployeeManagementLookUpResponse wfmEmployeeManagementLookUpResponse { get; set; }
    }
}
