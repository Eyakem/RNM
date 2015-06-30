using System;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RNM.FaultLogging.Application.Tests
{
    [TestClass]
    public class When_capturing_a_new_fault
    {
        [TestMethod]
        public void Given_i_have_logged_in_as_a_call_centre_agent_then_the_system_should_create_a_new_fault()
        {
            IFaulValidationService iFaulValidationService = new FaulValidationService();
            FaultApplicationService service = new FaultApplicationService(iFaulValidationService);
            var referenceId = service.CreateNewFault("12", 23);
        }
    }
}
