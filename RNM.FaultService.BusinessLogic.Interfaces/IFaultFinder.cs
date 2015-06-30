
namespace RNM.FaultLogginge.Interfaces
{
    #region [Namespace]

    using RNM.Common.Interfaces;
    using RNM.FaultLogging.Domain;
    using RNM.FaultLogging.Enums;
    using System;
    using System.Collections.Generic;

    #endregion

    public interface IFaultFinder
    {
        Fault FindByReference(string faultRef);
        List<Fault> FindByLocation(ILocation location);
        List<Fault> FindByCaller(Caller caller);
    }
}
