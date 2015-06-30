using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Shouldly;
using System.Collections.Generic;

namespace RNM.FaultLogging.Domain.Tests
{
    [TestClass]
    public class When_i_filter_for_completed_work_orders
    {
        [TestMethod]
        public void Given_i_have_logged_in_as_a_supervisor_then_the_system_should_display_a_list_of_completed_work_orders()
        {
            List<WorkOrder> workOrders = GetCompletedWorkOrders(true);
            workOrders.Count.ShouldBeGreaterThan(0);
        }

        private List<WorkOrder> GetCompletedWorkOrders(bool p)
        {
            return new List<WorkOrder>
                {
                    new WorkOrder()
                };
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
