
namespace RNM.Common
{
    #region [Namespace]

    using RNM.Common.Constants;
    using RNM.Common.Interfaces;

    #endregion

    public class PhysicalLocation : BaseLocation, IPhysicalLocation
    {
        #region  [Fields]
        
        private int streetNumber;
        private string streetName;
        private string suburb;

        #endregion

        #region [Constructor]
        
        public PhysicalLocation(LocationType type)
            : base(type)
        {
        } 
        
        #endregion

        #region [Properties]
        
        public int StreetNumber
        {
            get
            {
                return this.streetNumber;
            }
            set
            {
                this.streetNumber = value;
            }
        }

        public string StreetName
        {
            get
            {
                return this.streetName;
            }
            set
            {
                this.streetName = value;
            }
        }

        public string Suburb
        {
            get
            {
                return this.suburb;
            }
            set
            {
                this.suburb = value;
            }
        }

        #endregion
    }
}
