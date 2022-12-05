using Retalix.Client.CommonServices.Utils;
using Retalix.Contracts.Generated.Arts.PosLogV6.Source;
using Retalix.Contracts.Generated.Common;
using System.ComponentModel.Composition;
using Retalix.Wholefoods.Contracts.Generated.WfmEmployeeManagement;

namespace Retalix.Wholefoods.Client.POS.BusinessObjects.ServiceAgents.WfmEmployeeManagement.Builder
{
    [Export(typeof(IWfmEmployeeManagementLookUpRequestBuilder))]

    public class WfmEmployeeManagementLookUpRequestBuilder : IWfmEmployeeManagementLookUpRequestBuilder
    {
        public WfmEmployeeManagementLookUpRequest BuildLookUpRequest(string name)
        {
            var employeeSearchCriteria = new SearchCriteriaType { Name = name };
            var wfmEmployeeManagementLookupRequest = new WfmEmployeeManagementLookUpRequest()
            {
                Header = new RetalixCommonHeaderType()
                {
                    MessageId = new RequestIDCommonData()
                    {
                        Value = MessageIdGenerator.GetId().ToString()
                    }
                },
                SearchCriteria = employeeSearchCriteria

            };
            return wfmEmployeeManagementLookupRequest;
        }
    }
}


