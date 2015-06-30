using System.Collections.Generic;

namespace RNM.FaultResolution.Queries.Tests
{
    public class CompletedTask
    {
        public List<CompletedTaskDto> No_completed_tasks
        {
            get
            {
                return new List<CompletedTaskDto>();
            }
        }

        public List<CompletedTaskDto> Completed_tasks_with_results
        {
            get
            {
                return new List<CompletedTaskDto>
                {
                    new CompletedTaskDto(),
                    new CompletedTaskDto()
                };
            }
        }

    }
}
