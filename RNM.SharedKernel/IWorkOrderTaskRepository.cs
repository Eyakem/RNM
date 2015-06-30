using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RNM.SharedKernel
{
    public interface IWorkOrderTaskRepository
    {
        void Commit();
    }
}
