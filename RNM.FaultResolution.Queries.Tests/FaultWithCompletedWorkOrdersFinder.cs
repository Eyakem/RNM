using System;
using System.Collections.Generic;

namespace RNM.FaultResolution.Queries.Tests
{
    public class FaultWithCompletedWorkOrdersFinder :IVerifiedFaultFinder
    {
        public List<FaultWithCompletedWorkOrdersDto> FindFaultWithCompletedWorkOrders(string roleName)
        {
            if (roleName != "Supervisor")
                throw new UnAuthorizedException("You are not authorised to use this functionality.");

            return new List<FaultWithCompletedWorkOrdersDto>
            {
                new FaultWithCompletedWorkOrdersDto{Id = new Guid(),Address ="12 Biko Sttreet",ReferenceNumber ="1234"}
            };
        }
    }

    public interface IVerifiedFaultFinder
    {
        List<FaultWithCompletedWorkOrdersDto> FindFaultWithCompletedWorkOrders(string roleName);
    }
}
