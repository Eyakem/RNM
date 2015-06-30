
namespace RNM.FaultLogginge.Interfaces
{

    #region [Namespace]

    using RNM.FaultLogging.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public interface IFaultLogger
    {
        //this method will persist the fault & 
        //  call ReferenceNumberGenerator to update fault reference property
        //  re-save
        void Save(Fault fault);
    }
}
