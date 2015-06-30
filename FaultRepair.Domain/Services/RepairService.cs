using FaultRepair.Domain.Interface.InfrastructureInterface;
using FaultRepair.Domain.Interface.ServiceInterface;
using FaultRepair.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FaultRepair.Domain.Services
{
    public class RepairService : IRepairService
    {
        private IWorkOrderFactory factory;
        private IPrincipal principal;

        public RepairService(IPrincipal principal, IWorkOrderFactory factory)
        {
            this.principal = principal;
            this.factory = factory;
        }

        public WorkOrder CreateWorkOrder()
        {
            if (!this.principal.IsInRole(WorkOrderRoles.Create))
            {
                throw new UnauthorizedAccessException("You need to have " + WorkOrderRoles.Create + " role");
            }
            return this.factory.Create();
        }

        public WorkOrder Create()
        {
           return this.factory.Create();
        }
    }
}
