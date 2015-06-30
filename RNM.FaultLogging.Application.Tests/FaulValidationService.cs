using System;
using RNM.FaultLogging.Domain.Types;

namespace RNM.FaultLogging.Application.Tests
{
    public class FaulValidationService:IFaulValidationService
    {
        //inject repository here

        public bool FaultAlreadyCaptured(string address, FaultType faultType)
        {
            return false;
        }
    }
}
