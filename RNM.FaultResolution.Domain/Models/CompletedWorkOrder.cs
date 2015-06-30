using System;
using RNM.SharedKernel.Domain.Core.Events;

namespace RNM.FaultResolution.Domain.Models
{

    //shud be created by a repair team  when they complete the work order
    public class CompletedWorkOrder
    {
        public Guid Id { get; private set; }
        public Guid FaultId { get; private set; } // use this Id to get the fault
        public bool IsSatisfactory { get; private set; }
        public WorkOrderStatus Status { get; private set; }

        
        public static CompletedWorkOrder CreateNewIssuedWorkOrder(Guid id)
        {
            return new CompletedWorkOrder
            {
                Id = id,
                Status = WorkOrderStatus.Issued
            };
        }


        public void SignOff(FaultWithCompletedWorkOrder fault)
        {
            DomainEvents.Raise(new WorkOrderMarkedAsSatisfactory(Id, true));
            fault.CloseFault();
        }

        public void Handle(WorkOrderMarkedAsSatisfactory args)
        {
            IsSatisfactory = true; 
        }
    }

    public class WorkOrderMarkedAsSatisfactory : IDomainEvent
    {
        public bool IsSatisfactory { get; private set; }
        public Guid Id { get; set; } // this should be applied on the Aggregateroot base class when applying event fs fine hereor prototyping i

        public WorkOrderMarkedAsSatisfactory(Guid id, bool isSatisfactory)
        {
            Id = id;
            IsSatisfactory = isSatisfactory;
        }
    }
    
}