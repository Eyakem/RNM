using RNM.Common.Interfaces;
using RNM.FaultLogginge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.FaultService.Implementation
{
    public class FaultLogger : IFaultLogger
    {
        private IFaultRepository faultRepository;

        public FaultLogger(IFaultRepository faultRepository)
        {
            this.faultRepository = faultRepository;
        }
        
        public void Save(FaultLogging.Domain.Fault fault)
        {
            faultRepository.Save(fault);
        }
    }
}
