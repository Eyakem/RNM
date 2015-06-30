using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Shouldly;

namespace RNM.FaultResolution.Queries.Tests
{
    [TestClass]
    public class When_filtering_faults_with_completed_work_orders : FaultWithCompletedWorkOrdersSpecifications
    {
        private IVerifiedFaultFinder mockVerifiedFaultFinder;
        private FaultWithCompletedWorkOrdersController verifiedFaultController;
        private List<FaultWithCompletedWorkOrdersDto> verifiedFaultsWithCompletedWorkOrders;
        [TestInitialize]
        public void Initialise()
        {
            mockVerifiedFaultFinder = MockRepository.GenerateMock<IVerifiedFaultFinder>();
            verifiedFaultController = new FaultWithCompletedWorkOrdersController(mockVerifiedFaultFinder);
        }

        [TestMethod]
        public void Given_i_have_logged_in_as_a_supervisor_then_the_system_should_display_a_list_of_completed_work_orders()
        {
            mockVerifiedFaultFinder.Stub(verifiedFaultFinder => verifiedFaultFinder.FindFaultWithCompletedWorkOrders(""))
                .IgnoreArguments()
                .Return(Faults_with_completed_work_orders);
            verifiedFaultsWithCompletedWorkOrders = verifiedFaultController.FindFaultWithCompletedWorkOrders("");
            verifiedFaultsWithCompletedWorkOrders.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void Given_i_have_logged_in_as_a_supervisor_then_the_system_should_display_no_results_if_there_are_no_completed_work_orders()
        {
            mockVerifiedFaultFinder.Stub(verifiedFaultFinder => verifiedFaultFinder.FindFaultWithCompletedWorkOrders(""))
                .IgnoreArguments()
                .Return(No_faults_with_completed_work_orders);
            verifiedFaultsWithCompletedWorkOrders = verifiedFaultController.FindFaultWithCompletedWorkOrders("");
            verifiedFaultsWithCompletedWorkOrders.Count.ShouldBe(0);
        }

        [TestMethod]
        [ExpectedException(typeof(UnAuthorizedException))]
        public void Given_i_have_logged_in_as_a_normal_user_then_the_system_should_display_an_error_message()
        {
            mockVerifiedFaultFinder.Stub(verifiedFaultFinder => verifiedFaultFinder.FindFaultWithCompletedWorkOrders(""))
                .IgnoreArguments()
                .Throw(new UnAuthorizedException("You are not authorized to use this functionality."));
            var faultWithCompletedWorkOrders = verifiedFaultController.FindFaultWithCompletedWorkOrders("");
        }
    }
}

