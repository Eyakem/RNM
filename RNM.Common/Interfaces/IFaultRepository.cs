
namespace RNM.Common.Interfaces
{

    #region [Namespace]

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public interface IFaultRepository
    {
        void Save(IFault fault);

        void Update(IFault fault);
    }
}
