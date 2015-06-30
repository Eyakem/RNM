using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RNM.FaultResolution.Domain.Models;
using Shouldly;

namespace RNM.FaultResolution.Domain.Tests
{

    [TestClass]
    public class When_creating_new_issued_work_order
    {
       
        [TestInitialize]
        public void Initialise()
        {
            
        }
        [TestMethod]
        public void A_new_issued_work_order_should_be_created()
        {
            var newIssuedWorkOrder =  CompletedWorkOrder.CreateNewIssuedWorkOrder(Guid.NewGuid());
            newIssuedWorkOrder.Status.ShouldBe(WorkOrderStatus.Issued);
        }
    }
    
}
