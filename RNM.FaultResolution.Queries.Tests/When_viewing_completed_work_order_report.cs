using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Shouldly;


namespace RNM.FaultResolution.Queries.Tests
{
    [TestClass]
    public class When_viewing_completed_work_order_report : CompletedTask
    {
        private CompletedTaskController completedTaskController;
        private ICompletedTaskFinder mockCompletedTaskFinder;
        private List<CompletedTaskDto> completedTasks;

        [TestInitialize]
        public void Initialise()
        {
            mockCompletedTaskFinder = MockRepository.GenerateMock<ICompletedTaskFinder>();
            completedTaskController = new CompletedTaskController(mockCompletedTaskFinder);
            completedTasks = completedTaskController.FindCompletedTasksByWorkOrder(1, "Supervisor");
        }
        [TestMethod]
        public void Given_i_have_logged_in_as_a_supervisor_then_the_actual_work_done_on_task_by_task_should_be_displayed()
        {
            mockCompletedTaskFinder.Stub(completedTask => completedTask.FindCompletedTasksByWorkOrder(0, ""))
                .IgnoreArguments()
                .Return(Completed_tasks_with_results);
            completedTasks = completedTaskController.FindCompletedTasksByWorkOrder(1, "Supervisor");
            completedTasks.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void Given_i_have_logged_in_as_a_supervisor_then_the_actual_work_done_on_task_by_task_should_display_no_results_if_there_are_no_tasks_added_yet()
        {
            mockCompletedTaskFinder.Stub(completedTask => completedTask.FindCompletedTasksByWorkOrder(0, ""))
                .IgnoreArguments()
                .Return(No_completed_tasks);
            completedTasks = completedTaskController.FindCompletedTasksByWorkOrder(1, "Supervisor");
            completedTasks.Count.ShouldBe(0);
        }

        [TestMethod]
        [ExpectedException(typeof(UnAuthorizedException))]
        public void Given_i_have_logged_in_as_a_normal_user_then_an_error_message_should_be_displayed()
        {
            mockCompletedTaskFinder.Stub(completedTask => completedTask.FindCompletedTasksByWorkOrder(1, ""))
                .IgnoreArguments().Throw(new UnAuthorizedException("error"));
            completedTasks = completedTaskController.FindCompletedTasksByWorkOrder(1, "");
        }
    }
}

