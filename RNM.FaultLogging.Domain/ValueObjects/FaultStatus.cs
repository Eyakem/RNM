using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.FaultLogging.Domain.ValueObjects
{
    public enum FaultStatusType
    {
        Closed,
        InProgress
    }

    public class FaultStatus
    {
        public FaultStatusType Status { get; private set; }

        public FaultStatus(FaultStatusType faultStatusType)
        {
            Status = faultStatusType;
        }
    }
}
