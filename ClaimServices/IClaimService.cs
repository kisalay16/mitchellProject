using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ClaimServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClaimService" in both code and config file together.
    [ServiceContract]
    public interface IClaimService
    {
        [OperationContract]
        claimantData SearchClaim(string Id);

        [OperationContract]
        void InsertClaim(claimantData ClaimantData);
    }
}
