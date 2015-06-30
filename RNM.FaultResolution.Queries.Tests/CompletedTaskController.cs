using System.Collections.Generic;

namespace RNM.FaultResolution.Queries.Tests
{
    public class CompletedTaskController
    {
        private readonly ICompletedTaskFinder completedTaskFinder;

        public CompletedTaskController(ICompletedTaskFinder completedTaskFinder)
        {
            this.completedTaskFinder = completedTaskFinder;
        }

        public List<CompletedTaskDto> FindCompletedTasksByWorkOrder(int workOrderId, string roleName)
        {
            return completedTaskFinder.FindCompletedTasksByWorkOrder(workOrderId, roleName);
        }
    }
}
