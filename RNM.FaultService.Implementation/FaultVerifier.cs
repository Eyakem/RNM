using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RNM.Common.Interfaces;
using RNM.FaultLogging.Domain;
using RNM.FaultService.Interfaces;

namespace RNM.FaultService.Implementation
{
    public class FaultVerifier : IFaultVerifier
    {
        private IFaultRepository faultRepository;

        public FaultVerifier(IFaultRepository faultRepository)
        {
            this.faultRepository = faultRepository;
        }

        public void Verify(Fault fault)
        {
            faultRepository.Update(fault);
        }
    }
}
