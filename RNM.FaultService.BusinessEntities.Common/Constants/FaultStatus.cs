using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.FaultLogging.Enums
{
    public enum FaultStatus
    {
        NotKnown = 0,
        Logged = 1,
        Verified = 2,
        VerificationInProgress = 12,
        //WorkOrdered = 3,
        //WorkScheduled = 4,
        //OnRepair = 5,
        //Completed =6
    }
}
