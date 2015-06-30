using RNM.FaultLogging.Domain.Types;

namespace RNM.FaultLogging.Application.Tests
{
    public interface  IFaulValidationService
    {
        bool FaultAlreadyCaptured(string address, FaultType faultType);
    }
}
