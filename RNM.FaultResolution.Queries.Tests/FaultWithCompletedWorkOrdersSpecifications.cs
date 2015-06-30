using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNM.FaultResolution.Queries.Tests
{
    public class FaultWithCompletedWorkOrdersSpecifications
    {
        public List<FaultWithCompletedWorkOrdersDto> No_faults_with_completed_work_orders
        {
            get
            {
                return new List<FaultWithCompletedWorkOrdersDto>();
            }
        }

        public List<FaultWithCompletedWorkOrdersDto> Faults_with_completed_work_orders
        {
            get
            {
                return new List<FaultWithCompletedWorkOrdersDto>
                {
                    new FaultWithCompletedWorkOrdersDto(),
                    new FaultWithCompletedWorkOrdersDto()
                };
            }
        }
    }
}
