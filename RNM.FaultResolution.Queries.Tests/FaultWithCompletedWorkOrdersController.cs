using System.Collections.Generic;

namespace RNM.FaultResolution.Queries.Tests
{
    public class FaultWithCompletedWorkOrdersController
    {
        private readonly IVerifiedFaultFinder iVerifiedFaultFinder;

        public FaultWithCompletedWorkOrdersController(IVerifiedFaultFinder iVerifiedFaultFinder)
        {
            this.iVerifiedFaultFinder = iVerifiedFaultFinder;
        }

        public List<FaultWithCompletedWorkOrdersDto> FindFaultWithCompletedWorkOrders(string roleName)
        {
            return iVerifiedFaultFinder.FindFaultWithCompletedWorkOrders(roleName);
        }
    }
}
