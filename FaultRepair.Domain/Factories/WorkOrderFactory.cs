using FaultRepair.Domain.Interface.InfrastructureInterface;
using FaultRepair.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaultRepair.Domain.Factories
{
    public class WorkOrderFactory : IWorkOrderFactory
    {
        public WorkOrder Create()
        {
            return new WorkOrder();
        }
    }
}
