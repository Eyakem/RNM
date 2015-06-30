using FaultRepair.Domain.Model;

namespace FaultRepair.Domain.Interface.InfrastructureInterface
{
    public interface IWorkOrderFactory
    {
        WorkOrder Create();
    }
}
