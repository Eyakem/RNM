using System;

namespace RNM.FaultResolution.Application.Services
{
    public class UnAuthorizedException : Exception
    {
        public UnAuthorizedException(string message) : base(message)
        {
            
        }
    }
}
