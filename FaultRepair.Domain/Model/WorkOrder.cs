
namespace FaultRepair.Domain.Model
{
    public class WorkOrder
    {
        public WorkOrderStatus Status { get; private set; }

        public WorkOrder()
        {
            this.Status = WorkOrderStatus.New;
        }
    }
}
