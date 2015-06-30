using System;
using FaultRepair.Domain.Interface.InfrastructureInterface;
using FaultRepair.Domain.Model;
using FaultRepair.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Security.Principal;
using Moq.Language.Flow;

namespace FaultRepair.Tests
{
    [TestClass]
    public class CreateWorkOrderTest
    {
        ///// <summary>
        ///// A user with <c>WorkOrderRoles.Create</c> 
        /////     role should create a <see cref="WorkOrder"/> 
        /////     with <c>WorkOrderStatus.New</c> status
        ///// </summary>
        //[TestMethod]
        //public void Given_user_with_Create_role_new_WorkOrder_should_have_NEW_Status_OLD()
        //{
        //    // arrange

        //    var mockWorkOrderFactory = new Mock<IWorkOrderFactory>();
        //    mockWorkOrderFactory.Setup(f => f.Create()).Returns(new WorkOrder());
        //    var mockPrincipal = new Mock<IPrincipal>();
        //    mockPrincipal.Setup(p => p.IsInRole(WorkOrderRoles.Create)).Returns(true);
        //    var mockRepairService = new RepairService(mockPrincipal.Object, mockWorkOrderFactory.Object);
             
        //    // act
        //    var workOrder = mockRepairService.Create();

        //    // assert
        //    Assert.AreEqual(workOrder.Status, WorkOrderStatus.New);
        //}

        /// <summary>
        /// A user with <c>WorkOrderRoles.Create</c> 
        ///     role should create a <see cref="WorkOrder"/> 
        ///     with <c>WorkOrderStatus.New</c> status
        /// </summary>
        [TestMethod]
        public void Given_user_with_Create_role_new_WorkOrder_should_have_NEW_Status()
        {
            // arrange
            var mockWorkOrderFactory = new Mock<IWorkOrderFactory>();
            mockWorkOrderFactory.Setup(f => f.Create()).Returns(new WorkOrder());
            var mockPrincipal = new Mock<IPrincipal>();
            mockPrincipal.Setup(p => p.IsInRole(WorkOrderRoles.Create)).Returns(true);
            var mockRepairService = new RepairService(mockPrincipal.Object, mockWorkOrderFactory.Object);

            // act
            var workOrder = mockRepairService.Create();

            // assert
            Assert.AreEqual(workOrder.Status, WorkOrderStatus.New);
        }
    }
}

