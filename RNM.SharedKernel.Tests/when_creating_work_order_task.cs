using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RNM.SharedKernel;
using Shouldly;

namespace RNM.SharedKernel.Tests
{
    [TestClass]
    public class when_creating_work_order_task
    {
        const string defaultDescriprion = "add concreate"; 
        [TestMethod]
        [ExpectedException(typeof(InvalidModelException))]
        public void Given_a_description_is_empty_a_work_order_task_should_not_be_created()
        {
            var task = WorkOrderTask.CreateNew(Guid.NewGuid(),string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidModelException))]
        public void Given_a_work_order_id_is_empty_a_work_order_task_should_not_be_created()
        {
            var task = WorkOrderTask.CreateNew(Guid.Empty, defaultDescriprion);
        }

        [TestMethod]
        public void Given_a_work_order_id_and_description_are_not_empty_a_work_order_task_should_be_created()
        {
            var workOrderId = Guid.NewGuid();
            var task = WorkOrderTask.CreateNew(workOrderId, defaultDescriprion);
            task.WorkOrderId.ShouldBe(workOrderId);
            task.Description.ShouldBe(defaultDescriprion);
            task.Id.ShouldNotBe(Guid.Empty);
        }
    }

}
