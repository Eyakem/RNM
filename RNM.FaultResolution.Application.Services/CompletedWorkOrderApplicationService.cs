using System;
using RNM.FaultResolution.Domain.Models;
using RNM.FaultResolution.Domain.Services;

namespace RNM.FaultResolution.Application.Services
{
    public class CompletedWorkOrderApplicationService
    {
        private readonly IAuthenticateUserService authenticationService;
        private readonly ICompletedWorkOrderRepository completedWorkOrderRepository;

        //IAuditLogger from the Shared Kernel can be injected here as well
        public CompletedWorkOrderApplicationService(IAuthenticateUserService authenticationService, ICompletedWorkOrderRepository completedWorkOrderRepository)
        {
            this.authenticationService = authenticationService;
            this.completedWorkOrderRepository = completedWorkOrderRepository;
        }

        public  void CreateNewIssuedWorkOrder(string roleName)
        {
           if(!authenticationService.IsSupervisor(roleName))
               throw new UnAuthorizedException("You are not authorised to create issued work order");
           
            var completedWorkOrder = CompletedWorkOrder.CreateNewIssuedWorkOrder(Guid.NewGuid());
            completedWorkOrderRepository.Commit();
        }

        public void SignOffWorkOrder(Guid workOrderId, string roleName)
        {
            if (!authenticationService.IsSupervisor(roleName))
                throw new UnAuthorizedException("You are not authorised to sign off a work order");
            
        }
    }
}
