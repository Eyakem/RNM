using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNM.FaultResolution.Queries.Tests
{
    public class UnAuthorizedException : Exception
    {
        public UnAuthorizedException(string message) : base(message)
        {
            
        }
    }
}
