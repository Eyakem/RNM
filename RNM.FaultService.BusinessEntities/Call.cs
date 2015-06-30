using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.FaultLogging.Domain
{
    /// <summary>
    /// The call and the person who called to log the call
    /// </summary>
    public class Call
    {
        //reference to the caller
        private Caller caller;

        public Caller Caller
        {
            get { return this.caller; }
            set {this. caller = value; }
        }        
    }
}
