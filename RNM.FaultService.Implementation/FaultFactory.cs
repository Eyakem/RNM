namespace RNM.FaultService.Implementation
{
    #region [Fields]

    using RNM.FaultLogging.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public class FaultFactory
    {
        public Fault Create()
        {
            return new Fault();
        }
    }
}
