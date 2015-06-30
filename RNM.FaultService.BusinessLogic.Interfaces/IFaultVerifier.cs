
namespace RNM.FaultService.Interfaces
{
    #region [Fields]

    using RNM.FaultLogging.Domain;
    using System;

    #endregion

    public interface IFaultVerifier
    {
        void Verify(Fault fault);
    }
}
