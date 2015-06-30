using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RNM.FaultLogging.Domain.Exceptions;
using Shouldly;

namespace RNM.FaultLogging.Domain.Tests
{
    [TestClass]
    public class When_capturing_a_new_fault
    {
        [TestMethod]
        public void Given_i_have_logged_in_as_a_call_centre_agent_then_the_system_should_create_a_new_fault()
        {
            var fault = Fault.CaptureFault(Guid.NewGuid(), "Agent", "Drainage", "22 Biko Street");
            fault.ReferenceNumber.Length.ShouldNotBe(0);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void Given_i_have_logged_in_as_a_call_centre_agent_and_fault_already_exists_then_the_system_should_not_create_a_new_fault()
        {
            var fault = Fault.CaptureFault(Guid.NewGuid(), "Agent", "pothole","21 Biko Street");
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void Given_i_have_logged_in_as_a_normal_user_then_the_system_should_not_create_a_new_fault()
        {
            var fault = Fault.CaptureFault(Guid.NewGuid(), "Normal", "Drainage", "22 Biko Street");
        }

    }
}
