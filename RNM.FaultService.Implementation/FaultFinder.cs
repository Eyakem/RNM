
namespace RNM.FaultService.Implementation
{
    #region [Fields]

    using RNM.Common.Interfaces;
    using RNM.FaultLogginge.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public class FaultFinder : IFaultFinder
    {
        public FaultLogging.Domain.Fault FindByReference(string faultRef)
        {
            throw new NotImplementedException();
        }

        public List<FaultLogging.Domain.Fault> FindByLocation(ILocation location)
        {
            throw new NotImplementedException();
        }

        public List<FaultLogging.Domain.Fault> FindByCaller(FaultLogging.Domain.Caller caller)
        {
            throw new NotImplementedException();
        }
    }
}
