using System;
using System.Collections.Generic;
using RNM.SharedKernel.Domain.Core.Events;

using RNM.FaultResolution.Domain.ValueObjects;

namespace RNM.FaultResolution.Domain.Models
{
    public class FaultWithCompletedWorkOrder
    {
        public Guid Id { get; private set; }
        public FaultStatus FaultStatus { get; private set; }
        public List<CompletedWorkOrder> CompletedWorkOrders { get; private set; }

        public void CloseFault()
        {
            DomainEvents.Raise(new FaultClosed(Id));
        }

        public void Handle(FaultClosed args)
        {
            FaultStatus = FaultStatus.Closed;
        }
    }
    
    public class FaultClosed : IDomainEvent
    {
        public Guid Id { get; set; }

        public FaultClosed(Guid id)
        {
            this.Id = id;
        }
    }
   
    

  

  
}
