using System.Collections.Generic;

namespace RNM.FaultResolution.Queries.Tests
{
    public class CompletedTaskFinder : ICompletedTaskFinder
    {
        public List<CompletedTaskDto> FindCompletedTasksByWorkOrder(int workOrderId, string roleName)
        {
            if (roleName != "Supervisor")
                throw new UnAuthorizedException("You are not authorised to use this functionality.");
            
            return new List<CompletedTaskDto>
            {
                new CompletedTaskDto()
            };
        }
    }

    public interface ICompletedTaskFinder
    {
        List<CompletedTaskDto> FindCompletedTasksByWorkOrder(int workOrderId, string roleName);
    }
}
