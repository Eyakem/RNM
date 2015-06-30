using System;

namespace RNM.SharedKernel
{
    public interface IWorkOrderTaskServicecs
    {
        void CreateTask(Guid workOrderId, string description);
    }

    public class WorkOrderTaskService:IWorkOrderTaskServicecs
    {
        public IWorkOrderTaskRepository workOrderTaskRepository;

        public WorkOrderTaskService(IWorkOrderTaskRepository workOrderTaskRepository)
        {
            this.workOrderTaskRepository = workOrderTaskRepository;
        }

        public void CreateTask(Guid workOrderId, string description)
        {
            var workOrderTask = WorkOrderTask.CreateNew(workOrderId,description);
            workOrderTaskRepository.Commit();
        }
    }
}
