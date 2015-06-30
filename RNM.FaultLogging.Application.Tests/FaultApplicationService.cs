using RNM.FaultLogging.Domain.Exceptions;
using RNM.FaultLogging.Domain.Models;
using RNM.FaultLogging.Domain.Types;

namespace RNM.FaultLogging.Application.Tests
{
    public class FaultApplicationService
    {
        private readonly IFaulValidationService iFaulValidationService;

        public FaultApplicationService(IFaulValidationService iFaulValidationService)
        {
            this.iFaulValidationService = iFaulValidationService;
        }

        public string CreateNewFault(string role,string address, FaultType faultType)
        {
            if (iFaulValidationService.FaultAlreadyCaptured(address, faultType))
                throw new DomainException("Fault has already been captured");
            var fault = Fault.CaptureFault(role, address, faultType);
           
            //Commit to database
            
            return fault.ReferenceNumber;
        }
    }

} 
