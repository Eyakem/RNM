using System;
using RNM.FaultLogging.Domain.Exceptions;
using RNM.FaultLogging.Domain.Types;

namespace RNM.FaultLogging.Domain.Models
{
    public class Fault
    {
        public Guid FaultId { get; private set; }
        public string ReferenceNumber { get; private set; }
        public FaultType FaultType { get; private set; }
        public string Address { get; private set; }
        
        public static Fault CaptureFault(string role, string address, FaultType faultType)
        {
            if (role != "Agent")
                throw new DomainException("User is not supposed to create a new fault.");

            return new Fault()
            {
                FaultId = new Guid(),
                ReferenceNumber = GenerateReferenceNumber(),
                FaultType = faultType,
                Address = address
            };
        }
       

        private static string GenerateReferenceNumber()
        {
            var ticks = DateTime.Now.Ticks.ToString();
            return ticks.Substring(ticks.Length - 10); ;
        }
    }

    
}
