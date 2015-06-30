using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.Common.Interfaces
{
   public interface IDescribedPhoto
    {
        string Description { get; set; }
        Bitmap Images { get; set; }
    }
}
