
using System;
using RNM.FaultResolution.Domain.Models;

namespace RNM.FaultResolution.Application.Services
{
    public interface ICompletedWorkOrderRepository
    {
        void Commit();
        CompletedWorkOrder GetById(Guid id);
    }
}
