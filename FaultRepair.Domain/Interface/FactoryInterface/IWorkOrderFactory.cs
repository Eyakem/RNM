using FaultRepair.Domain.Model;

namespace FaultRepair.Domain.Interface.FactoryInterface
{
    public interface IWorkOrderFactory
    {
        WorkOrder Create();
    }
}
