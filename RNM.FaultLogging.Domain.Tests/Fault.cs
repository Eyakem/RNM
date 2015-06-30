using System;
using RNM.FaultLogging.Domain.Exceptions;

namespace RNM.FaultLogging.Domain.Tests
{
    public class Fault
    {
        public Guid FaultId { get; private set; }
        public string ReferenceNumber { get; private set; }
        public string FaultType { get; private set; }
        public string Address { get; private set; }
        public static Fault CaptureFault(Guid faultId, string role, string faultType,string address)
        {
            if (role != "Agent")
                throw new DomainException("User is not supposed to create a new fault.");

            return new Fault()
            {
                FaultId = faultId,
                ReferenceNumber = GenerateReferenceNumber(),
                FaultType = faultType,
                Address = address
            };
        }

         
        private static bool FaultAlreadyExists(string faultType, string address)
        {
            var storedFaultType = "pothole";
            var storedAddress = "21 Biko Street";
            return (faultType == storedFaultType && address == storedAddress);
        }

        private static string GenerateReferenceNumber()
        {
            var ticks = DateTime.Now.Ticks.ToString();
            return ticks.Substring(ticks.Length - 10); ;
        }
    }

    
}
