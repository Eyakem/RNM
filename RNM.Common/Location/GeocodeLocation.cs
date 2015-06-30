
namespace RNM.Common
{
    #region [Namespace]

    using RNM.Common.Constants;
    using RNM.Common.Interfaces;

    #endregion

    public class GeocodeLocation : BaseLocation, IGeocodeLocation
    {
        #region [Fields]

        private decimal latitude;
        private decimal longtude;

        #endregion

        #region [Constructors]

        public GeocodeLocation(LocationType type)
            : base(type)
        {
        }

        #endregion

        #region [Properties]

        public decimal Longtude
        {
            get
            {
                return this.longtude;
            }
            set
            {
                this.longtude = value;
            }
        }

        public decimal Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                this.latitude = value;
            }
        }

        #endregion
    }
}
