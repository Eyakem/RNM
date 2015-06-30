using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNM.SharedKernel
{
    public class InvalidModelException : Exception
    {
        public InvalidModelException(string message) : base(message)
        {
            
        }
    }
}
