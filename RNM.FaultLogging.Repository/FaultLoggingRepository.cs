using RNM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.FaultLogging.Repository
{
    public class FaultLoggingRepository : IFaultRepository
    {
        public void Save(IFault fault)
        {
            throw new NotImplementedException("interaction with data storage (database), save the fault to db.");
        }

        public void Update(IFault fault)
        {
            throw new NotImplementedException();
        }
    }
}
