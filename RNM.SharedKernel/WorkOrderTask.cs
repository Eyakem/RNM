using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNM.SharedKernel
{
    public class WorkOrderTask
    {
        public string Description { get; private set; }
        public Guid Id { get; private set; }
        public Guid WorkOrderId { get; private set; }
        public static WorkOrderTask CreateNew(Guid workOrderId, string description)
        {
            if (string.IsNullOrEmpty(description))
                throw new InvalidModelException("Description cannot be empty");

            if (workOrderId == Guid.Empty)
                throw new InvalidModelException("Work Order Id is required");
           
            return new WorkOrderTask
            {
                Id = Guid.NewGuid(),
                WorkOrderId = workOrderId,
                Description = description
            };
        }
    }
}
