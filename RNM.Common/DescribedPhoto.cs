using RNM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNM.Common
{
    public class DescribedPhoto : IDescribedPhoto
    {
        #region [Fields]

        private string description;
        private Bitmap image;

        #endregion

        #region [Constructors]

        public DescribedPhoto()
        {
            this.image = new Bitmap(Properties.Resources.No_Image_Available);
        }

        #endregion

        #region [Properties]

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public System.Drawing.Bitmap Images
        {
            get
            {
                return this.image;
            }
            set
            {
                this.image = value;
            }
        }

        #endregion
    }
}
