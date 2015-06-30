using Microsoft.VisualStudio.TestTools.UnitTesting;
using RNM.FaultResolution.Domain.Models;
using RNM.FaultResolution.Domain.ValueObjects;
using RNM.SharedKernel.Domain.Core.Events;

using Shouldly;

namespace RNM.FaultResolution.Domain.Tests
{
    [TestClass]
    public class When_i_sign_off_a_work_order
    {
       [TestMethod]
        public void Given_i_have_logged_in_as_a_supervisor_then_the_fault_should_be_closed_and_the_work_order_should_be_marked_as_unsatisfactory()
        {
            var faultWithCompletedWorkOrder = new FaultWithCompletedWorkOrder();
            DomainEvents.Register<FaultClosed>(faultWithCompletedWorkOrder.Handle);
            var completedWorkOrder = new CompletedWorkOrder();
            DomainEvents.Register<WorkOrderMarkedAsSatisfactory>(completedWorkOrder.Handle);
            
            completedWorkOrder.SignOff(faultWithCompletedWorkOrder);
            completedWorkOrder.IsSatisfactory.ShouldBe(true);
            faultWithCompletedWorkOrder.FaultStatus.ShouldBe(FaultStatus.Closed);
        }
    }
}
